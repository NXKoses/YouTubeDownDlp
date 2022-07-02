using System.Diagnostics;

namespace YouTubeDownDlp.Components
{
    internal class Converts
    {
        public static string? Url { get; private set; }
        public static string? Outputpath { get; private set; }

        public static async Task RunConvertTask(Form form, RichTextBox logtextbox, Mode mode, string outputpath, string url)
        {
            Debug.WriteLine("--RunConvert--");
            Url = url;
            Outputpath = outputpath;

            await Task.Run(() =>
            {
                using (Process proc = new())
                {
                    proc.StartInfo.FileName = "cmd.exe";
                    proc.StartInfo.Arguments = @GetArg(mode);
                    proc.StartInfo.WorkingDirectory = MainForm.AppPath + "/System/";
                    proc.StartInfo.CreateNoWindow = true;
                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.StartInfo.RedirectStandardError = true;

                    proc.Start();

                    //ログ
                    for (; ; )
                    {
                        string line = proc.StandardOutput.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        //Invokeメソッドを使用
                        if (form.InvokeRequired)
                        {
                            form.Invoke(new Action(() =>
                            {
                                logtextbox.AppendText(line + "\r\n");
                            }));
                        }
                        else
                        {
                            logtextbox.AppendText(line + "\r\n");
                        }

                        Debug.WriteLine(line + " :log");
                    }

                    //エラーログ
                    string errorln = proc.StandardError.ReadToEnd();
                    if (!errorln.Equals(""))
                    {
                        if (form.InvokeRequired)
                        {
                            form.Invoke(new Action(() =>
                            {
                                logtextbox.SelectionColor = Color.Red;
                                logtextbox.AppendText(errorln + "\r\n");
                                logtextbox.SelectionColor = Color.Black;
                            }));
                        }
                        else
                        {
                            logtextbox.SelectionColor = Color.Red;
                            logtextbox.AppendText(errorln + "\r\n");
                            logtextbox.SelectionColor = Color.Black;
                        }
                    }

                    proc.Close();
                    proc.Dispose();
                }
            });
            Debug.WriteLine("--Complete--");
        }

        /// <summary>
        /// Modeにおおじて必要な引数を取得します
        /// </summary>
        /// <param name="mode"></param>
        /// <returns>コマンド(Arg)</returns>
        private static string GetArg(Mode mode)
        {
            switch (mode)
            {
                case Mode.MP4:
                    return "/c yt-dlp -f bestvideo[ext=mp4]+bestaudio[ext=m4a]/best[ext=mp4]/best " + " --yes-playlist " + Url + " -P " + Outputpath;

                case Mode.MP3:
                    return "/c yt-dlp -x --audio-format mp3 --yes-playlist " + Url + " -P " + Outputpath;

                case Mode.WAV:
                    return "/c yt-dlp -x --audio-format wav --yes-playlist " + Url + " -P " + Outputpath;

                default:
                    return "/c yt-dlp -x --audio-format mp3 --yes-playlist " + Url + " -P " + Outputpath;
            }
        }

        public enum Mode
        {
            MP3,
            MP4,
            WAV
        }
    }

}
