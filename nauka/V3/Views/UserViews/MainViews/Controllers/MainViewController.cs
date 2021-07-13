using nauka.V3.Models;
using nauka.V3.Views.AdministrationViews.AdminMainViews.Views;
using nauka.V3.Views.LoginRegisterViews.Views;
using nauka.V3.Views.MainViews.Model;
using nauka.V3.Views.MianViews;
using nauka.V3.Views.UserControllers;
using nauka.V3.Views.UserViews.UserControls;
using nauka.V3.Views.UserViews.VacationApplicationViews.Views;
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

        #region UC
        FirstViewUC firstViewUC = new FirstViewUC();
        SingleEmployeeUC singleEmployeeUC = new SingleEmployeeUC();
        VacationUC vacationUC = new VacationUC();
        DashboardUC dashboardUC = new DashboardUC();
        MenageVacationApplicationUC menageVacationApplicationUC = new MenageVacationApplicationUC();
        NoPermissionUC noPermission = new NoPermissionUC();

        #endregion

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
            InitTabControl();
            //_view.panelMain.Controls["firstViewUC"].BringToFront();


            _view.buttonExit.Click += (object sender, EventArgs e) =>
            {
                var result = MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Wyjście", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };

            _view.buttonLogout.Click += (object sender, EventArgs e) =>
            {
                var result = MessageBox.Show("Czy napewno chcesz się wylogować?", "Wylogowanie", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    LoginView login = new LoginView();
                    login.Show();
                    _view.Close();
                }
            };

            #region Left panel
            /*_view.userLeftPanelMenuuc1.buttonDashboard.Click += (object sender, EventArgs e) =>
            {
                DisplayDashBoard();
                _view.panelMain.Controls["DashboardUC"].BringToFront();
            };

            _view.userLeftPanelMenuuc1.buttonEmployee.Click += (object sender, EventArgs e) =>
            {
                DisplayEmployee();
                _view.panelMain.Controls["SingleEmployeeUC"].BringToFront();
            };

            _view.userLeftPanelMenuuc1.buttonVacations.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["VacationUC"].BringToFront();
                CreateDataGridVacations();
                DisplayVacations();
            };

            _view.userLeftPanelMenuuc1.buttonVacationApplications.Click += (object sender, EventArgs e) =>
            {
                CreateDataGridVacationApplication();
                DisplayVacationApplications();
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
                    if (view.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
                else
                {
                    _view.panelMain.Controls["NoPermissionUC"].BringToFront();
                }
            };*/
            #endregion

            #region MenageVacation

            menageVacationApplicationUC.buttonAdd.Click += (object sender, EventArgs e) =>
            {
                AddVacationApplication();
            };

            menageVacationApplicationUC.buttonDelete.Click += (object sender, EventArgs e) =>
            {
                DeleteVacationApplication();
            };

            #endregion
            await Task.CompletedTask;
        }

        private async Task InitViewModel()
        {
            
            if (_model == null)
            {
                _model = new MainViewModel();
            }
            else
                await Task.CompletedTask;
        }

        private void InitTabControl()
        {
            _view.tabControl1.TabPages.Clear();

            var tabPage = new TabPage();
            tabPage.Name = "Dashboard";
            tabPage.Text = "Tablica";
            tabPage.Controls.Add(dashboardUC);
            //tabPage.UseVisualStyleBackColor = true;
            _view.tabControl1.TabPages.Add(tabPage);

            tabPage = new TabPage();
            tabPage.Name = "Employee";
            tabPage.Text = "Dane pracownika";
            tabPage.Tag = "Employee";
            tabPage.Controls.Add(singleEmployeeUC);
            //tabPage.UseVisualStyleBackColor = true;
            _view.tabControl1.TabPages.Add(tabPage);

            tabPage = new TabPage();
            tabPage.Name = "Vacations";
            tabPage.Text = "Urlopy";
            tabPage.Controls.Add(vacationUC);
            //tabPage.Tag = "Vacations";
            //tabPage.UseVisualStyleBackColor = true;
            _view.tabControl1.TabPages.Add(tabPage);

            tabPage = new TabPage();
            tabPage.Name = "VacationApplications";
            tabPage.Text = "Wnioski o urlop";
            tabPage.Controls.Add(menageVacationApplicationUC);
            //tabPage.Tag = "VacationsApplications";
            //tabPage.UseVisualStyleBackColor = true;
            _view.tabControl1.TabPages.Add(tabPage);

            tabPage = new TabPage();
            tabPage.Name = "AdministrationPanel";
            tabPage.Text = "Panel Admnistratora";
            //if (!_model.Employee.EmployeePermisson || !_model.Employee.VacationPermisson)
                tabPage.Controls.Add(noPermission);
            //tabPage.Tag = "AdministrationPanel";
            //tabPage.UseVisualStyleBackColor = true;
            _view.tabControl1.TabPages.Add(tabPage);
        }

        private void InitAllUserControls()
        {
            firstViewUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(firstViewUC);

            dashboardUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(dashboardUC);

            singleEmployeeUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(singleEmployeeUC);

            vacationUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(vacationUC);

            menageVacationApplicationUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(menageVacationApplicationUC);

            noPermission.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(noPermission);
        }

        #region Dashboard

        private void DisplayDashBoard()
        {
            var vacations = _model.Employee.Vacation;
            foreach (var vacationDays in vacations)
            {
                if (vacationDays.Approve == true)
                {
                    var day = vacationDays.Start;
                    var end = vacationDays.End;
                    while (day < end)
                    {
                        //dashboardUC.monthViewVacations;

                        //this.calendar1.SelectedElementStart.Date" and "this.calendar1.SelectedElementEnd.Date;
                        day = day.AddDays(1.0);
                    }
                }
            }



        }

        #endregion

        #region Employee functions
        private void DisplayEmployee()
        {
            CheckEmployee();

            char m = 'M';
            char k = 'K';

            singleEmployeeUC.labelNameEmployee.Text = employee.Name;
            singleEmployeeUC.labelSurnameEmployee.Text = _model.Employee.Surname;
            singleEmployeeUC.labelUsernameEmployee.Text = _model.Employee.Username;
            if(_model.Employee.Sex.Equals(m))
                singleEmployeeUC.labelSexEmployee.Text = "mężczyzna";
            if (_model.Employee.Sex.Equals(k))
                singleEmployeeUC.labelSexEmployee.Text = "kobieta";
            else
                singleEmployeeUC.labelSexEmployee.Text = "nie podano";

            singleEmployeeUC.labelEmailEmployee.Text = _model.Employee.Email;
            singleEmployeeUC.labelSectionEmployee.Text = _model.Employee.Section.Name;
            singleEmployeeUC.labelFreeDays.Text = CountFreeDays().ToString();
        }

        private long CountFreeDays()
        {
            DateTime currentYear = DateTime.Now;
            var currentDaysFree = _model.Employee.AppSettings.Where(ap => ap.Year.ToString("yyyy") == currentYear.ToString("yyyy")).FirstOrDefault();
            byte thisYearDaysFree = currentDaysFree.AvaibleVacationDays;

            long usedDays = 0;
            foreach(var item in _model.Employee.VacationDays)
            {
                usedDays += item.VacationDays;
            }

            return thisYearDaysFree - usedDays;
        }

        #endregion

        #region Vacation functions

        private void DisplayVacations()
        {
            menageVacationApplicationUC.dataGridViewVacAppList.Rows.Clear();
            int i = 1;
            var vacationApplications = _model.Employee.Vacation;
            if (vacationApplications != null)
            {
                foreach (var item in vacationApplications)
                {
                    if (item.Approve == true)
                    {
                        vacationUC.dataGridViewVacations.Rows.Add(item.Id, i, item.Description,
                            item.Start.ToString("dd.MM.yyyy"), item.End.ToString("dd.MM.yyyy"));
                        i++;
                    }
                }
            }
            else
            {
                menageVacationApplicationUC.dataGridViewVacAppList.Rows.Add(i, "brak wniosków");
            }

        }

        private void CreateDataGridVacations()
        {

            var detailDGV = vacationUC.dataGridViewVacations;

            detailDGV.AllowUserToAddRows = false;
            detailDGV.AutoGenerateColumns = false;
            detailDGV.RowHeadersVisible = false;
            detailDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            detailDGV.Columns.Clear();
            detailDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var dgvTextColumn = default(DataGridViewColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "VacationID";
            dgvTextColumn.Name = "VacationId";
            dgvTextColumn.DataPropertyName = "VacationId";
            dgvTextColumn.Width = 50;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = false;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Lp.";
            dgvTextColumn.Name = "ID";
            dgvTextColumn.DataPropertyName = "Id";
            dgvTextColumn.Width = 50;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "powód";
            dgvTextColumn.Name = "Description";
            dgvTextColumn.DataPropertyName = "Description";
            dgvTextColumn.Width = 200;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "od";
            dgvTextColumn.Name = "StartVacation";
            dgvTextColumn.DataPropertyName = "Start";
            dgvTextColumn.Width = 140;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "do";
            dgvTextColumn.Name = "VacationEnd";
            dgvTextColumn.DataPropertyName = "End";
            dgvTextColumn.Width = 140;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);
        }

        #endregion

        #region MenageVacation

        private void CreateDataGridVacationApplication()
        {

            var detailDGV = menageVacationApplicationUC.dataGridViewVacAppList;

            detailDGV.AllowUserToAddRows = false;
            detailDGV.AutoGenerateColumns = false;
            detailDGV.RowHeadersVisible = false;
            detailDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            detailDGV.Columns.Clear();
            detailDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var dgvTextColumn = default(DataGridViewColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Lp.";
            dgvTextColumn.Name = "ID";
            dgvTextColumn.DataPropertyName = "Id";
            dgvTextColumn.Width = 50;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "powód";
            dgvTextColumn.Name = "Description";
            dgvTextColumn.DataPropertyName = "Description";
            dgvTextColumn.Width = 200;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "od";
            dgvTextColumn.Name = "StartVacation";
            dgvTextColumn.DataPropertyName = "Start";
            dgvTextColumn.Width = 140;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "do";
            dgvTextColumn.Name = "VacationEnd";
            dgvTextColumn.DataPropertyName = "End";
            dgvTextColumn.Width = 140;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);
        }

        private void AddVacationApplication()
        {
            var vacationApplcation = _model.Employee;
            var view = new VacationApplicationView();
            view.SetObjectToEdit = vacationApplcation;
            if (view.ShowDialog() == DialogResult.OK)
            {

            }
            DisplayVacationApplications();
        }

        private void DeleteVacationApplication()
        {
            var vacationStartToDelete = DateTime.Parse(menageVacationApplicationUC.dataGridViewVacAppList.SelectedCells[2].Value.ToString());
            var vacationEndToDelete = DateTime.Parse(menageVacationApplicationUC.dataGridViewVacAppList.SelectedCells[3].Value.ToString());
            var vacation = _model.Employee.Vacation.Where(v => (v.Start == vacationStartToDelete) && (v.End == vacationEndToDelete)).ToArray();
            _model.DeleteVacation(vacation[0]);
            DisplayVacationApplications();
        }

        private void DisplayVacationApplications()
        {
            menageVacationApplicationUC.dataGridViewVacAppList.Rows.Clear();
            int i = 1;
            var vacationApplications = _model.Employee.Vacation;
            if(vacationApplications != null)
            {
                foreach (var item in vacationApplications)
                {
                    if (item.Approve == false)
                    {
                        menageVacationApplicationUC.dataGridViewVacAppList.Rows.Add(i, item.Description, 
                            item.Start.ToString("dd.MM.yyyy"), item.End.ToString("dd.MM.yyyy"));
                        i++;
                    }
                }
            }else
            {
                menageVacationApplicationUC.dataGridViewVacAppList.Rows.Add(i, "brak wniosków");
            }
            
        }

        #endregion

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
