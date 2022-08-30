namespace YouTubeDownDlp.Components.ArgComponents
{
    internal class GetArg
    {
        /// <summary>
        /// Argdataから必要なコマンドを返します
        /// </summary>
        /// <returns>コマンド(Arg)</returns>
        public static string GetArgs(ArgData argdata)
        {
            string live = null;
            string cookie = null;

            string Cookiebrowsername = argdata.CookieBrowserName;
            string outputpath = argdata.OutputPath;
            string url = argdata.Url;

            if (argdata.IsformStartLive)
            {
                live = "--live-from-start";
            }

            if (argdata.IsCookie)
            {
                cookie = $"--cookies-from-browser {Cookiebrowsername}";
            }

            return argdata.mode switch
            {
                ArgData.Mode.MP4 => $"yt-dlp -N 6 -f bestvideo[ext=mp4]+bestaudio[ext=m4a]/best[ext=mp4]/best --yes-playlist {live} {cookie} {url} -P {outputpath}",
                ArgData.Mode.MP3 => $"yt-dlp -N 6 -x --audio-format mp3 --yes-playlist {live} {cookie} {url} -P {outputpath}",
                ArgData.Mode.WAV => $"yt-dlp -N 6 -x --audio-format wav --yes-playlist {live} {cookie} {url} -P {outputpath}",
                _ => $"yt-dlp -N 6 -x --audio-format mp3 --yes-playlist {live} {cookie} {url} -P {outputpath}",
            };
        }

    }

}
