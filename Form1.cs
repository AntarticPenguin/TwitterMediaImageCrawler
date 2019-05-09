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
using System.Runtime.InteropServices;

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

			_bDontNeedLogIn = false;
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

		//const int sizeGrip = 16;
		//protected override void WndProc(ref Message m)
		//{
		//	/*
		//	 * 0x84 = WM_NCHITTEST - Mouse Capture Test
		//	 * 0x1 = HTCLIENT - Application Client Area
		//	 * 0x2 = HTCAPTION - Application Title Bar
		//	 */
		//	 //sizing
		//	if(m.Msg == 0x84)
		//	{
		//		Point pos = new Point(m.LParam.ToInt32());
		//		pos = PointToClient(pos);
		//		if(pos.X >= ClientSize.Width - sizeGrip && pos.Y >= ClientSize.Height - sizeGrip)
		//		{
		//			m.Result = (IntPtr)17;
		//			return;
		//		}
		//	}
		//	base.WndProc(ref m);
		//}

		public const int WM_NCLBUTTONDOWN = 0x00A1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		private void titlePanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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

		private void startButton_Click(object sender, EventArgs e)
		{
			string url = url_textBox.Text;
			string id = id_textBox.Text;
			string pw = pw_textBox.Text;
			int fromYear = int.Parse(comboBox_FromYear.Text);
			int fromMonth = int.Parse(comboBox_FromMonth.Text);
			int toYear = int.Parse(comboBox_ToYear.Text);
			int toMonth = int.Parse(comboBox_ToMonth.Text);

			if (url.Equals(""))
			{
				AppendLogLine("Please Enter Twitter URL");
			}
			else
			{
				TwitCrawler crawler = new TwitCrawler();
				crawler.Init(this);
				crawler.InitRange(fromYear, fromMonth, toYear, toMonth);
				crawler.StartCrawling(url, id, pw, _bDontNeedLogIn);
			}
		}

		private void selectDirectoryButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			DialogResult result = dialog.ShowDialog();

			if(DialogResult.OK == result)
			{
				string path = dialog.SelectedPath;
				directory_textBox.Text = path + @"\";
				SaveConfig();
			}
		}

		private void closeBtn_Click(object sender, MouseEventArgs e)
		{
			DialogResult result = MessageBox.Show("Close TwitCrawler", "CloseBox", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if (result == DialogResult.Yes)
				Close();
		}

		private void minimizeBtn_MouseDown(object sender, MouseEventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		bool _bDontNeedLogIn;
		private void logIn_CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (CheckState.Checked == logIn_CheckBox.CheckState)
			{
				_bDontNeedLogIn = true;
				id_textBox.Enabled = false;
				pw_textBox.Enabled = false;
			}
			else
			{
				_bDontNeedLogIn = false;
				id_textBox.Enabled = true;
				pw_textBox.Enabled = true;
			}
		}

		#endregion
	}
}
