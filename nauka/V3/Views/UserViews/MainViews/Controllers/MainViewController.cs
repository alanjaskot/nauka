using nauka.V3.Views.AdministrationViews.AdminMainViews.Views;
using nauka.V3.Views.MainViews.Model;
using nauka.V3.Views.MianViews;
using nauka.V3.Views.UserControllers;
using nauka.V3.Views.UserViews.UserControls;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V3.Views.MainViews.Controller
{
    class MainViewController
    {
        private readonly MainView _view;
        private MainViewModel _model;

        public MainViewController(MainView mainView)
        {
            _view = mainView;

            Task.Run(async () =>
            {
                await InitViewModel();
                await InitView();
            }).Wait();
        }

        private async Task InitView()
        {
            #region
            SingleEmployeeUC singleEmployee = new SingleEmployeeUC();
            singleEmployee.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(singleEmployee);

            VacationUC vacation = new VacationUC();
            vacation.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(vacation);

            MenageVacationApplicationUC menageVacationApplication = new MenageVacationApplicationUC();
            menageVacationApplication.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(menageVacationApplication);

            NoPermissionUC noPermission = new NoPermissionUC();
            noPermission.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(noPermission);
            bool tempPermission = false;

            #endregion

            _view.buttonOK.Click += (object sender, EventArgs e) =>
            {
                var result = MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Wyjście", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };

            _view.userLeftPanelMenuuc1.buttonDashboard.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["DashboardUC"].BringToFront();
             };

            _view.userLeftPanelMenuuc1.buttonEmployee.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["SingleEmployeeUC"].BringToFront();
            };

            _view.userLeftPanelMenuuc1.buttonVacations.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["VacationUC"].BringToFront();
            };

            _view.userLeftPanelMenuuc1.buttonVacationApplications.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["MenageVacationApplicationUC"].BringToFront();
            };

            _view.userLeftPanelMenuuc1.buttonAdministration.Click += (object sender, EventArgs e) =>
            {
                if (!tempPermission)
                {
                    _view.panelMain.Controls["NoPermissionUC"].BringToFront();
                    tempPermission = true;
                }
                else
                {
                    AdminMainView adminMainView = new AdminMainView();
                    _view.Close();
                    adminMainView.Show();
                }
            };

            await Task.CompletedTask;
        }

        private async Task InitViewModel()
        {
            DashboardUC dashboard = new DashboardUC();
            dashboard.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(dashboard);

            if (_model == null)
            {
                _model = new MainViewModel();
            }
            else
                await Task.CompletedTask;
        }
    }
}
