using System;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Threading.Tasks;
using YouTubeDownDlp.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace YouTubeDownDlp.Components
{
    internal class Components
    {
        static DirectoryInfo systemfolder = new DirectoryInfo(@Global_Variable.AppPath + @"/System/");
        static DirectoryInfo ffmpeg = new DirectoryInfo(@Global_Variable.AppPath + @"/System/ffmpeg.exe");
        static DirectoryInfo ffprobe = new DirectoryInfo(@Global_Variable.AppPath + @"/System/ffprobe.exe");
        static DirectoryInfo ytdlp = new DirectoryInfo(@Global_Variable.AppPath + @"/System/yt-dlp.exe");
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
                "http://kosenyax.starfree.jp/YouTubeDownComponent/yt-dlp.exe"
            };

            foreach (var downurl in downlist)
            {
                using var response = await client.GetAsync(downurl);
                // レスポンスが成功した場合
                if (response.IsSuccessStatusCode)
                {
                    var fileName = System.IO.Path.GetFileName(downurl);
                    // レスポンスの内容をストリームとして取得
                    using var stream = await response.Content.ReadAsStreamAsync();

                    // ストリームをファイルに書き込む
                    using var fileStream = File.Create(systemfolder + fileName);
                    await stream.CopyToAsync(fileStream);
                    fileStream.Dispose();
                }
                else
                {
                    await client.DeleteAsync(downurl);
                }
            }
        }

        public static async void SystemFileCheckAsync()
        {
            List<string> filePaths = new() { ffmpeg.ToString(), ffprobe.ToString(), ytdlp.ToString() };
            bool isdown = false;

            if (!Directory.Exists(systemfolder.ToString())) systemfolder.Create();
            foreach (string filePath in filePaths)
            {
                if (!File.Exists(filePath))
                {
                    isdown = true;
                }
            }

            if (isdown)
            {
                var upform = new SystemFileDownNotice();
                upform.Show();
                Task tas = Task.Run(SystemFileDownload);
                tas.Wait();
                upform.Close();
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
