using System.Diagnostics;

namespace YouTubeDownDlp.Components
{
    internal class Components
    {
        static readonly DirectoryInfo systemfolder = new(@Global_Variable.AppPath + @"/System/");
        static readonly DirectoryInfo ffmpeg = new(@Global_Variable.AppPath + @"/System/ffmpeg.exe");
        static readonly DirectoryInfo ffprobe = new(@Global_Variable.AppPath + @"/System/ffprobe.exe");
        static readonly DirectoryInfo ytdlp = new(@Global_Variable.AppPath + @"/System/yt-dlp.exe");

        public static string GetAppPath()
        {
            return Application.StartupPath;
        }

        public static void SystemFileCheck()
        {
            List<string> filePaths = [ffmpeg.ToString(), ffprobe.ToString(), ytdlp.ToString()];
            bool system_file_notfound = filePaths.Any(filePath => !File.Exists(filePath));

            if (!Directory.Exists(systemfolder.ToString()))
            {
                Directory.CreateDirectory(systemfolder.ToString());
            }

            if (system_file_notfound)
            {
                MessageBox.Show("ダウンロードに必要な実行ファイルが見つかりませんでした。Systemフォルダに指定のファイルを設置してください。");
                return;
            }

            var filesToDelete = Directory.EnumerateFiles(systemfolder.ToString())
                .Where(x => !(Path.GetFileName(x) is "ffmpeg.exe" or "ffprobe.exe" or "yt-dlp.exe"));

            foreach (var fileToDelete in filesToDelete)
            {
                try
                {
                    File.Delete(fileToDelete);
                    Debug.WriteLine("削除: " + fileToDelete);
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"ファイル {fileToDelete} を削除できませんでした。: {e.Message}");
                }
            }
        }

    }
}
