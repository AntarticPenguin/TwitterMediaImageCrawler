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
			this.id_label = new System.Windows.Forms.Label();
			this.id_textBox = new System.Windows.Forms.TextBox();
			this.pw_label = new System.Windows.Forms.Label();
			this.pw_textBox = new System.Windows.Forms.TextBox();
			this.startButton = new System.Windows.Forms.Button();
			this.log_textBox = new System.Windows.Forms.TextBox();
			this.directory_label = new System.Windows.Forms.Label();
			this.directory_textBox = new System.Windows.Forms.TextBox();
			this.selectDirectoryButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// url_textBox
			// 
			this.url_textBox.Location = new System.Drawing.Point(117, 84);
			this.url_textBox.Name = "url_textBox";
			this.url_textBox.Size = new System.Drawing.Size(563, 21);
			this.url_textBox.TabIndex = 4;
			this.url_textBox.TextChanged += new System.EventHandler(this.url_textBox_TextChanged);
			// 
			// url_label
			// 
			this.url_label.AutoSize = true;
			this.url_label.Font = new System.Drawing.Font("굴림", 14F);
			this.url_label.Location = new System.Drawing.Point(12, 86);
			this.url_label.Name = "url_label";
			this.url_label.Size = new System.Drawing.Size(99, 19);
			this.url_label.TabIndex = 1;
			this.url_label.Text = "Twitter URL";
			this.url_label.Click += new System.EventHandler(this.url_label_Click);
			// 
			// id_label
			// 
			this.id_label.AutoSize = true;
			this.id_label.Location = new System.Drawing.Point(14, 29);
			this.id_label.Name = "id_label";
			this.id_label.Size = new System.Drawing.Size(58, 12);
			this.id_label.TabIndex = 2;
			this.id_label.Text = "Twitter ID";
			// 
			// id_textBox
			// 
			this.id_textBox.Location = new System.Drawing.Point(90, 26);
			this.id_textBox.Name = "id_textBox";
			this.id_textBox.Size = new System.Drawing.Size(164, 21);
			this.id_textBox.TabIndex = 0;
			this.id_textBox.TextChanged += new System.EventHandler(this.id_textBox_TextChanged);
			// 
			// pw_label
			// 
			this.pw_label.AutoSize = true;
			this.pw_label.Location = new System.Drawing.Point(285, 29);
			this.pw_label.Name = "pw_label";
			this.pw_label.Size = new System.Drawing.Size(62, 12);
			this.pw_label.TabIndex = 4;
			this.pw_label.Text = "Password";
			this.pw_label.Click += new System.EventHandler(this.pw_label_Click);
			// 
			// pw_textBox
			// 
			this.pw_textBox.Location = new System.Drawing.Point(366, 26);
			this.pw_textBox.Name = "pw_textBox";
			this.pw_textBox.Size = new System.Drawing.Size(100, 21);
			this.pw_textBox.TabIndex = 1;
			this.pw_textBox.UseSystemPasswordChar = true;
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(704, 82);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 23);
			this.startButton.TabIndex = 5;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// log_textBox
			// 
			this.log_textBox.Location = new System.Drawing.Point(16, 118);
			this.log_textBox.Multiline = true;
			this.log_textBox.Name = "log_textBox";
			this.log_textBox.ReadOnly = true;
			this.log_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.log_textBox.Size = new System.Drawing.Size(763, 320);
			this.log_textBox.TabIndex = 6;
			// 
			// directory_label
			// 
			this.directory_label.AutoSize = true;
			this.directory_label.Location = new System.Drawing.Point(17, 59);
			this.directory_label.Name = "directory_label";
			this.directory_label.Size = new System.Drawing.Size(55, 12);
			this.directory_label.TabIndex = 8;
			this.directory_label.Text = "Directory";
			// 
			// directory_textBox
			// 
			this.directory_textBox.Location = new System.Drawing.Point(91, 56);
			this.directory_textBox.Name = "directory_textBox";
			this.directory_textBox.Size = new System.Drawing.Size(375, 21);
			this.directory_textBox.TabIndex = 2;
			// 
			// selectDirectoryButton
			// 
			this.selectDirectoryButton.Location = new System.Drawing.Point(476, 56);
			this.selectDirectoryButton.Name = "selectDirectoryButton";
			this.selectDirectoryButton.Size = new System.Drawing.Size(92, 20);
			this.selectDirectoryButton.TabIndex = 3;
			this.selectDirectoryButton.Text = "Choose";
			this.selectDirectoryButton.UseVisualStyleBackColor = true;
			this.selectDirectoryButton.Click += new System.EventHandler(this.selectDirectoryButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.selectDirectoryButton);
			this.Controls.Add(this.directory_textBox);
			this.Controls.Add(this.directory_label);
			this.Controls.Add(this.log_textBox);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.pw_textBox);
			this.Controls.Add(this.pw_label);
			this.Controls.Add(this.id_textBox);
			this.Controls.Add(this.id_label);
			this.Controls.Add(this.url_label);
			this.Controls.Add(this.url_textBox);
			this.Name = "Form1";
			this.Text = "TwitterMediaCrawlerV1.1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Closing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox url_textBox;
		private System.Windows.Forms.Label url_label;
		private System.Windows.Forms.Label id_label;
		private System.Windows.Forms.TextBox id_textBox;
		private System.Windows.Forms.Label pw_label;
		private System.Windows.Forms.TextBox pw_textBox;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.TextBox log_textBox;
		private System.Windows.Forms.Label directory_label;
		private System.Windows.Forms.TextBox directory_textBox;
		private System.Windows.Forms.Button selectDirectoryButton;
	}
}

