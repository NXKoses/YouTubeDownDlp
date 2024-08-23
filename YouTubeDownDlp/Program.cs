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
            // ���̃A�v���̎��s�t�H���_���擾���ݒ肵�Ă���
            Global_Variable.AppPath = Components.Components.GetAppPath();
            // �K�v�ȃt�@�C�������邩�m�F����Ȃ�������_�E�����[�h����
            Components.Components.SystemFileCheck();

            //��d�N�����`�F�b�N����
            if (System.Diagnostics.Process.GetProcessesByName(
                System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                //���łɋN�����Ă���Ɣ��f���ďI��
                MessageBox.Show("���d�N���͂ł��܂���B");
                return;
            }


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}