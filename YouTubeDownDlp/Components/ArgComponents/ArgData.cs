namespace YouTubeDownDlp.Components.ArgComponents
{
    public struct ArgData
    {
        private string url;
        private string outputPath;
        private bool isformStartLive;
        private bool isCookie;
        private string cookieBrowserName;
        private Mode mode;

        public string Url { get => url; set => url = value; }
        public string OutputPath { get => outputPath; set => outputPath = value; }
        public bool IsformStartLive { get => isformStartLive; set => isformStartLive = value; }
        public bool IsCookie { get => isCookie; set => isCookie = value; }
        public string CookieBrowserName { get => cookieBrowserName; set => cookieBrowserName = value; }
        public Mode Mode { get => mode; set => mode = value; }
    }
    public enum Mode
    {
        MP3,
        MP4,
        WAV
    }
}
