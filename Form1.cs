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
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

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

			TwitCrawler crawler = new TwitCrawler();
			crawler.Init(this);
			crawler.StartCrawling(url, id, pw);
		}

		private void id_textBox_TextChanged(object sender, EventArgs e)
		{

		}

		public void AppendLogLine(string text)
		{
			log_textBox.AppendText(text + "\n");
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
		}

		public string GetDirectoryPath()
		{
			return directory_textBox.Text;
		}
	}
}
