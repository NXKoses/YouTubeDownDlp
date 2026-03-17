using YouTubeDownDlp.Setting;

namespace YouTubeDownDlp.Components
{
    public class ArgManager
    {
        public string Url { get; set; }
        public string OutputPath { get; set; }
        public string CookieBrowserName { get; set; }

        public Mode Mode { get; set; }

        private AppSetting appSetting;

        public ArgManager(AppSetting appSetting) { this.appSetting = appSetting; }

        public string GetArg()
        {
            string result = "ECHO 【エラー】コマンドの生成に失敗しました。";

            try
            {
                var originalArg = GetModeArg();

                // プレースホルダを実際の値に置き換える
                result = originalArg?.Replace("{Url}", Url)
                            .Replace("{OutputPath}", OutputPath);

                // Cookie
                if(string.IsNullOrEmpty(CookieBrowserName))
                {
                    result = result.Replace("{Cookie}", string.Empty);
                }
                else
                {
                    result = result.Replace("{Cookie}", $"--cookies-from-browser {CookieBrowserName}");
                }
            }
            catch
            {
                ErrorMessage();
            }

            return result;
        }

        private string GetModeArg()
        {
            return Mode switch
            {
                Mode.MP3 => appSetting.MP3,
                Mode.WAV => appSetting.WAV,
                Mode.MP4 => appSetting.MP4,
                _ => "ECHO 【エラー】コマンドの生成に失敗しました。",
            };
        }
        private static void ErrorMessage()
        {
            MessageBox.Show("コマンドの生成に失敗しました。設定を確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public enum Mode
    {
        MP3,
        WAV,
        MP4
    }
}
