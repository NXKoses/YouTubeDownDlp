using System.Diagnostics;
using YouTubeDownDlp.Components.ArgComponents;

namespace YouTubeDownDlp.Components
{
    internal class Converts
    {
        private static string? Url { get; set; }
        private static string? Outputpath { get; set; }

        /// <summary>
        /// ダウンロードを実行します
        /// </summary>
        /// <param name="form">Invokeを使うためのForm</param>
        /// <param name="logtextbox">Logを出すRichTextBox</param>
        /// <param name="mode"></param>
        /// <param name="outputpath"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async Task RunConvertTask(Form form, RichTextBox logtextbox, ArgData argdata)
        {
            Debug.WriteLine("--RunConvert--");
            Url = argdata.Url;
            Outputpath = argdata.OutputPath;

            await Task.Run(() =>
            {
                using Process proc = new();
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.Arguments = @"/c " + GetArg.GetArgs(argdata);
                proc.StartInfo.WorkingDirectory = Global_Variable.AppPath + "/System/";
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
                if (!errorln.Equals("", StringComparison.Ordinal))
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
            });
            Debug.WriteLine("--Complete--");
        }

        public static void RunPopupConvert(ArgData argdata)
        {
            Debug.WriteLine("--RunPopupConvert--");
            Url = argdata.Url;
            Outputpath = argdata.OutputPath;

            using Process proc = new();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = @"/c " + GetArg.GetArgs(argdata);
            proc.StartInfo.WorkingDirectory = Global_Variable.AppPath + "/System/";
            proc.StartInfo.CreateNoWindow = false;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.RedirectStandardError = false;

            _ = proc.Start();

            proc.Close();
            proc.Dispose();

            Debug.WriteLine("--Complete--");
        }
    }
}
