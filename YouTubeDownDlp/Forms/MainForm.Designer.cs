namespace YouTubeDownDlp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ConvertRun_button = new System.Windows.Forms.Button();
            this.Url_textBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dlpUpdate_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.main_Control = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CookieUseBrowser_comboBox = new System.Windows.Forms.ComboBox();
            this.IsUseCookie_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IsLive_checkBox = new System.Windows.Forms.CheckBox();
            this.IsFormTheStartLivedown_checkBox = new System.Windows.Forms.CheckBox();
            this.outputpathReset_button = new System.Windows.Forms.Button();
            this.outputpathsave_button = new System.Windows.Forms.Button();
            this.ext_groupBox = new System.Windows.Forms.GroupBox();
            this.wav_radioButton = new System.Windows.Forms.RadioButton();
            this.mp3_radioButton = new System.Windows.Forms.RadioButton();
            this.mp4_radioButton = new System.Windows.Forms.RadioButton();
            this.OutputFolder_textBox = new System.Windows.Forms.TextBox();
            this.OutputFolderSelect_button = new System.Windows.Forms.Button();
            this.logPage = new System.Windows.Forms.TabPage();
            this.Log_richTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.main_Control.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ext_groupBox.SuspendLayout();
            this.logPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConvertRun_button
            // 
            this.ConvertRun_button.Location = new System.Drawing.Point(539, 6);
            this.ConvertRun_button.Name = "ConvertRun_button";
            this.ConvertRun_button.Size = new System.Drawing.Size(86, 272);
            this.ConvertRun_button.TabIndex = 0;
            this.ConvertRun_button.Text = "変換開始";
            this.ConvertRun_button.UseVisualStyleBackColor = true;
            this.ConvertRun_button.Click += new System.EventHandler(this.ConvertRun_button_Click);
            // 
            // Url_textBox
            // 
            this.Url_textBox.Location = new System.Drawing.Point(12, 28);
            this.Url_textBox.Name = "Url_textBox";
            this.Url_textBox.Size = new System.Drawing.Size(617, 25);
            this.Url_textBox.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dlpUpdate_toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(641, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dlpUpdate_toolStripButton
            // 
            this.dlpUpdate_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dlpUpdate_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("dlpUpdate_toolStripButton.Image")));
            this.dlpUpdate_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dlpUpdate_toolStripButton.Name = "dlpUpdate_toolStripButton";
            this.dlpUpdate_toolStripButton.Size = new System.Drawing.Size(52, 22);
            this.dlpUpdate_toolStripButton.Text = "dlp更新";
            this.dlpUpdate_toolStripButton.Click += new System.EventHandler(this.dlpUpdate_toolStripButton_Click);
            // 
            // main_Control
            // 
            this.main_Control.Controls.Add(this.MainPage);
            this.main_Control.Controls.Add(this.logPage);
            this.main_Control.Location = new System.Drawing.Point(0, 59);
            this.main_Control.Name = "main_Control";
            this.main_Control.SelectedIndex = 0;
            this.main_Control.Size = new System.Drawing.Size(641, 314);
            this.main_Control.TabIndex = 3;
            this.main_Control.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.main_Control_Selecting);
            // 
            // MainPage
            // 
            this.MainPage.Controls.Add(this.groupBox2);
            this.MainPage.Controls.Add(this.groupBox1);
            this.MainPage.Controls.Add(this.outputpathReset_button);
            this.MainPage.Controls.Add(this.outputpathsave_button);
            this.MainPage.Controls.Add(this.ext_groupBox);
            this.MainPage.Controls.Add(this.OutputFolder_textBox);
            this.MainPage.Controls.Add(this.OutputFolderSelect_button);
            this.MainPage.Controls.Add(this.ConvertRun_button);
            this.MainPage.Location = new System.Drawing.Point(4, 27);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(633, 283);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "変換";
            this.MainPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CookieUseBrowser_comboBox);
            this.groupBox2.Controls.Add(this.IsUseCookie_checkBox);
            this.groupBox2.Location = new System.Drawing.Point(277, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 91);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "クッキー";
            // 
            // CookieUseBrowser_comboBox
            // 
            this.CookieUseBrowser_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CookieUseBrowser_comboBox.FormattingEnabled = true;
            this.CookieUseBrowser_comboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CookieUseBrowser_comboBox.Items.AddRange(new object[] {
            "chrome",
            "chromium",
            "brave",
            "edge",
            "firefox",
            "opera",
            "safari",
            "vivaldi"});
            this.CookieUseBrowser_comboBox.Location = new System.Drawing.Point(134, 36);
            this.CookieUseBrowser_comboBox.Name = "CookieUseBrowser_comboBox";
            this.CookieUseBrowser_comboBox.Size = new System.Drawing.Size(116, 26);
            this.CookieUseBrowser_comboBox.TabIndex = 1;
            // 
            // IsUseCookie_checkBox
            // 
            this.IsUseCookie_checkBox.AutoSize = true;
            this.IsUseCookie_checkBox.Location = new System.Drawing.Point(17, 38);
            this.IsUseCookie_checkBox.Name = "IsUseCookie_checkBox";
            this.IsUseCookie_checkBox.Size = new System.Drawing.Size(111, 22);
            this.IsUseCookie_checkBox.TabIndex = 0;
            this.IsUseCookie_checkBox.Text = "クッキーを使う";
            this.IsUseCookie_checkBox.UseVisualStyleBackColor = true;
            this.IsUseCookie_checkBox.CheckedChanged += new System.EventHandler(this.IsUseCookie_checkBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IsLive_checkBox);
            this.groupBox1.Controls.Add(this.IsFormTheStartLivedown_checkBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "生放送";
            // 
            // IsLive_checkBox
            // 
            this.IsLive_checkBox.AutoSize = true;
            this.IsLive_checkBox.Location = new System.Drawing.Point(25, 39);
            this.IsLive_checkBox.Name = "IsLive_checkBox";
            this.IsLive_checkBox.Size = new System.Drawing.Size(171, 22);
            this.IsLive_checkBox.TabIndex = 1;
            this.IsLive_checkBox.Text = "生放送をダウンロードする";
            this.IsLive_checkBox.UseVisualStyleBackColor = true;
            this.IsLive_checkBox.CheckedChanged += new System.EventHandler(this.IsLive_checkBox_CheckedChanged);
            // 
            // IsFormTheStartLivedown_checkBox
            // 
            this.IsFormTheStartLivedown_checkBox.AutoSize = true;
            this.IsFormTheStartLivedown_checkBox.Location = new System.Drawing.Point(210, 39);
            this.IsFormTheStartLivedown_checkBox.Name = "IsFormTheStartLivedown_checkBox";
            this.IsFormTheStartLivedown_checkBox.Size = new System.Drawing.Size(315, 22);
            this.IsFormTheStartLivedown_checkBox.TabIndex = 0;
            this.IsFormTheStartLivedown_checkBox.Text = "ライブの初めからダウンロードする（配信中でも可）";
            this.IsFormTheStartLivedown_checkBox.UseVisualStyleBackColor = true;
            this.IsFormTheStartLivedown_checkBox.CheckedChanged += new System.EventHandler(this.IsFormTheStartLivedown_checkBox_CheckedChanged);
            // 
            // outputpathReset_button
            // 
            this.outputpathReset_button.Location = new System.Drawing.Point(376, 220);
            this.outputpathReset_button.Name = "outputpathReset_button";
            this.outputpathReset_button.Size = new System.Drawing.Size(75, 27);
            this.outputpathReset_button.TabIndex = 7;
            this.outputpathReset_button.Text = "リセット";
            this.outputpathReset_button.UseVisualStyleBackColor = true;
            this.outputpathReset_button.Click += new System.EventHandler(this.outputpathReset_button_Click);
            // 
            // outputpathsave_button
            // 
            this.outputpathsave_button.Location = new System.Drawing.Point(459, 220);
            this.outputpathsave_button.Name = "outputpathsave_button";
            this.outputpathsave_button.Size = new System.Drawing.Size(74, 27);
            this.outputpathsave_button.TabIndex = 6;
            this.outputpathsave_button.Text = "保存";
            this.outputpathsave_button.UseVisualStyleBackColor = true;
            this.outputpathsave_button.Click += new System.EventHandler(this.outputpathsave_button_Click);
            // 
            // ext_groupBox
            // 
            this.ext_groupBox.Controls.Add(this.wav_radioButton);
            this.ext_groupBox.Controls.Add(this.mp3_radioButton);
            this.ext_groupBox.Controls.Add(this.mp4_radioButton);
            this.ext_groupBox.Location = new System.Drawing.Point(8, 6);
            this.ext_groupBox.Name = "ext_groupBox";
            this.ext_groupBox.Size = new System.Drawing.Size(263, 91);
            this.ext_groupBox.TabIndex = 5;
            this.ext_groupBox.TabStop = false;
            this.ext_groupBox.Text = "拡張子";
            // 
            // wav_radioButton
            // 
            this.wav_radioButton.AutoSize = true;
            this.wav_radioButton.Location = new System.Drawing.Point(137, 37);
            this.wav_radioButton.Name = "wav_radioButton";
            this.wav_radioButton.Size = new System.Drawing.Size(54, 22);
            this.wav_radioButton.TabIndex = 5;
            this.wav_radioButton.TabStop = true;
            this.wav_radioButton.Text = "WAV";
            this.wav_radioButton.UseVisualStyleBackColor = true;
            // 
            // mp3_radioButton
            // 
            this.mp3_radioButton.AutoSize = true;
            this.mp3_radioButton.Checked = true;
            this.mp3_radioButton.Location = new System.Drawing.Point(25, 37);
            this.mp3_radioButton.Name = "mp3_radioButton";
            this.mp3_radioButton.Size = new System.Drawing.Size(50, 22);
            this.mp3_radioButton.TabIndex = 3;
            this.mp3_radioButton.TabStop = true;
            this.mp3_radioButton.Text = "MP3";
            this.mp3_radioButton.UseVisualStyleBackColor = true;
            // 
            // mp4_radioButton
            // 
            this.mp4_radioButton.AutoSize = true;
            this.mp4_radioButton.Location = new System.Drawing.Point(81, 37);
            this.mp4_radioButton.Name = "mp4_radioButton";
            this.mp4_radioButton.Size = new System.Drawing.Size(50, 22);
            this.mp4_radioButton.TabIndex = 4;
            this.mp4_radioButton.TabStop = true;
            this.mp4_radioButton.Text = "MP4";
            this.mp4_radioButton.UseVisualStyleBackColor = true;
            // 
            // OutputFolder_textBox
            // 
            this.OutputFolder_textBox.Location = new System.Drawing.Point(8, 253);
            this.OutputFolder_textBox.Name = "OutputFolder_textBox";
            this.OutputFolder_textBox.ReadOnly = true;
            this.OutputFolder_textBox.Size = new System.Drawing.Size(525, 25);
            this.OutputFolder_textBox.TabIndex = 2;
            this.OutputFolder_textBox.Text = "*出力フォルダを選択してください*";
            this.OutputFolder_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputFolderSelect_button
            // 
            this.OutputFolderSelect_button.Location = new System.Drawing.Point(8, 220);
            this.OutputFolderSelect_button.Name = "OutputFolderSelect_button";
            this.OutputFolderSelect_button.Size = new System.Drawing.Size(362, 27);
            this.OutputFolderSelect_button.TabIndex = 1;
            this.OutputFolderSelect_button.Text = "選択";
            this.OutputFolderSelect_button.UseVisualStyleBackColor = true;
            this.OutputFolderSelect_button.Click += new System.EventHandler(this.OutputFolderSelect_button_Click);
            // 
            // logPage
            // 
            this.logPage.Controls.Add(this.Log_richTextBox);
            this.logPage.Location = new System.Drawing.Point(4, 24);
            this.logPage.Name = "logPage";
            this.logPage.Padding = new System.Windows.Forms.Padding(3);
            this.logPage.Size = new System.Drawing.Size(633, 286);
            this.logPage.TabIndex = 1;
            this.logPage.Text = "Log";
            this.logPage.UseVisualStyleBackColor = true;
            // 
            // Log_richTextBox
            // 
            this.Log_richTextBox.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Log_richTextBox.Location = new System.Drawing.Point(2, 3);
            this.Log_richTextBox.Name = "Log_richTextBox";
            this.Log_richTextBox.ReadOnly = true;
            this.Log_richTextBox.Size = new System.Drawing.Size(631, 280);
            this.Log_richTextBox.TabIndex = 0;
            this.Log_richTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AcceptButton = this.ConvertRun_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 376);
            this.Controls.Add(this.main_Control);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Url_textBox);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ようつゔぇDowndlp";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.main_Control.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ext_groupBox.ResumeLayout(false);
            this.ext_groupBox.PerformLayout();
            this.logPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ConvertRun_button;
        private TextBox Url_textBox;
        private ToolStrip toolStrip1;
        private TabControl main_Control;
        private TabPage MainPage;
        private TabPage logPage;
        private TextBox OutputFolder_textBox;
        private Button OutputFolderSelect_button;
        private GroupBox ext_groupBox;
        private RadioButton wav_radioButton;
        private RadioButton mp3_radioButton;
        private RadioButton mp4_radioButton;
        private ToolStripButton dlpUpdate_toolStripButton;
        private RichTextBox Log_richTextBox;
        private Button outputpathsave_button;
        private Button outputpathReset_button;
        private GroupBox groupBox1;
        private CheckBox IsFormTheStartLivedown_checkBox;
        private CheckBox IsLive_checkBox;
        private GroupBox groupBox2;
        private CheckBox IsUseCookie_checkBox;
        private ComboBox CookieUseBrowser_comboBox;
    }
}