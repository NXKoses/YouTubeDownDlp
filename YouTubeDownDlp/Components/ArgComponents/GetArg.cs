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

            string live = argdata.IsformStartLive ? "--live-from-start" : null;
            string cookie = argdata.IsCookie ? $"--cookies-from-browser {Cookiebrowsername}" : null;

            return argdata.mode switch
            {
                Mode.MP4 => $"yt-dlp -N 6 -f bestvideo[ext=mp4]+bestaudio[ext=m4a]/best[ext=mp4]/best --yes-playlist {url} -P {outputpath} {live} {cookie}",
                Mode.MP3 => $"yt-dlp -N 6 -x --audio-format mp3 --yes-playlist {url} -P {outputpath} {live} {cookie}",
                Mode.WAV => $"yt-dlp -N 6 -x --audio-format wav --yes-playlist {url} -P {outputpath} {live} {cookie}",
                _ => $"yt-dlp -N 6 -x --audio-format mp3 --yes-playlist {url} -P {outputpath} {live} {cookie}",
            };
        }

    }

}
