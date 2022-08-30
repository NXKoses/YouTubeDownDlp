namespace YouTubeDownDlp
{
    /// <summary>
    /// システム全体で使うグローバル変数
    /// </summary>
    internal static class Global_Variable
    {
        /// <summary>
        /// アプリケーションのフォルダパス
        /// </summary> 
        public static string? AppPath { get; set; }

        /// <summary>
        /// 出力先フォルダパス
        /// </summary>
        public static string? Outputfolderpath { get; set; }

        /// <summary>
        /// 変換中かどうかのフラグ
        /// </summary>
        public static bool IsConverting { get; set; }
    }
}