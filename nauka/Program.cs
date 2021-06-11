using nauka.V2;
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
                    view = new V2.Views.MainView.Views.MainViewView();
                    break;
                default:
                    view = new Form1();
                    break;
            }

            Application.Run(view);
        }
    }
}
