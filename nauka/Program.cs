
using nauka.V3;
using nauka.V3.Services;
using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka
{
    static class Program
    {

        private static NLog.ILogger _logger;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitNlog();

            _logger.Debug("Test debug");
            _logger.Info("Test info");
            _logger.Warn("Test Warn");

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var showView = MessageBox.Show("Czy nowy widok?", "Info", MessageBoxButtons.YesNo);

            var view = default(Form);
                         
            switch(showView)
            {
                case DialogResult.Yes:
                    
                    ManageService.Init();
                    view = new V3.Views.LoginRegisterViews.Views.LoginView();
                    break;
                default:
                    view = new Form1();
                    break;
            }

            Application.Run(view);
        }

        [Obsolete]
        private static void InitNlog()
        {
            Console.WriteLine("Init nlog ...");

            var _pathToExe = AppDomain.CurrentDomain.BaseDirectory;

            var pathToNlogConfig = Path.Combine(_pathToExe, "NLog.Config");
            Console.WriteLine($"Path to NLOG: {pathToNlogConfig}");

            var nlogConfig = new XmlLoggingConfiguration(pathToNlogConfig, true);

            var dbTarget = (DatabaseTarget)nlogConfig.FindTargetByName("database");

            dbTarget.DBProvider = $@"Microsoft.Data.Sqlite.SqliteConnection, Microsoft.Data.Sqlite";
            dbTarget.ConnectionString = $@"Server=AppDomain.CurrentDomain.BaseDirectory\AppForVacations.db;Database=master;Trusted_Connection=True;";

            LogManager.Configuration = nlogConfig;

            _logger = LogManager.GetCurrentClassLogger();
            _logger.Info("Nlog config work");

            Console.WriteLine("Init nlog DONE");
        }
    }
}
