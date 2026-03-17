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
            ConvertRun_button = new Button();
            Url_textBox = new TextBox();
            toolStrip1 = new ToolStrip();
            dlpUpdate_toolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            openFolderExecute_toolStripButton = new ToolStripButton();
            main_Control = new TabControl();
            MainPage = new TabPage();
            groupBox2 = new GroupBox();
            CookieUseBrowser_comboBox = new ComboBox();
            IsUseCookie_checkBox = new CheckBox();
            outputpathReset_button = new Button();
            outputpathsave_button = new Button();
            ext_groupBox = new GroupBox();
            wav_radioButton = new RadioButton();
            mp3_radioButton = new RadioButton();
            mp4_radioButton = new RadioButton();
            OutputFolder_textBox = new TextBox();
            OutputFolderSelect_button = new Button();
            logPage = new TabPage();
            Log_richTextBox = new RichTextBox();
            toolStrip1.SuspendLayout();
            main_Control.SuspendLayout();
            MainPage.SuspendLayout();
            groupBox2.SuspendLayout();
            ext_groupBox.SuspendLayout();
            logPage.SuspendLayout();
            SuspendLayout();
            // 
            // ConvertRun_button
            // 
            ConvertRun_button.Location = new Point(539, 6);
            ConvertRun_button.Name = "ConvertRun_button";
            ConvertRun_button.Size = new Size(86, 155);
            ConvertRun_button.TabIndex = 0;
            ConvertRun_button.Text = "変換開始";
            ConvertRun_button.UseVisualStyleBackColor = true;
            ConvertRun_button.Click += ConvertRun_button_Click;
            // 
            // Url_textBox
            // 
            Url_textBox.Location = new Point(12, 28);
            Url_textBox.Name = "Url_textBox";
            Url_textBox.Size = new Size(617, 25);
            Url_textBox.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(28, 28);
            toolStrip1.Items.AddRange(new ToolStripItem[] { dlpUpdate_toolStripButton, toolStripSeparator1, openFolderExecute_toolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(644, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // dlpUpdate_toolStripButton
            // 
            dlpUpdate_toolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            dlpUpdate_toolStripButton.Name = "dlpUpdate_toolStripButton";
            dlpUpdate_toolStripButton.Size = new Size(52, 22);
            dlpUpdate_toolStripButton.Text = "dlp更新";
            dlpUpdate_toolStripButton.Click += DlpUpdate_toolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // openFolderExecute_toolStripButton
            // 
            openFolderExecute_toolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            openFolderExecute_toolStripButton.Image = (Image)resources.GetObject("openFolderExecute_toolStripButton.Image");
            openFolderExecute_toolStripButton.ImageTransparentColor = Color.Magenta;
            openFolderExecute_toolStripButton.Name = "openFolderExecute_toolStripButton";
            openFolderExecute_toolStripButton.Size = new Size(98, 22);
            openFolderExecute_toolStripButton.Text = "実行フォルダを開く";
            openFolderExecute_toolStripButton.Click += OpenFolderExecute_toolStripButton_Click;
            // 
            // main_Control
            // 
            main_Control.Controls.Add(MainPage);
            main_Control.Controls.Add(logPage);
            main_Control.Location = new Point(0, 59);
            main_Control.Name = "main_Control";
            main_Control.SelectedIndex = 0;
            main_Control.Size = new Size(644, 199);
            main_Control.TabIndex = 3;
            main_Control.Selecting += Main_Control_Selecting;
            // 
            // MainPage
            // 
            MainPage.Controls.Add(groupBox2);
            MainPage.Controls.Add(outputpathReset_button);
            MainPage.Controls.Add(outputpathsave_button);
            MainPage.Controls.Add(ext_groupBox);
            MainPage.Controls.Add(OutputFolder_textBox);
            MainPage.Controls.Add(OutputFolderSelect_button);
            MainPage.Controls.Add(ConvertRun_button);
            MainPage.Location = new Point(4, 27);
            MainPage.Name = "MainPage";
            MainPage.Padding = new Padding(3);
            MainPage.Size = new Size(636, 168);
            MainPage.TabIndex = 0;
            MainPage.Text = "変換";
            MainPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CookieUseBrowser_comboBox);
            groupBox2.Controls.Add(IsUseCookie_checkBox);
            groupBox2.Location = new Point(277, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(256, 91);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "クッキー";
            // 
            // CookieUseBrowser_comboBox
            // 
            CookieUseBrowser_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CookieUseBrowser_comboBox.FormattingEnabled = true;
            CookieUseBrowser_comboBox.ImeMode = ImeMode.Off;
            CookieUseBrowser_comboBox.Items.AddRange(new object[] { "chrome", "chromium", "brave", "edge", "firefox", "opera", "safari", "vivaldi" });
            CookieUseBrowser_comboBox.Location = new Point(134, 36);
            CookieUseBrowser_comboBox.Name = "CookieUseBrowser_comboBox";
            CookieUseBrowser_comboBox.Size = new Size(116, 26);
            CookieUseBrowser_comboBox.TabIndex = 1;
            // 
            // IsUseCookie_checkBox
            // 
            IsUseCookie_checkBox.AutoSize = true;
            IsUseCookie_checkBox.Location = new Point(17, 38);
            IsUseCookie_checkBox.Name = "IsUseCookie_checkBox";
            IsUseCookie_checkBox.Size = new Size(111, 22);
            IsUseCookie_checkBox.TabIndex = 0;
            IsUseCookie_checkBox.Text = "クッキーを使う";
            IsUseCookie_checkBox.UseVisualStyleBackColor = true;
            IsUseCookie_checkBox.CheckedChanged += IsUseCookie_checkBox_CheckedChanged;
            // 
            // outputpathReset_button
            // 
            outputpathReset_button.Location = new Point(371, 103);
            outputpathReset_button.Name = "outputpathReset_button";
            outputpathReset_button.Size = new Size(75, 27);
            outputpathReset_button.TabIndex = 7;
            outputpathReset_button.Text = "リセット";
            outputpathReset_button.UseVisualStyleBackColor = true;
            outputpathReset_button.Click += OutputpathReset_button_Click;
            // 
            // outputpathsave_button
            // 
            outputpathsave_button.Location = new Point(454, 103);
            outputpathsave_button.Name = "outputpathsave_button";
            outputpathsave_button.Size = new Size(74, 27);
            outputpathsave_button.TabIndex = 6;
            outputpathsave_button.Text = "保存";
            outputpathsave_button.UseVisualStyleBackColor = true;
            outputpathsave_button.Click += Outputpathsave_button_Click;
            // 
            // ext_groupBox
            // 
            ext_groupBox.Controls.Add(wav_radioButton);
            ext_groupBox.Controls.Add(mp3_radioButton);
            ext_groupBox.Controls.Add(mp4_radioButton);
            ext_groupBox.Location = new Point(8, 6);
            ext_groupBox.Name = "ext_groupBox";
            ext_groupBox.Size = new Size(263, 91);
            ext_groupBox.TabIndex = 5;
            ext_groupBox.TabStop = false;
            ext_groupBox.Text = "拡張子";
            // 
            // wav_radioButton
            // 
            wav_radioButton.AutoSize = true;
            wav_radioButton.Location = new Point(137, 37);
            wav_radioButton.Name = "wav_radioButton";
            wav_radioButton.Size = new Size(54, 22);
            wav_radioButton.TabIndex = 5;
            wav_radioButton.TabStop = true;
            wav_radioButton.Text = "WAV";
            wav_radioButton.UseVisualStyleBackColor = true;
            // 
            // mp3_radioButton
            // 
            mp3_radioButton.AutoSize = true;
            mp3_radioButton.Checked = true;
            mp3_radioButton.Location = new Point(25, 37);
            mp3_radioButton.Name = "mp3_radioButton";
            mp3_radioButton.Size = new Size(50, 22);
            mp3_radioButton.TabIndex = 3;
            mp3_radioButton.TabStop = true;
            mp3_radioButton.Text = "MP3";
            mp3_radioButton.UseVisualStyleBackColor = true;
            // 
            // mp4_radioButton
            // 
            mp4_radioButton.AutoSize = true;
            mp4_radioButton.Location = new Point(81, 37);
            mp4_radioButton.Name = "mp4_radioButton";
            mp4_radioButton.Size = new Size(50, 22);
            mp4_radioButton.TabIndex = 4;
            mp4_radioButton.TabStop = true;
            mp4_radioButton.Text = "MP4";
            mp4_radioButton.UseVisualStyleBackColor = true;
            // 
            // OutputFolder_textBox
            // 
            OutputFolder_textBox.Location = new Point(3, 136);
            OutputFolder_textBox.Name = "OutputFolder_textBox";
            OutputFolder_textBox.ReadOnly = true;
            OutputFolder_textBox.Size = new Size(525, 25);
            OutputFolder_textBox.TabIndex = 2;
            OutputFolder_textBox.Text = "*出力フォルダを選択してください*";
            OutputFolder_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // OutputFolderSelect_button
            // 
            OutputFolderSelect_button.Location = new Point(3, 103);
            OutputFolderSelect_button.Name = "OutputFolderSelect_button";
            OutputFolderSelect_button.Size = new Size(362, 27);
            OutputFolderSelect_button.TabIndex = 1;
            OutputFolderSelect_button.Text = "選択";
            OutputFolderSelect_button.UseVisualStyleBackColor = true;
            OutputFolderSelect_button.Click += OutputFolderSelect_button_Click;
            // 
            // logPage
            // 
            logPage.Controls.Add(Log_richTextBox);
            logPage.Location = new Point(4, 24);
            logPage.Name = "logPage";
            logPage.Padding = new Padding(3);
            logPage.Size = new Size(636, 171);
            logPage.TabIndex = 1;
            logPage.Text = "Log";
            logPage.UseVisualStyleBackColor = true;
            // 
            // Log_richTextBox
            // 
            Log_richTextBox.Font = new Font("メイリオ", 8.25F);
            Log_richTextBox.Location = new Point(2, 3);
            Log_richTextBox.Name = "Log_richTextBox";
            Log_richTextBox.ReadOnly = true;
            Log_richTextBox.Size = new Size(631, 280);
            Log_richTextBox.TabIndex = 0;
            Log_richTextBox.Text = "";
            // 
            // MainForm
            // 
            AcceptButton = ConvertRun_button;
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 261);
            Controls.Add(main_Control);
            Controls.Add(toolStrip1);
            Controls.Add(Url_textBox);
            Font = new Font("メイリオ", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "ようつゔぇDowndlp";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            main_Control.ResumeLayout(false);
            MainPage.ResumeLayout(false);
            MainPage.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ext_groupBox.ResumeLayout(false);
            ext_groupBox.PerformLayout();
            logPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

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
        private GroupBox groupBox2;
        private CheckBox IsUseCookie_checkBox;
        private ComboBox CookieUseBrowser_comboBox;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton openFolderExecute_toolStripButton;
    }
}