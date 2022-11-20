using System.Diagnostics;

namespace YouTubeDownDlp.Components
{
    internal class Components
    {
        public static string GetAppPath()
        {
            return Application.StartupPath;
        }

        public static void SystemFileCheck()
        {
            if (!File.Exists(Global_Variable.AppPath + "/System" + "/yt-dlp.exe"))
            {
                MessageBox.Show("yt-dlp.exe が見つかりませんでした", "おい！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            //無駄なファイル削除
            try
            {
                foreach (var path in Directory.EnumerateFiles(Global_Variable.AppPath + "/System/")
                    .Where(x => !(Path.GetFileName(x) == "ffmpeg.exe" || Path.GetFileName(x) == "ffprobe.exe" || Path.GetFileName(x) == "yt-dlp.exe")))
                {
                    File.Delete(path);
                    Debug.WriteLine("削除: " + path);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}
