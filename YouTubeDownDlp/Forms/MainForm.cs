namespace YouTubeDownDlp
{
    public partial class MainForm : Form
    {
        private static string? Outputfolderpath;
        private static string? url;

        private static bool IsConverting = false;
        public static string? AppPath;

        public MainForm()
        {
            InitializeComponent();
            Url_textBox.Select();
            Log_richTextBox.HideSelection = false;
            AppPath = Components.Components.GetAppPath();

            //もし出力先が保存されてたらそれを代入する
            if (Properties.Settings.Default.OutputFolderPath.Length != 0)
            {
                Outputfolderpath = Properties.Settings.Default.OutputFolderPath;
                OutputFolder_textBox.Text = Outputfolderpath;
            }
        }

        /// <summary>
        /// 変換実行ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ConvertRun_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Outputfolderpath))
            {
                MessageBox.Show("フォルダを選択してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(Url_textBox.Text))
            {
                MessageBox.Show("URLを入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Log_richTextBox.Text = "";
            url = Url_textBox.Text;
            main_Control.SelectedTab = logPage;
            IsConverting = true;

            //待機
            await Components.Converts.RunConvertTask(this, Log_richTextBox, GetMode(), Outputfolderpath, url);

            IsConverting = false;
            Url_textBox.Text = "";
            MessageBox.Show("処理が終了しました", "お知らせぇ！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            main_Control.SelectedTab = MainPage;
        }

        private Components.Converts.Mode GetMode()
        {
            if (mp3_radioButton.Checked)
            {
                return Components.Converts.Mode.MP3;
            }

            if (mp4_radioButton.Checked)
            {
                return Components.Converts.Mode.MP4;
            }

            if (wav_radioButton.Checked)
            {
                return Components.Converts.Mode.WAV;
            }

            return Components.Converts.Mode.MP3;
        }

        private void OutputFolderSelect_button_Click(object sender, EventArgs e)
        {
            string path = Components.FolderBrowserComponents.FolderSelect();
            if (path.Equals("none"))
            {
                return;
            }
            Outputfolderpath = path;
            OutputFolder_textBox.Text = path;
            path = null;
        }

        private void main_Control_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (IsConverting)
            {
                e.Cancel = true;
            }
        }

        private void dlpUpdate_toolStripButton_Click(object sender, EventArgs e)
        {
            using var updateform = new UpdateForm();
            updateform.ShowDialog();
            updateform.Dispose();
        }

        private void outputpathsave_button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OutputFolderPath = Outputfolderpath;
            Properties.Settings.Default.Save();
            MessageBox.Show("保存しました", "お知らせぇ！", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void outputpathReset_button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            MessageBox.Show("リセットしました。次回起動時から適用されます", "お知らせぇ！", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}