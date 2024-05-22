namespace nure
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MyApplicationContext context = new MyApplicationContext(new loginForm());
            Application.Run(context);
        }

        class MyApplicationContext : ApplicationContext ///������� ��� � ��������� ��������
        {
            public MyApplicationContext(Form mainForm)
            {
                // ���������� �������� ��䳿 �������� �����
                mainForm.FormClosed += Mainform_FormClosed;
                // �������� ������� �����
                mainForm.Show();
            }

            private void Mainform_FormClosed(object sender, FormClosedEventArgs e)
            {
                // ���� �� ���� ������, ����� � ��������
                if (Application.OpenForms.Count == 0)
                {
                    ExitThread();
                }
                else
                {
                    // ����� ���������� ���� ������� �����
                    Application.OpenForms[0].FormClosed += Mainform_FormClosed;
                }
            }
        }

    }
}