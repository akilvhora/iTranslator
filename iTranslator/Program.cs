using System;
using System.Windows.Forms;

namespace iTranslator
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
            RegisterDependency.Register();
            Application.Run(new FrmMain());
        }
    }
}
