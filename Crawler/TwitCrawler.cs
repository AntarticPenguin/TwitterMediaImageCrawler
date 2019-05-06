using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System.Net;
using System.Drawing;
using System.IO;
using TwitterCrawler;

public class TwitCrawler
{
	Form1 _windowForm;
	ChromeDriver _driver;
	List<IWebElement> _contentsList;
	string _lang = "ko";
	int _fromYear;
	int _fromMonth;
	int _toYear;
	int _toMonth;

	public void Init(Form1 form)
	{
		_windowForm = form;
	}

	public void StartCrawling(string url, string id, string password)
	{
		WriteLog("Start Crawling");
		Thread thread = new Thread(() => CrawlAsync(url, id, password));
		thread.Start();
	}

	public void InitRange(int fromYear, int fromMonth, int toYear, int toMonth)
	{
		_fromYear = fromYear;
		_fromMonth = fromMonth;
		_toYear = toYear;
		_toMonth = toMonth;
	}

	async void CrawlAsync(string url, string id, string password)
	{
		var chromeDriverService = ChromeDriverService.CreateDefaultService();
		chromeDriverService.HideCommandPromptWindow = true;
		_driver = new ChromeDriver(chromeDriverService);

		if(false == url.Contains("/media"))
		{
			WriteLog("Add url /media");
			url += "/media";
		}
		WriteLog("URL: " + url);
		_driver.Navigate().GoToUrl(url);

		WriteLog("LoginTwitter: " + id);
		LoginTwitter(id, password);

		LoadDynamicContents();
		await DownloadContentsImageAsync();

		_driver.Close();
		_driver.Quit();
	}

	void LoginTwitter(string id, string password)
	{
		var loginBox = _driver.FindElement(By.Name("session[username_or_email]"));
		loginBox.SendKeys(id);

		var passwordBox = _driver.FindElement(By.Name("session[password]"));
		passwordBox.SendKeys(password);

		var loginButton = _driver.FindElement(By.XPath("//*[@id='signin-dropdown']/div[3]/form/input[1]"));
		loginButton.Click();

		_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
	}

	void LoadDynamicContents()
	{
		_lang = _driver.FindElementByXPath("/html").GetAttribute("lang");
		WriteLog("Detecting Language: " + _lang);
		WriteLog("Checking Contents.....");

		//.//div/div/div[3] => div class AdaptiveMediaOuterContatiner

		_contentsList = new List<IWebElement>();

		int count = 0;
		bool stop = false;
		while(true)
		{
			var loadContents = _driver.FindElementsByXPath(".//*[@id='timeline']/div/div[2]/ol[1]/li");
			if (count == loadContents.Count)
			{
				WriteLog("content Count: " + loadContents.Count);
				break;
			}

			for (int i = count; i < loadContents.Count; i++)
			{
				var date = loadContents[i].FindElement(By.ClassName("time")).Text;
				if (stop = StopCheckingDate(date))
				{
					WriteLog("STOP CHECKING");
					break;
				}

				if (CheckDateRange(date))
				{
					_contentsList.Add(loadContents[i]);
					count++;
				}
			}

			if (stop)
				break;

			Actions action = new Actions(_driver);
			action.MoveToElement(_contentsList[count - 1]).Perform();
			
			Thread.Sleep(1500);
		}
	}

	async Task DownloadContentsImageAsync()
	{
		WriteLog("Start DownloadImage");

		int totalCount = 0;
		WebClient webClient = new WebClient();

		_contentsList.Reverse();
		foreach (var item in _contentsList)
		{
			IReadOnlyCollection<IWebElement> imgList;
			try
			{
				imgList = item.FindElement(By.ClassName("AdaptiveMedia-container")).FindElements(By.TagName("img"));

				if (imgList != null)
				{
					foreach (var img in imgList)
					{
						string imgSrc = img.GetAttribute("src");

						int first = imgSrc.IndexOf("media") + "media/".Length;
						int last = imgSrc.Length - first;
						string fileName = imgSrc.Substring(first, last);
						string finalPath = Path.Combine(_windowForm.GetDirectoryPath(), fileName);

						string orignalImageSrc = imgSrc + ":orig";
						WriteLog("Image Src: " + orignalImageSrc);

						if(!File.Exists(finalPath))
						{
							await webClient.DownloadFileTaskAsync(new Uri(orignalImageSrc), finalPath);
							totalCount++;
						}
						else
						{
							WriteLog("File already exists.");
						}
					}
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine("Error: {0}", exception);
				WriteLog("This link maybe not Image or just thumbnail of video");
			}
		}
		WriteLog("Finish Download. Total Image: " + totalCount);
		webClient.Dispose();
	}

	void WriteLog(string log)
	{
		_windowForm.AppendLogLine(log);
	}

	bool CheckDateRange(string InDate)
	{
		if (_lang.Equals("ko"))
		{
			string[] date = InDate.Split('년', '월');
			if(date.Length == 2)
			{
				int year = DateTime.Now.Year;
				int month = int.Parse(date[0]);

				if (_fromYear < year && year < _toYear)
					return true;
				else if ((_fromYear == year || year == _toYear) && month <= _toMonth)
					return true;
			}
			else if(date.Length == 3)
			{
				WriteLog("YYMM");
				int year = int.Parse(date[0]);
				int month = int.Parse(date[1]);

				if (_fromYear < year && year < _toYear)
					return true;
				else if ((_fromYear == year || year == _toYear) && month <= _toMonth)
					return true;
			}
		}
		WriteLog("Skip");
		return false;
	}

	bool StopCheckingDate(string InDate)
	{
		if (_lang.Equals("ko"))
		{
			string[] date = InDate.Split('년', '월');
			if (date.Length == 2)
			{
				int year = DateTime.Now.Year;
				int month = int.Parse(date[0]);

				if (year < _fromYear)
					return true;
				else if ((year == _fromYear) && month < _fromMonth)
					return true;
			}
			else if (date.Length == 3)
			{
				int year = int.Parse(date[0]);
				int month = int.Parse(date[1]);

				if (year < _fromYear)
					return true;
				else if ((year == _fromYear) && month < _fromMonth)
					return true;
			}
		}
		return false;
	}
}
