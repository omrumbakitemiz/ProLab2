using System;
using System.Windows.Forms;

namespace ProLab.GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AddRepairingRecord("41AZ2314","BMW","X5"));
            Application.Run(new LoginPage());
        }
    }
}
