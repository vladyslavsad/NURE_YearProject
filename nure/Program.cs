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

        class MyApplicationContext : ApplicationContext ///фіксимо баг с закриттям аплікації
        {
            public MyApplicationContext(Form mainForm)
            {
                // Призначаємо обробник події закриття форми
                mainForm.FormClosed += Mainform_FormClosed;
                // Показуємо головну форму
                mainForm.Show();
            }

            private void Mainform_FormClosed(object sender, FormClosedEventArgs e)
            {
                // Якщо всі вікна закриті, вихід з програми
                if (Application.OpenForms.Count == 0)
                {
                    ExitThread();
                }
                else
                {
                    // Можна встановити нову головну форму
                    Application.OpenForms[0].FormClosed += Mainform_FormClosed;
                }
            }
        }

    }
}