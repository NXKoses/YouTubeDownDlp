namespace YouTubeDownDlp
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // このアプリの実行フォルダを取得し設定しておく
            Global_Variable.AppPath = Components.Components.GetAppPath();
            // 必要なファイルがあるか確認するなかったらダウンロードする
            Components.Components.SystemFileCheck();

            //二重起動をチェックする
            if (System.Diagnostics.Process.GetProcessesByName(
                System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                //すでに起動していると判断して終了
                MessageBox.Show("多重起動はできません。");
                return;
            }


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}