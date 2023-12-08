using YouTubeDownDlp.Components;
using YouTubeDownDlp.Components.ArgComponents;

namespace YouTubeDownDlp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Global_Variable.AppPath = Components.Components.GetAppPath();
            Components.Components.SystemFileCheck();

            InitializeComponent();


            Url_textBox.Select();
            Log_richTextBox.HideSelection = false;
            IsFormTheStartLivedown_checkBox.Visible = false;
            CookieUseBrowser_comboBox.Visible = false;
            CookieUseBrowser_comboBox.SelectedIndex = 0;

            this.Text += " 1.0.0.5";

            //もし出力先が保存されてたらそれを代入する
            if (Properties.Settings.Default.OutputFolderPath.Length != 0)
            {
                Global_Variable.Outputfolderpath = Properties.Settings.Default.OutputFolderPath;
                OutputFolder_textBox.Text = Global_Variable.Outputfolderpath;
            }
        }

        /// <summary>
        /// 変換実行ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ConvertRun_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Global_Variable.Outputfolderpath))
            {
                MessageBox.Show("フォルダを選択してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(Url_textBox.Text))
            {
                MessageBox.Show("URLを入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //コマンドを生成するためのデータをまとめる　それを実行時に受け渡す
            ArgData argdata = new()
            {
                CookieBrowserName = CookieUseBrowser_comboBox.Text,
                IsCookie = IsUseCookie_checkBox.Checked,
                IsformStartLive = IsFormTheStartLivedown_checkBox.Checked,
                Mode = GetMode(),
                OutputPath = Global_Variable.Outputfolderpath,
                Url = Url_textBox.Text
            };

            //生放送ダウンロード実行時
            if (IsLive_checkBox.Checked)
            {
                DialogResult isok = MessageBox.Show("生放送ダウンロード機能が有効です。録画を停止する際はコマンドプロンプトを選択した状態で<Ctrl + C>で終了できます。" +
                    "本当に実行しますか？", "質問", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (isok == DialogResult.No)
                {
                    return;
                }

                Converts.RunPopupConvert(argdata);

                Url_textBox.Text = "";
                return;
            }

            Log_richTextBox.Text = "";
            main_Control.SelectedTab = logPage;
            Global_Variable.IsConverting = true;

            //変換実行
            await Converts.RunConvertTask(this, Log_richTextBox, argdata);

            Global_Variable.IsConverting = false;
            Url_textBox.Text = "";
            MessageBox.Show("処理が終了しました", "お知らせぇ！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            main_Control.SelectedTab = MainPage;
        }

        private Mode GetMode()
        {
            if (mp3_radioButton.Checked)
            {
                return Mode.MP3;
            }

            if (mp4_radioButton.Checked)
            {
                return Mode.MP4;
            }

            return wav_radioButton.Checked ? Mode.WAV : Mode.MP3;
        }

        private void OutputFolderSelect_button_Click(object sender, EventArgs e)
        {
            string path = FolderBrowserComponents.FolderSelect();
            if (path.Equals("none", StringComparison.Ordinal))
            {
                return;
            }

            Global_Variable.Outputfolderpath = path;
            OutputFolder_textBox.Text = path;
        }

        private void Main_Control_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (Global_Variable.IsConverting)
            {
                e.Cancel = true;
            }
        }

        private void DlpUpdate_toolStripButton_Click(object sender, EventArgs e)
        {
            if (!Global_Variable.IsConverting)
            {
                UpdateForm updateform = new()
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = this.Location
                };
                updateform.ShowDialog(this);
                updateform.Dispose();
                return;
            }
            MessageBox.Show("変換中は実行できません。", "お知らせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Outputpathsave_button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OutputFolderPath = Global_Variable.Outputfolderpath;
            Properties.Settings.Default.Save();
            MessageBox.Show("保存しました", "お知らせぇ！", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OutputpathReset_button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            MessageBox.Show("リセットしました。次回起動時から適用されます", "お知らせぇ！", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void IsFormTheStartLivedown_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsLive_checkBox.Checked)
            {
                IsFormTheStartLivedown_checkBox.Checked = false;
            }
        }

        /// <summary>
        /// 生放送をダウンロードするにチェックが入っていないと"初めからダウンロード"を表示しないようにする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsLive_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsLive_checkBox.Checked)
            {
                IsFormTheStartLivedown_checkBox.Visible = true;
            }
            else
            {
                IsFormTheStartLivedown_checkBox.Visible = false;
                IsFormTheStartLivedown_checkBox.Checked = false;
            }
        }

        /// <summary>
        /// クッキーを使うにチェックが入っていないとコンボボックスを表示しないようにする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsUseCookie_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsUseCookie_checkBox.Checked)
            {
                CookieUseBrowser_comboBox.Visible = true;
            }
            else
            {
                CookieUseBrowser_comboBox.SelectedIndex = 0;
                CookieUseBrowser_comboBox.Visible = false;
            }
        }
    }
}