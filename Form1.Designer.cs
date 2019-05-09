namespace TwitterCrawler
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.url_textBox = new System.Windows.Forms.TextBox();
			this.url_label = new System.Windows.Forms.Label();
			this.startButton = new System.Windows.Forms.Button();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.minimizeBtn = new System.Windows.Forms.Button();
			this.closeBtn = new System.Windows.Forms.Button();
			this.id_textBox = new System.Windows.Forms.TextBox();
			this.id_label = new System.Windows.Forms.Label();
			this.directory_label = new System.Windows.Forms.Label();
			this.fromLabel = new System.Windows.Forms.Label();
			this.pw_label = new System.Windows.Forms.Label();
			this.pw_textBox = new System.Windows.Forms.TextBox();
			this.comboBox_FromMonth = new System.Windows.Forms.ComboBox();
			this.directory_textBox = new System.Windows.Forms.TextBox();
			this.comboBox_ToMonth = new System.Windows.Forms.ComboBox();
			this.selectDirectoryButton = new System.Windows.Forms.Button();
			this.comboBox_FromYear = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.toLabel = new System.Windows.Forms.Label();
			this.comboBox_ToYear = new System.Windows.Forms.ComboBox();
			this.logIn_CheckBox = new System.Windows.Forms.CheckBox();
			this.log_textBox = new System.Windows.Forms.TextBox();
			this.titlePanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// url_textBox
			// 
			this.url_textBox.Location = new System.Drawing.Point(84, 10);
			this.url_textBox.Name = "url_textBox";
			this.url_textBox.Size = new System.Drawing.Size(267, 21);
			this.url_textBox.TabIndex = 6;
			// 
			// url_label
			// 
			this.url_label.AutoSize = true;
			this.url_label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
			this.url_label.Location = new System.Drawing.Point(3, 13);
			this.url_label.Name = "url_label";
			this.url_label.Size = new System.Drawing.Size(81, 12);
			this.url_label.TabIndex = 1;
			this.url_label.Text = "Twitter URL";
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(357, 10);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 23);
			this.startButton.TabIndex = 7;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// titlePanel
			// 
			this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
			this.titlePanel.Controls.Add(this.minimizeBtn);
			this.titlePanel.Controls.Add(this.closeBtn);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Padding = new System.Windows.Forms.Padding(1);
			this.titlePanel.Size = new System.Drawing.Size(867, 25);
			this.titlePanel.TabIndex = 16;
			this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
			// 
			// minimizeBtn
			// 
			this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
			this.minimizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
			this.minimizeBtn.FlatAppearance.BorderSize = 0;
			this.minimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
			this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
			this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.minimizeBtn.ForeColor = System.Drawing.Color.White;
			this.minimizeBtn.Location = new System.Drawing.Point(786, 1);
			this.minimizeBtn.Name = "minimizeBtn";
			this.minimizeBtn.Size = new System.Drawing.Size(40, 23);
			this.minimizeBtn.TabIndex = 18;
			this.minimizeBtn.Text = "─";
			this.minimizeBtn.UseVisualStyleBackColor = false;
			this.minimizeBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minimizeBtn_MouseDown);
			// 
			// closeBtn
			// 
			this.closeBtn.BackColor = System.Drawing.Color.Transparent;
			this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.closeBtn.ForeColor = System.Drawing.Color.White;
			this.closeBtn.Location = new System.Drawing.Point(826, 1);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.closeBtn.Size = new System.Drawing.Size(40, 23);
			this.closeBtn.TabIndex = 17;
			this.closeBtn.Text = "X";
			this.closeBtn.UseVisualStyleBackColor = false;
			this.closeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeBtn_Click);
			// 
			// id_textBox
			// 
			this.id_textBox.Location = new System.Drawing.Point(84, 7);
			this.id_textBox.Name = "id_textBox";
			this.id_textBox.Size = new System.Drawing.Size(164, 21);
			this.id_textBox.TabIndex = 0;
			// 
			// id_label
			// 
			this.id_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.id_label.AutoSize = true;
			this.id_label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.id_label.Location = new System.Drawing.Point(10, 10);
			this.id_label.Name = "id_label";
			this.id_label.Size = new System.Drawing.Size(68, 12);
			this.id_label.TabIndex = 2;
			this.id_label.Text = "Twitter ID";
			// 
			// directory_label
			// 
			this.directory_label.AutoSize = true;
			this.directory_label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.directory_label.Location = new System.Drawing.Point(9, 10);
			this.directory_label.Name = "directory_label";
			this.directory_label.Size = new System.Drawing.Size(64, 12);
			this.directory_label.TabIndex = 8;
			this.directory_label.Text = "Directory";
			// 
			// fromLabel
			// 
			this.fromLabel.AutoSize = true;
			this.fromLabel.Location = new System.Drawing.Point(504, 15);
			this.fromLabel.Name = "fromLabel";
			this.fromLabel.Size = new System.Drawing.Size(34, 12);
			this.fromLabel.TabIndex = 10;
			this.fromLabel.Text = "From";
			// 
			// pw_label
			// 
			this.pw_label.AutoSize = true;
			this.pw_label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.pw_label.Location = new System.Drawing.Point(8, 12);
			this.pw_label.Name = "pw_label";
			this.pw_label.Size = new System.Drawing.Size(70, 12);
			this.pw_label.TabIndex = 4;
			this.pw_label.Text = "Password";
			// 
			// pw_textBox
			// 
			this.pw_textBox.Location = new System.Drawing.Point(84, 9);
			this.pw_textBox.Name = "pw_textBox";
			this.pw_textBox.Size = new System.Drawing.Size(164, 21);
			this.pw_textBox.TabIndex = 1;
			this.pw_textBox.UseSystemPasswordChar = true;
			// 
			// comboBox_FromMonth
			// 
			this.comboBox_FromMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_FromMonth.FormattingEnabled = true;
			this.comboBox_FromMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
			this.comboBox_FromMonth.Location = new System.Drawing.Point(605, 10);
			this.comboBox_FromMonth.Name = "comboBox_FromMonth";
			this.comboBox_FromMonth.Size = new System.Drawing.Size(57, 20);
			this.comboBox_FromMonth.TabIndex = 12;
			// 
			// directory_textBox
			// 
			this.directory_textBox.Location = new System.Drawing.Point(84, 9);
			this.directory_textBox.Name = "directory_textBox";
			this.directory_textBox.Size = new System.Drawing.Size(267, 21);
			this.directory_textBox.TabIndex = 2;
			// 
			// comboBox_ToMonth
			// 
			this.comboBox_ToMonth.Dock = System.Windows.Forms.DockStyle.Right;
			this.comboBox_ToMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_ToMonth.FormattingEnabled = true;
			this.comboBox_ToMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
			this.comboBox_ToMonth.Location = new System.Drawing.Point(784, 10);
			this.comboBox_ToMonth.Name = "comboBox_ToMonth";
			this.comboBox_ToMonth.Size = new System.Drawing.Size(57, 20);
			this.comboBox_ToMonth.TabIndex = 15;
			// 
			// selectDirectoryButton
			// 
			this.selectDirectoryButton.Location = new System.Drawing.Point(357, 9);
			this.selectDirectoryButton.Name = "selectDirectoryButton";
			this.selectDirectoryButton.Size = new System.Drawing.Size(92, 20);
			this.selectDirectoryButton.TabIndex = 3;
			this.selectDirectoryButton.Text = "Choose";
			this.selectDirectoryButton.UseVisualStyleBackColor = true;
			this.selectDirectoryButton.Click += new System.EventHandler(this.selectDirectoryButton_Click);
			// 
			// comboBox_FromYear
			// 
			this.comboBox_FromYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_FromYear.FormattingEnabled = true;
			this.comboBox_FromYear.Location = new System.Drawing.Point(544, 10);
			this.comboBox_FromYear.Name = "comboBox_FromYear";
			this.comboBox_FromYear.Size = new System.Drawing.Size(64, 20);
			this.comboBox_FromYear.TabIndex = 13;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.logIn_CheckBox);
			this.panel1.Controls.Add(this.id_label);
			this.panel1.Controls.Add(this.id_textBox);
			this.panel1.Location = new System.Drawing.Point(6, 6);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(1, 10, 1, 1);
			this.panel1.Size = new System.Drawing.Size(842, 40);
			this.panel1.TabIndex = 17;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.panel4);
			this.flowLayoutPanel1.Controls.Add(this.panel3);
			this.flowLayoutPanel1.Controls.Add(this.log_textBox);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 30);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(858, 390);
			this.flowLayoutPanel1.TabIndex = 16;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.pw_label);
			this.panel2.Controls.Add(this.pw_textBox);
			this.panel2.Location = new System.Drawing.Point(6, 52);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(1, 10, 1, 1);
			this.panel2.Size = new System.Drawing.Size(842, 40);
			this.panel2.TabIndex = 3;
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.Controls.Add(this.directory_label);
			this.panel4.Controls.Add(this.directory_textBox);
			this.panel4.Controls.Add(this.selectDirectoryButton);
			this.panel4.Location = new System.Drawing.Point(6, 98);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(1, 10, 1, 1);
			this.panel4.Size = new System.Drawing.Size(842, 40);
			this.panel4.TabIndex = 18;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.Controls.Add(this.toLabel);
			this.panel3.Controls.Add(this.comboBox_ToYear);
			this.panel3.Controls.Add(this.comboBox_ToMonth);
			this.panel3.Controls.Add(this.startButton);
			this.panel3.Controls.Add(this.comboBox_FromYear);
			this.panel3.Controls.Add(this.comboBox_FromMonth);
			this.panel3.Controls.Add(this.url_label);
			this.panel3.Controls.Add(this.url_textBox);
			this.panel3.Controls.Add(this.fromLabel);
			this.panel3.Location = new System.Drawing.Point(6, 144);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(1, 10, 1, 1);
			this.panel3.Size = new System.Drawing.Size(842, 40);
			this.panel3.TabIndex = 17;
			// 
			// toLabel
			// 
			this.toLabel.AutoSize = true;
			this.toLabel.Location = new System.Drawing.Point(694, 15);
			this.toLabel.Name = "toLabel";
			this.toLabel.Size = new System.Drawing.Size(20, 12);
			this.toLabel.TabIndex = 18;
			this.toLabel.Text = "To";
			// 
			// comboBox_ToYear
			// 
			this.comboBox_ToYear.Dock = System.Windows.Forms.DockStyle.Right;
			this.comboBox_ToYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_ToYear.FormattingEnabled = true;
			this.comboBox_ToYear.Location = new System.Drawing.Point(720, 10);
			this.comboBox_ToYear.Name = "comboBox_ToYear";
			this.comboBox_ToYear.Size = new System.Drawing.Size(64, 20);
			this.comboBox_ToYear.TabIndex = 17;
			// 
			// logIn_CheckBox
			// 
			this.logIn_CheckBox.AutoSize = true;
			this.logIn_CheckBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.logIn_CheckBox.Location = new System.Drawing.Point(357, 9);
			this.logIn_CheckBox.Name = "logIn_CheckBox";
			this.logIn_CheckBox.Size = new System.Drawing.Size(272, 16);
			this.logIn_CheckBox.TabIndex = 17;
			this.logIn_CheckBox.Text = "I don\'t need LogIn(Except Blind Twit)";
			this.logIn_CheckBox.UseVisualStyleBackColor = true;
			this.logIn_CheckBox.CheckedChanged += new System.EventHandler(this.logIn_CheckBox_CheckedChanged);
			// 
			// log_textBox
			// 
			this.log_textBox.Location = new System.Drawing.Point(6, 190);
			this.log_textBox.Multiline = true;
			this.log_textBox.Name = "log_textBox";
			this.log_textBox.ReadOnly = true;
			this.log_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.log_textBox.Size = new System.Drawing.Size(842, 194);
			this.log_textBox.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(867, 426);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.titlePanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(867, 426);
			this.Name = "Form1";
			this.Text = "TwitterMediaCrawlerV1.1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Closing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.titlePanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox url_textBox;
		private System.Windows.Forms.Label url_label;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Button minimizeBtn;
		private System.Windows.Forms.TextBox id_textBox;
		private System.Windows.Forms.Label id_label;
		private System.Windows.Forms.Label directory_label;
		private System.Windows.Forms.Label fromLabel;
		private System.Windows.Forms.Label pw_label;
		private System.Windows.Forms.TextBox pw_textBox;
		private System.Windows.Forms.ComboBox comboBox_FromMonth;
		private System.Windows.Forms.TextBox directory_textBox;
		private System.Windows.Forms.ComboBox comboBox_ToMonth;
		private System.Windows.Forms.Button selectDirectoryButton;
		private System.Windows.Forms.ComboBox comboBox_FromYear;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label toLabel;
		private System.Windows.Forms.ComboBox comboBox_ToYear;
		private System.Windows.Forms.CheckBox logIn_CheckBox;
		private System.Windows.Forms.TextBox log_textBox;
	}
}

