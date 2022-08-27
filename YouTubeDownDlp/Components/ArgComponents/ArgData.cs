namespace YouTubeDownDlp.Components.ArgComponents
{
    internal class ArgData
    {
        public string Url;
        public string OutputPath;
        public bool IsformStartLive;
        public bool IsCookie;
        public string CookieBrowserName;
        public Mode mode;
        public enum Mode
        {
            MP3,
            MP4,
            WAV
        }
    }
}
