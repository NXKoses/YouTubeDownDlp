using System.Diagnostics;
using YouTubeDownDlp.Forms;

namespace YouTubeDownDlp
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
            ControlBox = false;
            close_button.Enabled = false;

            StartUpdate();
        }

        public async void StartUpdate()
        {
            await UpdateTask();
            _ = MessageBox.Show("更新処理が終了しました ログをご確認ください", "お知らせぇ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            close_button.Enabled = true;
        }

        public async Task UpdateTask()
        {
            Debug.WriteLine("--UpdateTask--");
            await Task.Run(() =>
            {
                using Process proc = new();
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.Arguments = @"/c yt-dlp -U";
                proc.StartInfo.WorkingDirectory = MainFormHelpers.AppPath + "/System/";
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                _ = proc.Start();

                //ログ
                for (; ; )
                {
                    string line = proc.StandardOutput.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    //Invokeメソッドを使用
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() =>
                        {
                            updatelog_richTextBox.AppendText(line + "\r\n");
                        }));
                    }
                    else
                    {
                        updatelog_richTextBox.AppendText(line + "\r\n");
                    }

                    Debug.WriteLine(line + " :log");
                }

                //エラーログ
                string errorln = proc.StandardError.ReadToEnd();
                if (!errorln.Equals("", StringComparison.Ordinal))
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() =>
                        {
                            updatelog_richTextBox.SelectionColor = Color.Red;
                            updatelog_richTextBox.AppendText(errorln + "\r\n");
                            updatelog_richTextBox.SelectionColor = Color.Black;
                        }));
                    }
                    else
                    {
                        updatelog_richTextBox.SelectionColor = Color.Red;
                        updatelog_richTextBox.AppendText(errorln + "\r\n");
                        updatelog_richTextBox.SelectionColor = Color.Black;
                    }
                }

                proc.Close();
                proc.Dispose();
            });
            Debug.WriteLine("--Complete--");
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
