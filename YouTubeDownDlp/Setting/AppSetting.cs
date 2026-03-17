using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeDownDlp.Setting
{
    public class AppSetting
    {
        public string OutputFolderPath { get; set; } = string.Empty;
        public string MP3 { get; set; } = "yt-dlp -x --audio-format mp3 -f bestaudio --audio-quality 3 --yes-playlist {Url} -P {OutputPath} {Cookie}";
        public string WAV { get; set; } = "yt-dlp -x --audio-format wav -f bestaudio --audio-quality 3 --yes-playlist {Url} -P {OutputPath} {Cookie}";
        public string MP4 { get; set; } = "yt-dlp -f bestvideo[ext=mp4]+bestaudio[ext=m4a]/best[ext=mp4]/best --yes-playlist {Url} -P {OutputPath} {Cookie}";

    }
}
