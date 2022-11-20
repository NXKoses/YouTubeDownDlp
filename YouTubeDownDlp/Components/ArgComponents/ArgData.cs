namespace YouTubeDownDlp.Components.ArgComponents
{
    public struct ArgData
    {
        public string Url;
        public string OutputPath;
        public bool IsformStartLive;
        public bool IsCookie;
        public string CookieBrowserName;
        public Mode mode;
    }
    public enum Mode
    {
        MP3,
        MP4,
        WAV
    }
}
