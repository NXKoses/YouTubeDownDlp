using Microsoft.WindowsAPICodePack.Dialogs;


namespace YouTubeDownDlp.Components
{
    internal static class FolderBrowserComponents
    {
        public static string FolderSelect()
        {
            // ダイアログのインスタンスを生成
            using CommonOpenFileDialog dialog = new("フォルダーの選択")
            {
                // 選択形式をフォルダースタイルに
                IsFolderPicker = true,
            };

            // ダイアログを表示
            return dialog.ShowDialog() == CommonFileDialogResult.Ok ? dialog.FileName : "none";
        }
    }
}
