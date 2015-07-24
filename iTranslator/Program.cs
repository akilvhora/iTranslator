using System;
using System.Windows.Forms;

using LightInject;
using TranslatorLib;

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

            ITranslate translator;
            using (ServiceContainer container = new ServiceContainer())
            {
                translator = container.GetInstance<ITranslate>();
            }

            Application.Run(new FrmMain(translator));
        }
    }
}
