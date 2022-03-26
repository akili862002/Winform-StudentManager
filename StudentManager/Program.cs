namespace StudentManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            SQLHandler sql = new SQLHandler();
            // sql.connectSQL();

            ApplicationConfiguration.Initialize();

            Application.Run(new Dashboard());
            // Login loginForm = new Login();
            // if (loginForm.ShowDialog() == DialogResult.OK)
            // {
            //    Application.Run(new Dashboard());
            // }
            // Application.Run(new AddStudentForm());
            // using (var addStudentFrom = new AddStudentForm())
            // {
            //    addStudentFrom.ShowDialog();
            // }
        }
    }
}

