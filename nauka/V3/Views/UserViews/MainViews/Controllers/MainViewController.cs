using nauka.V3.Models;
using nauka.V3.Views.AdministrationViews.AdminMainViews.Views;
using nauka.V3.Views.LoginRegisterViews.Views;
using nauka.V3.Views.MainViews.Model;
using nauka.V3.Views.MianViews;
using nauka.V3.Views.UserViews.UserControls;
using nauka.V3.Views.UserViews.VacationApplicationViews.Views;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V3.Views.MainViews.Controller
{
    public class MainViewController
    {
        private readonly MainView _view;
        private MainViewModel _model;

        public MainViewController(MainView view)
        {
            _view = view;

            Task.Run(async () =>
            {
                await InitViewModel();
                await InitView();
            }).Wait();

        }

        private async Task InitView()
        {
            await InitGridView();

            #region VacationApplication buttons

            _view.tabControlMainView.Click += (object sender, EventArgs e) =>
            {
                CloseFirstView();
                ShowEmployee();
                DisplayVacations();
            };

            _view.buttonAddVacApp.Click += (object sender, EventArgs e) =>
            {
                AddVacationApplication();
            };

            _view.buttonDeleteVacApp.Click += (object sender, EventArgs e) =>
            {
                DeleteVacationApplication();
            };

            #endregion

            _view.buttonOk.Click += (object sender, EventArgs e) =>
            {
                if (ValidatePermisson())
                {
                    var permittedEmployee = _model.Employee;
                    var view = new AdminMainView();
                    view.SetObjectToEdit = permittedEmployee;
                    view.Show();
                    _view.Close();
                }
            };

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

        private async Task InitGridView()
        {
            CreateDataGridVacations();
            CreateDataGridVacationApplication();

            await Task.CompletedTask;
        }

        #region FirstView
        private async Task ShowFirstView()
        {
            FirstViewUC firstViewUC = new FirstViewUC();
            firstViewUC.Dock = DockStyle.Fill;
            _view.tabPageDashboard.Controls.Add(firstViewUC);
            _view.tabPageDashboard.Controls["firstViewUC"].BringToFront();

            await Task.CompletedTask;
        }

        private void CloseFirstView()
        {
            /*DashboardUC dashboardUC = new DashboardUC();
            dashboardUC.Dock = DockStyle.Fill;
            _view.tabPageDashboard.Controls.Add(dashboardUC);
            _view.tabPageAdminPanel.Controls["dashboardUC"].BringToFront();*/
        }
        #endregion

        #region Employee functions
        private void ShowEmployee()
        {
            if(_model.Employee != null)
            {
                char m = 'M';
                char k = 'K';

                _view.labelNameEmployee.Text = _model.Employee.Name;
                _view.labelSurnameEmployee.Text = _model.Employee.Surname;
                _view.labelUsernameEmployee.Text = _model.Employee.Username;
                if (_model.Employee.Sex == m)
                    _view.labelSexEmployee.Text = "mężczyzna";
                if (_model.Employee.Sex == k)
                    _view.labelSexEmployee.Text = "kobieta";
                else
                    _view.labelSexEmployee.Text = "nie podano";

                _view.labelEmailEmployee.Text = _model.Employee.Email;
                _view.labelSectionEmployee.Text = _model.Employee.Section.Name;
                _view.labelFreeDays.Text = CountCurrentFreeDays().ToString();
                _view.labelLastYearFreeDays.Text = CountLastYearFreeDays().ToString();
            }

        }

        private byte CountLastYearFreeDays()
        {
            byte result = 0;
            DateTime lastYear = DateTime.Now;
            lastYear.AddYears(-1);
            byte daysToUse = _model.Employee.AppSettings.AvaibleVacationDays;
            byte usedDays = 0;
            var employeeVacations = _model.GetVacation_Employees().Result.Where(voe => voe.EmployeeId == _model.Employee.Id);
            var employeeVacationDates = _model.GetVacations().Result.Where(v => v.Start.ToString("yyyy") == lastYear.ToString("yyyy"));
            if(daysToUse > 0)
            {
                foreach (var itemVacation in employeeVacations)
                {
                    foreach (var item in employeeVacationDates)
                    {
                        if(item.Id == itemVacation.VacationId)
                        {
                            foreach (var it in _model.GetVacationDays().Result)
                            {
                                if (itemVacation.VacationId == item.Id)
                                {
                                    usedDays += (byte)it.Days;
                                }
                            }
                        }  
                    }   
                }
                result = (byte)(daysToUse - usedDays);
            }
            

            return result;
            
        }

        private byte CountCurrentFreeDays()
        {
            byte result = 0;
            string currentYear = DateTime.Now.ToString("yyyy");
            byte daysToUse = _model.Employee.AppSettings.AvaibleVacationDays;
            byte usedDays = 0;
            var employeeVacations = _model.GetVacation_Employees().Result.Where(voe => voe.EmployeeId == _model.Employee.Id);
            var employeeVacationDates = _model.GetVacations().Result.Where(v => v.Start.ToString("yyyy") == currentYear);
            if (daysToUse > 0)
            {
                foreach (var itemVacation in employeeVacations)
                {
                    foreach (var item in employeeVacationDates)
                    {
                        if (item.Id == itemVacation.VacationId)
                        {
                            foreach (var it in _model.GetVacationDays().Result)
                            {
                                if (itemVacation.VacationId == item.Id)
                                {
                                    usedDays += (byte)it.Days;
                                }
                            }
                        }
                    }
                }
                result = (byte)(daysToUse - usedDays);
            }
            return result;
        }

        #endregion

        #region Vacation functions

        private async Task DisplayVacations()
        {
            var employeeVacation = _model.GetVacation_Employees().Result.Where(voe => voe.EmployeeId == _model.Employee.Id);
             _view.dataGridViewVacations.Rows.Clear();
             int i = 1;
             if (_model.GetVacations().Result != null)
             {
                 foreach (var item in _model.GetVacations().Result)
                 {
                     foreach(var it in employeeVacation)
                     if(item.Id == it.VacationId)
                     {
                          if (item.Approve == true)
                          {
                                 _view.dataGridViewVacations.Rows.Add(item.Id, i, item.Description,
                                 item.Start.ToString("dd.MM.yyyy"), item.End.ToString("dd.MM.yyyy"));
                                 i++;
                          }
                     }
                 }
             }
             else
             {
                 _view.dataGridViewVacations.Rows.Add(i, "brak planowanych urlopów");
             }
            await Task.CompletedTask;
        }

        private void CreateDataGridVacations()
        {
            var detailDGV = _view.dataGridViewVacations;

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
            var detailDGV = _view.dataGridViewVacAppList;

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

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Id";
            dgvTextColumn.Name = "Id";
            dgvTextColumn.DataPropertyName = "Id";
            dgvTextColumn.Width = 140;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = false;
            detailDGV.Columns.Add(dgvTextColumn);
        }

        private void AddVacationApplication()
        {
            var vacationApplcation = new Vacation();
            var view = new VacationApplicationView();
            view.SetObjectToEdit = vacationApplcation;
            view.SetEmployee = _model.Employee;
            if (view.ShowDialog() == DialogResult.OK)
            {

            }
            DisplayVacationApplications();
        }

        private async Task DeleteVacationApplication()
        {
            Guid vacationID = Guid.Parse(_view.dataGridViewVacAppList.SelectedCells[4].Value.ToString());
            var vacation_employee = _model.GetVacation_Employees().Result
                .Where(voe => voe.EmployeeId == _model.Employee.Id && voe.VacationId == vacationID).FirstOrDefault();         
            var vacation = _model.GetVacations().Result.Where(v => v.Id == vacationID).FirstOrDefault();
            var employee = _model.Employee;
            employee.Vacation_Employees.Remove(vacation_employee);

            await _model.DeleteVacation(vacation);
            await _model.UpdateEmployee(_model.Employee.Id, employee);
            await _model.DeleteVacation_Employee(vacation_employee);

            DisplayVacationApplications();
        }

        private void DisplayVacationApplications()
        {
            _view.dataGridViewVacAppList.Rows.Clear();
            int i = 1;
            if(_model.GetVacations().Result != null)
            {
                foreach (var itemEmp in _model.GetVacation_Employees().Result)
                {
                    foreach (var item in _model.GetVacations().Result)
                    {
                        if (itemEmp.VacationId == item.Id && item.Approve == false)
                        {
                            _view.dataGridViewVacAppList.Rows.Add(i, item.Description,
                                item.Start.ToString("dd.MM.yyyy"), item.End.ToString("dd.MM.yyyy"), item.Id);
                            i++;
                        }
                        else
                        {
                            _view.dataGridViewVacAppList.Rows.Add(i, "brak wniosków");
                        }
                    }
                }
                
            }
            else
            {
                _view.dataGridViewVacAppList.Rows.Add(i, "brak wniosków");
            }
            
        }

        #endregion

        #region AdminPanel
        private bool ValidatePermisson()
        {
            var result = false;

            if (_model.Employee.Password.Equals(_view.textBoxPassowrd.Text))
            {
                if(_model.Employee.EmployeePermisson || _model.Employee.VacationPermisson)
                {
                    result = true;
                }
                else
                {
                    MessageBox.Show("Brak uprawnień");
                }
            }
            else
            {
                MessageBox.Show("hasło nieprawidłowe");
            }

            return result;
        }
        #endregion

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
