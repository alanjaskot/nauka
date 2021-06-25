using nauka.V3.Views.AdministrationViews.AdminMainViews.Views;
using nauka.V3.Views.AdministrationViews.Models;
using nauka.V3.Views.AdministrationViews.UsereControls;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V3.Views.AdministrationViews.AdminMainViews.Controller
{
    class AdminMainViewController
    {
        private readonly AdminMainView _view;
        private AdminMainViewModel _model;

        public AdminMainViewController(AdminMainView adminMainView)
        {
            _view = adminMainView;

            Task.Run(async () =>
            {
                await InitViewModel();
                await InitView();
            }).Wait();
        }

        public async Task InitView()
        {
            #region
            EmployeesUC employees = new EmployeesUC();
            employees.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(employees);

            PermissionUC permission = new PermissionUC();
            permission.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(permission);

            MenageVacationsUC menageVacations = new MenageVacationsUC();
            menageVacations.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(menageVacations);

            VacationPermissionUC vacationPermission = new VacationPermissionUC();
            vacationPermission.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(vacationPermission);
                        
            #endregion

            _view.adminLeftPanelMenuuc1.buttonSection.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["MenageSectionUC"].BringToFront();
            };

            _view.adminLeftPanelMenuuc1.buttonEmployees.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["EmployeesUC"].BringToFront();
                
            };

            _view.adminLeftPanelMenuuc1.buttonPermission.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["PermissionUC"].BringToFront();
            };

            _view.adminLeftPanelMenuuc1.buttonVacations.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["MenageVacationsUC"].BringToFront();
            };

            _view.adminLeftPanelMenuuc1.buttonVacationApplications.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["VacationPermissionUC"].BringToFront();
            };

            _view.buttonOK.Click += (object sender, EventArgs e) => 
            {
                var result = MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Wyjście", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };

            await Task.CompletedTask;
        }

        public async Task InitViewModel()
        {
            MenageSectionUC menageSection = new MenageSectionUC();      
            menageSection.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(menageSection);

            if (_model == null)
            {
                _model = new AdminMainViewModel();
            }
            else
                await Task.CompletedTask;
        }
    }
}
