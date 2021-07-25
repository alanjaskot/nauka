using nauka.V3.Models;
using nauka.V3.Views.AdministrationViews.AdminMainViews.Views;
using nauka.V3.Views.LoginRegisterViews.Views;
using nauka.V3.Views.MainViews.Model;
using nauka.V3.Views.MianViews;
using nauka.V3.Views.UserViews.UserControls;
using nauka.V3.Views.UserViews.VacationApplicationViews.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V3.Views.MainViews.Controller
{
    public class MainViewController
    {
        private readonly MainView _view;
        private MainViewModel _model;

        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

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
            InitGridView();

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

            _view.Load += (object sender, EventArgs e) =>
            {
                Task.Run(async () => await InitList());
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

        private async Task InitList()
        {
            await DisplayVacationApplications();
            await DisplayVacations();

            await Task.CompletedTask;
        }

        private void InitGridView()
        {
            CreateDataGridVacations();
            CreateDataGridVacationApplication();
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

                if (_model.Employee != null)
                {
                    char m = 'M';
                    char k = 'K';

                    _view.labelNameEmployee.Text = _model.Employee.Name;
                    _view.labelSurnameEmployee.Text = _model.Employee.Surname;
                    _view.labelUsernameEmployee.Text = _model.Employee.Username;
                    _view.labelEmailEmployee.Text = _model.Employee.Email;
                    if (_model.Employee.Sex == m)
                        _view.labelSexEmployee.Text = "mężczyzna";
                    if (_model.Employee.Sex == k)
                        _view.labelSexEmployee.Text = "kobieta";
                    else
                        _view.labelSexEmployee.Text = "nie podano";
                    
                    var section = _model.GetSections().Result.Where(s => s.Id == _model.Employee.SectionId).FirstOrDefault();
                    _view.labelSectionEmployee.Text = section.Name;

                    byte currentYearFreeDays = CalculateCurrentFreeDays();
                    _view.labelFreeDays.Text = currentYearFreeDays.ToString();                   
                    byte lastYearFreeDays = CalculateLastYearFreeDays();
                    _view.labelLastYearFreeDays.Text = lastYearFreeDays.ToString();
                }
        }

        private byte CalculateLastYearFreeDays()
        {
            byte result = 0;
            var lastYear = DateTime.Now;
            lastYear = lastYear.AddYears(-1);

            byte usedDays = CountUsedDays(lastYear);
            byte daysToUse = CountLastYearFreeDays();

            if (daysToUse > 0)
            {
                result = (byte)(daysToUse - usedDays);
            }

            return result;
        }

        private byte CalculateCurrentFreeDays()
        {
            byte result = 0;

            byte usedDays = CountUsedDays(DateTime.Now);
            byte daysToUse = CountCurrentFreeDays();
            
                if (daysToUse > 0)
                {
                    result = (byte)(daysToUse - usedDays);
                }

            return result;
        }

        private byte CountCurrentFreeDays()
        {
            int yearsOfExperience = _model.Employee.GetYearsOfExpirence();
            DateTime currentYear = DateTime.Now;
            DateTime dateOfHire = _model.Employee.DateOfHire;
            DateTime lastYear = DateTime.Now.AddYears(-1);
            DateTime twoYearsAgo = DateTime.Now.AddYears(-2);
            DateTime tenYearsAgo = DateTime.Now.AddYears(-10);

            byte result = 0;
            
            if (yearsOfExperience >= 10)
                result = 26;

            if ((yearsOfExperience > 2) && (yearsOfExperience < 10))
                result = 20;

            if (dateOfHire.Year == currentYear.Year)
            {
                double freeDays = 0;
                while(dateOfHire < DateTime.Now)
                {
                    if(yearsOfExperience >= 10)
                        freeDays += 2.16;
                    if (yearsOfExperience < 10)
                        freeDays += 1.66;
                    dateOfHire = dateOfHire.AddMonths(1);
                }
                result = (byte)Math.Ceiling(freeDays);
            }

            return result;
        }

        private byte CountLastYearFreeDays()
        {
            byte result = 0;
            int yearsOfExperience = _model.Employee.GetYearsOfExpirence();
            DateTime dateOfHire = _model.Employee.DateOfHire;
            DateTime lastYear = DateTime.Now.AddYears(-1);
            
            if ((yearsOfExperience >= 10) && (dateOfHire.Year < lastYear.Year))
                result = 26;

            if ((yearsOfExperience >= 2) && (yearsOfExperience < 10) && (dateOfHire.Year < lastYear.Year))
                result = 20;

            if ((dateOfHire.Year == lastYear.Year) && (yearsOfExperience < 2))
            {
                double freeDays = 0;
                DateTime endOfYear = new DateTime(lastYear.Year, 12, 31);
                while (dateOfHire < DateTime.Now)
                {
                    freeDays += 1.66;
                    dateOfHire = dateOfHire.AddMonths(1);
                }
                result = (byte)Math.Ceiling(freeDays);
            }
            else
            {
                DateTime endOfYear = new DateTime(lastYear.Year, 12, 31);
                while (dateOfHire < DateTime.Now)
                {
                    result += 2;
                    dateOfHire = dateOfHire.AddMonths(1);
                }
            }

            return result;
        }

        private byte CountUsedDays(DateTime year)
        {
            byte usedDays = 0;
            var employeeVacations = GetVacation_Employees();
            var employeeVacationDates = GetVacationDays();
            foreach (var itemV in employeeVacations)
            {
                foreach (var itemVD in employeeVacationDates)
                {
                    if (itemV.VacationId == itemVD.VacationId)
                    {
                        usedDays += (byte)itemVD.Days;
                    }
                }
            }
            return usedDays;
        }
        
        #endregion

        #region Vacation functions

        private async Task DisplayVacations()
        {
            _view.dataGridViewVacations.Rows.Clear();
            int i = 1;
            var employeeVacation = GetVacation_Employees();
            var vacationList = GetVacations();

            if (vacationList != null)
            {
                foreach (var item in vacationList)
                {
                    foreach (var it in employeeVacation)
                        if (item.Id == it.VacationId)
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

        #region MenageVacationApp
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

        private async Task AddVacationApplication()
        {

            var vacationApplcation = new Vacation();
            var view = new VacationApplicationView();
            view.SetObjectToEdit = vacationApplcation;
            view.SetEmployee = _model.Employee;
            view.ShowDialog();
            if(view.DialogResult == DialogResult.OK)
            {
                view.SetEmployee = _model.Employee;
                
            }
                
   
            await DisplayVacationApplications();

            await Task.CompletedTask;
        }

        private async Task DeleteVacationApplication()
        {
            Guid vacationID = Guid.Parse(_view.dataGridViewVacAppList.SelectedCells[4].Value.ToString());
            var vacation_employeeList = GetVacation_Employees();
            var vacation_employee = default(Vacation_Employee);
            try
            {
                vacation_employee = vacation_employeeList.Where(voe => voe.EmployeeId == _model.Employee.Id && voe.VacationId == vacationID).FirstOrDefault();
            }
            catch (Exception er)
            {
                _logger.Error("DeleteVacationApplication" + er);
                vacation_employee = null;
            }
     
            var vacationList = GetVacations();
            var vacation = default(Vacation);
            try
            {
                vacation = vacationList.Where(v => v.Id == vacationID).FirstOrDefault();
                var employee = _model.Employee;

                if (vacation_employee != null)
                    await _model.DeleteVacation_Employee(vacation_employee);
                await _model.DeleteVacation(vacation);
                await _model.UpdateEmployee(_model.Employee.Id, employee);
            }
            catch (Exception er)
            {
                _logger.Error("DeleteVacationApplication" + er);
                vacation = null; 
            }
            await DisplayVacationApplications();
        }

        private async Task DisplayVacationApplications()
        {
            _view.dataGridViewVacAppList.Rows.Clear();
            int i = 1;
            var vacationList = GetVacations();
            var vacation_employeeList = GetVacation_Employees();
                if (vacationList != null)
                {
                    foreach (var itemVE in vacation_employeeList)
                    {
                        foreach (var itemV in vacationList)
                        {
                            if (itemVE.VacationId == itemV.Id && itemV.Approve == false)
                            {
                                _view.dataGridViewVacAppList.Rows.Add(i, itemV.Description,
                                    itemV.Start.ToString("dd.MM.yyyy"), itemV.End.ToString("dd.MM.yyyy"), itemV.Id);
                                i++;
                            }
                        }
                    }

                }
                else
                {
                    _view.dataGridViewVacAppList.Rows.Add(i, "brak wniosków");
                }

                await Task.CompletedTask;
            
            
        }

        #endregion

        #region AdminPanel
        private bool ValidatePermisson()
        {
            var result = false;

                if (_model.Employee.Password.Equals(_view.textBoxPassowrd.Text))
                {
                    if (_model.Employee.EmployeePermisson || _model.Employee.VacationPermisson)
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

        # region AllUsedFunctions

        private List<Vacation_Employee> GetVacation_Employees()
        {
            var result = default(List<Vacation_Employee>);
            try
            {
                var list = _model.GetVacation_Employees().Result;
                result = list.Where(voe => voe.EmployeeId == _model.Employee.Id).ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.Error("GetVacation_Employee" + ex);
                return null;
            }
        }

        private List<VacationDays> GetVacationDays()
        {
            var result = default(List<VacationDays>);
            try
            {
                result = _model.GetVacationDays().Result.ToList();
                return result;
            }
            catch (Exception er)
            {
                _logger.Error("GetVacationDays" + er);
                return null;
            }
        }

        private List<Vacation> GetVacations()
        {
            var result = default(List<Vacation>);
            try
            {      
                result = _model.GetVacations().Result;
                return result;
            }
            catch (Exception er)
            {
                _logger.Error("GetVacationDays" + er);
                return null;
            }
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
