using System.Diagnostics;
using YouTubeDownDlp.Forms;

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

        private async static Task SystemFileDownload()
        {
            Debug.WriteLine("ダウンロード開始");
            using HttpClient client = new();
            List<string> downlist = new()
            {
                "http://kosenyax.starfree.jp/YouTubeDownComponent/ffmpeg.exe",
                "http://kosenyax.starfree.jp/YouTubeDownComponent/ffprobe.exe",
                "https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp.exe"
            };

            foreach (var downurl in downlist)
            {
                using var response = await client.GetAsync(downurl);
                // レスポンスが成功した場合
                if (response.IsSuccessStatusCode)
                {
                    var fileName = Path.GetFileName(downurl);
                    // レスポンスの内容をストリームとして取得
                    using var stream = await response.Content.ReadAsStreamAsync();
                    // ストリームをファイルに書き込む
                    using var fileStream = File.Create(Path.Combine(systemfolder.ToString(), fileName));
                    await stream.CopyToAsync(fileStream);
                }
                else
                {
                    await client.DeleteAsync(downurl);
                }
            }
            Debug.WriteLine("ダウンロード完了");
        }

        public static void SystemFileCheck()
        {
            List<string> filePaths = new() { ffmpeg.ToString(), ffprobe.ToString(), ytdlp.ToString() };
            bool system_file_notfound = filePaths.Any(filePath => !File.Exists(filePath));

            if (!Directory.Exists(systemfolder.ToString()))
            {
                Directory.CreateDirectory(systemfolder.ToString());
            }

            if (system_file_notfound)
            {
                var ans = MessageBox.Show("システムファイルをダウンロードします。よろしいですか？", "YoutubeDownDlp", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (ans == DialogResult.No)
                {
                    MessageBox.Show("変換などの処理が実行できません。手動でファイルを配置するか、再起動してください。", "YoutubeDownDlp");
                    return;
                }
                var upform = new SystemFileDownNotice();
                upform.Show();
                Task.Run(SystemFileDownload).Wait();

                upform.Close();
                upform.Dispose();
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
