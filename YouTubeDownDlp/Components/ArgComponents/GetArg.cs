namespace YouTubeDownDlp.Components.ArgComponents
{
    internal class GetArg
    {
        /// <summary>
        /// ArgDataから必要なコマンドを返します
        /// </summary>
        /// <returns>コマンド(Arg)</returns>
        public static string GetArgs(ArgData argdata)
        {
            string Cookiebrowsername = argdata.CookieBrowserName;
            string outputpath = argdata.OutputPath;
            string url = argdata.Url;

            string live = argdata.IsformStartLive ? "--live-from-start" : "";
            string cookie = argdata.IsCookie ? $"--cookies-from-browser {Cookiebrowsername}" : "";

            return argdata.Mode switch
            {
                Mode.MP4 => $"yt-dlp -f bestvideo[ext=mp4]+bestaudio[ext=m4a]/best[ext=mp4]/best --yes-playlist {url} -P {outputpath} {live} {cookie}",
                Mode.MP3 => $"yt-dlp -x --audio-format mp3 -f bestaudio --audio-quality 3 --yes-playlist {url} -P {outputpath} {live} {cookie}",
                Mode.WAV => $"yt-dlp -x --audio-format wav -f bestaudio --audio-quality 3 --yes-playlist {url} -P {outputpath} {live} {cookie}",
                _ => $"yt-dlp -x --audio-format mp3 -f bestaudio --yes-playlist {url} -P {outputpath} {live} {cookie}",
            };
        }

    }

}
