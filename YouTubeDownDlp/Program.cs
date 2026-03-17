using System.Reflection;
using Velopack;

namespace YouTubeDownDlp
{
    internal static class Program
    {
        public static object AppVersion { get; internal set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            VelopackApp.Build().Run();

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

            // アプリケーションのバージョン情報を取得
            var assembly = Assembly.GetExecutingAssembly().GetName();
            var version = assembly.Version;
            AppVersion = version.ToString(3);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}