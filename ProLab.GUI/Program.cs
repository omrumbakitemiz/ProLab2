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
            //Application.Run(new TamirKaydıEkle());
            //Application.Run(new AracArama());
            Application.Run(new SecimSayfasi());
        }
    }
}
