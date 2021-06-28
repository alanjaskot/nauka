using nauka.V3.Models;
using nauka.V3.Views.AdministrationViews.AdminMainViews.Views;
using nauka.V3.Views.MainViews.Model;
using nauka.V3.Views.MianViews;
using nauka.V3.Views.UserControllers;
using nauka.V3.Views.UserViews.UserControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V3.Views.MainViews.Controller
{
    class MainViewController
    {
        private readonly MainView _view;
        private MainViewModel _model;
        private Employee employee;
        

        SingleEmployeeUC singleEmployee = new SingleEmployeeUC();
        VacationUC vacation = new VacationUC();
        DashboardUC dashboard = new DashboardUC();
        MenageVacationApplicationUC menageVacationApplication = new MenageVacationApplicationUC();
        NoPermissionUC noPermission = new NoPermissionUC();

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
            InitAllUserControls();

            _view.buttonOK.Click += (object sender, EventArgs e) =>
            {
                var result = MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Wyjście", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
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
                DislpayEmployee();
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
                CheckEmployee();
                if (employee.EmployeePermisson || employee.VacationPermisson)
                {
                    var permittedEmployee = _model.Employee;
                    var view = new AdminMainView();
                    view.SetObjectToEdit = permittedEmployee;
                    _view.Hide();
                    if(view.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
                else
                {
                    _view.panelMain.Controls["NoPermissionUC"].BringToFront();
                }
            };

            await Task.CompletedTask;
        }

        private async Task InitViewModel()
        {
            dashboard.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(dashboard);

            if (_model == null)
            {
                _model = new MainViewModel();
            }
            else
                await Task.CompletedTask;
        }

        private void InitAllUserControls()
        {
            singleEmployee.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(singleEmployee);

            vacation.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(vacation);

            menageVacationApplication.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(menageVacationApplication);

            noPermission.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(noPermission);
        }

        private void DislpayEmployee()
        {
            CheckEmployee();

            singleEmployee.labelNameEmployee.Text = employee.Name;
            singleEmployee.labelSurnameEmployee.Text = _model.Employee.Surname;
            singleEmployee.labelUsernameEmployee.Text = _model.Employee.Username;
            if(_model.Employee.Sex == 'M')
                singleEmployee.labelSexEmployee.Text = "mężczyzna";
            if (_model.Employee.Sex == 'K')
                singleEmployee.labelSexEmployee.Text = "kobieta";
            else
                singleEmployee.labelSexEmployee.Text = "nie podano";

            singleEmployee.labelEmailEmployee.Text = _model.Employee.Email;
            singleEmployee.labelSectionEmployee.Text = _model.Employee.Section.Name;

        }

        private void CheckEmployee()
        {
            employee = _model.Employee;
        }

        public Employee SetEployee
        {
            get
            {
                return _model.Employee;
            }
            set
            {
                if (value == null)
                    return;

                _model.Employee = value;
            }
        }
    }
}
