using nauka.V2;
using nauka.V2.Services;
using nauka.V3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var showView = MessageBox.Show("Czy nowy widok?", "Info", MessageBoxButtons.YesNo);

            var view = default(Form);
                         
            switch(showView)
            {
                case DialogResult.Yes:
                    
                    ServiceManager.Init();
                    view = new V3.Views.LoginRegisterViews.Views.LoginView();
                    break;
                default:
                    view = new Form1();
                    break;
            }

            Application.Run(view);
        }
    }
}
