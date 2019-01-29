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

	public void Init(Form1 form)
	{
		_windowForm = form;
	}

	public void StartCrawling(string url, string id, string password)
	{
		_windowForm.AppendLogLine("Start Crawling");
		Thread thread = new Thread(() => CrawlAsync(url, id, password));
		thread.Start();
	}

	async void CrawlAsync(string url, string id, string password)
	{
		var chromeDriverService = ChromeDriverService.CreateDefaultService();
		chromeDriverService.HideCommandPromptWindow = true;
		_driver = new ChromeDriver(chromeDriverService);

		_windowForm.AppendLogLine("URL: " + url);
		_driver.Navigate().GoToUrl(url);

		_windowForm.AppendLogLine("LoginTwitter: " + id);
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
		_windowForm.AppendLogLine("Checking Contents.....");

		//.//div/div/div[3] => div class AdaptiveMediaOuterContatiner

		_contentsList = new List<IWebElement>();

		int count = 0;
		while(true)
		{
			var loadContents = _driver.FindElementsByXPath(".//*[@id='timeline']/div/div[2]/ol[1]/li");
			if (count == loadContents.Count)
			{
				_windowForm.AppendLogLine("content Count: " + loadContents.Count);
				break;
			}

			for(int i = count; i < loadContents.Count; i++)
			{
				_contentsList.Add(loadContents[i]);
				count++;
			}

			Actions action = new Actions(_driver);
			action.MoveToElement(_contentsList[count - 1]).Perform();

			//_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2); //not working why?
			Thread.Sleep(1500);
		}
	}

	async Task DownloadContentsImageAsync()
	{
		_windowForm.AppendLogLine("Start DownloadImage");

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
						_windowForm.AppendLogLine("Image Src: " + orignalImageSrc);

						//webClient.DownloadFile(new Uri(orignalImageSrc), finalPath);
						await webClient.DownloadFileTaskAsync(new Uri(orignalImageSrc), finalPath);
						totalCount++;
					}
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine("Error: {0}", exception);
				_windowForm.AppendLogLine("This link maybe not Image or just thumbnail of video");
			}
		}
		_windowForm.AppendLogLine("Finish Download. Total Image: " + totalCount);
		webClient.Dispose();
	}
}
