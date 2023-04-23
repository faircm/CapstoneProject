using System;
using System.Windows.Forms;

namespace C969Assessment
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseConnection.openConnection();
            Application.Run(new LoginPage());
            DatabaseConnection.closeConnection();
        }
    }
}
