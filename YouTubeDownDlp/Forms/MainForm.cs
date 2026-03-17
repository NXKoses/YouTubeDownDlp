using PictureReSize;
using System.Diagnostics;
using YouTubeDownDlp.Components;
using YouTubeDownDlp.Setting;

namespace YouTubeDownDlp
{
    public partial class MainForm : Form
    {
        private readonly string settingFilePath = Global_Variable.AppPath + @"\Setting.json";
        private readonly AppSetting appSetting;

        public MainForm()
        {
            InitializeComponent();

            Url_textBox.Select();
            Log_richTextBox.HideSelection = false;
            CookieUseBrowser_comboBox.Visible = false;
            CookieUseBrowser_comboBox.SelectedIndex = 0;

            this.Text += $"{Program.AppVersion}";

            appSetting = Serializer.Load<AppSetting>(settingFilePath);

            //もし出力先が保存されてたらそれを代入する
            if (!string.IsNullOrEmpty(appSetting.OutputFolderPath))
            {
                Global_Variable.Outputfolderpath = appSetting.OutputFolderPath;
                OutputFolder_textBox.Text = appSetting.OutputFolderPath;
            }
        }

        private async void MainForm_LoadAsync(object sender, EventArgs e)
        {
            // 更新を確認する
            await UpdateProcess.CheckForUpdateAsync(this);
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
            ArgManager argdata = new(appSetting)
            {
                Mode = GetMode(),
                Url = Url_textBox.Text,
                OutputPath = Global_Variable.Outputfolderpath,
                CookieBrowserName = IsUseCookie_checkBox.Checked ? CookieUseBrowser_comboBox.Text : string.Empty,
            };

            Log_richTextBox.Text = "";
            main_Control.SelectedTab = logPage;
            Global_Variable.IsConverting = true;

            //変換実行
            await Converts.RunConvertTask(this, Log_richTextBox, argdata);

            Global_Variable.IsConverting = false;
            Url_textBox.Text = "";
            MessageBox.Show("実行が終了しました", "お知らせぇ！", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            using var ofd = new OpenFileDialog()
            {
                FileName = "Folder Selection",
                Filter = "Folder|.",
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Global_Variable.Outputfolderpath = Path.GetDirectoryName(ofd.FileName);
                OutputFolder_textBox.Text = Path.GetDirectoryName(ofd.FileName);
            }
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
            appSetting.OutputFolderPath = Global_Variable.Outputfolderpath;
            Serializer.Save(appSetting, settingFilePath);
            MessageBox.Show("保存しました", "お知らせぇ！", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OutputpathReset_button_Click(object sender, EventArgs e)
        {
            appSetting.OutputFolderPath = string.Empty;
            Serializer.Save(appSetting, settingFilePath);
            MessageBox.Show("リセットしました。次回起動時から適用されます", "お知らせぇ！", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void OpenFolderExecute_toolStripButton_Click(object sender, EventArgs e)
        {
            Process.Start("EXPLORER.EXE", Global_Variable.AppPath);
        }


    }
}