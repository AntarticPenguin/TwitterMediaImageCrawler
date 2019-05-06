using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TwitterCrawler
{
	public partial class Form1 : Form
	{
		delegate void AppendLineDelegate(string text);

		public Form1()
		{
			InitializeComponent();
			InitializeComboBox();
			LoadConfig();
		}

		void InitializeComboBox()
		{
			string year = System.DateTime.Now.ToString("yyyy");
			for(int i = 2006; i <= Convert.ToInt32(year); i++)
			{
				comboBox_FromYear.Items.Add(i);
				comboBox_ToYear.Items.Add(i);
			}
			comboBox_FromYear.SelectedIndex = 0;
			comboBox_FromMonth.SelectedIndex = 0;
			comboBox_ToYear.SelectedIndex = comboBox_ToYear.Items.Count - 1;
			comboBox_ToMonth.SelectedIndex = comboBox_ToMonth.Items.Count - 1;
		}

		void LoadConfig()
		{
			try
			{
				using (StreamReader sr = new StreamReader("Config.ini"))
				{
					while (!sr.EndOfStream)
					{
						string line = sr.ReadLine();
						if (line.Equals("[TwitterID]"))
						{
							id_textBox.Text = sr.ReadLine();
						}
						else if (line.Equals("[Directory]"))
						{
							directory_textBox.Text = sr.ReadLine();
						}
					}
				}
			}
			catch(Exception e)
			{
				AppendLogLine("No Config.ini");
			}
		}

		void SaveConfig()
		{
			StreamWriter sw = new StreamWriter("Config.ini");
			sw.WriteLine("[TwitterID]");
			sw.WriteLine(id_textBox.Text + Environment.NewLine);
			sw.WriteLine("[Directory]");
			sw.WriteLine(directory_textBox.Text);
			sw.Close();
		}

		public string GetDirectoryPath()
		{
			return directory_textBox.Text;
		}

		public void AppendLogLine(string text)
		{
			if (log_textBox.InvokeRequired)
			{
				AppendLineDelegate appendLineDelegate = new AppendLineDelegate(AppendLogLine);
				log_textBox.Invoke(appendLineDelegate, text);
			}
			else
			{
				log_textBox.AppendText(text);
				log_textBox.AppendText(Environment.NewLine);
			}
		}

		#region EVENT

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Location = Properties.Settings.Default.F1Location;
		}

		private void Form1_Closing(object sender, FormClosedEventArgs e)
		{
			Properties.Settings.Default.F1Location = this.Location;
			Properties.Settings.Default.Save();
		}

		private void url_textBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void pw_label_Click(object sender, EventArgs e)
		{

		}

		private void startButton_Click(object sender, EventArgs e)
		{
			string url = url_textBox.Text;
			string id = id_textBox.Text;
			string pw = pw_textBox.Text;
			int fromYear = int.Parse(comboBox_FromYear.Text);
			int fromMonth = int.Parse(comboBox_FromMonth.Text);
			int toYear = int.Parse(comboBox_ToYear.Text);
			int toMonth = int.Parse(comboBox_ToMonth.Text);

			TwitCrawler crawler = new TwitCrawler();
			crawler.Init(this);
			crawler.InitRange(fromYear, fromMonth, toYear, toMonth);
			crawler.StartCrawling(url, id, pw);
		}

		private void id_textBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void url_label_Click(object sender, EventArgs e)
		{

		}

		private void selectDirectoryButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.ShowDialog();
			string path = dialog.SelectedPath;
			directory_textBox.Text = path + @"\";

			SaveConfig();
		}

		private void fromLabel_Click(object sender, EventArgs e)
		{

		}

		private void comboBox_FromYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void comboBox_FromMonth_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox_ToYear_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox_ToMonth_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		#endregion
	}
}
