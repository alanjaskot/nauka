using nauka.V3.Models;
using nauka.V3.Views.AdministrationViews.AdminMainViews.Models;
using nauka.V3.Views.AdministrationViews.AdminMainViews.Views;
using nauka.V3.Views.AdministrationViews.UsereControls;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using nauka.V3.Views.AdministrationViews.SectionViews.SectionViews;
using nauka.V3.Views.LoginRegisterViews.Views;
using nauka.V3.Views.AdministrationViews.RegisterVIews.Views;
using System.Collections.Generic;
using nauka.V3.Views.AdministrationViews.UserControls;
using nauka.V3.Resources;
using nauka.V3.Views.MianViews;
using nauka.V3.Views.AdministrationViews.NewAbsenceViews.Views;

namespace nauka.V3.Views.AdministrationViews.AdminMainViews.Controller
{
    class AdminMainViewController
    {
        private readonly AdminMainView _view;
        private AdminMainViewModel _model;
        private List<Employee> _employees;

        private EmployeesUC employeesUC = new EmployeesUC();
        private PermissionUC permissionUC = new PermissionUC();
        private MenageVacationsUC menageVacationsUC = new MenageVacationsUC();
        private VacationPermissionUC vacationPermissionUC = new VacationPermissionUC();
        private MenageSectionUC menageSectionUC = new MenageSectionUC();
        private NewAbsenceUC newAbsenceUC = new NewAbsenceUC();

        public AdminMainViewController(AdminMainView view)
        {
            _view = view;
 
            Task.Run(async () =>
            {
                await InitViewModel();
                await InitView();
                
            }).Wait();
        }

        
        public async Task InitView()
        {
            await InitListAndDataGrid();

            _view.tabControlAdmin.Click += (object sender, EventArgs e) => 
            {

            };

            #region Sections buttons

            _view.buttonAddSection.Click += (object sender, EventArgs e) =>
            {
                AddSection();
            };

            _view.buttonEditSection.Click += (object sender, EventArgs e) =>
            {
                UpdateSection();
            };

            _view.buttonDeleteSection.Click += (object sender, EventArgs e) =>
            {
                DeleteSection();
            };

            #endregion

            #region MenageEmployees buttons

            _view.buttonDisplayEmployees.Click += (object sender, EventArgs e) =>
            {
                DisplayEmployees();
            };

            _view.buttonAddEmployee.Click += (object sender, EventArgs e) =>
            {
                AddEmployee();
            };

            _view.buttonUpdateEmployee.Click += (object sender, EventArgs e) =>
            {
                UpdateEmployee();
            };

            _view.buttonDeleteEmployee.Click += (object sender, EventArgs e) =>
            {
                DeleteEmployee();
            };

            #endregion

            #region Absences buttons

            _view.buttonChooseSectionAbsence.Click += (object sender, EventArgs e) =>
            {
                DisplayMenageAbsence();
            };

            _view.buttonAddAbsence.Click += (object sender, EventArgs e) =>
            {
                AddAbsence();
            };

            _view.buttonDeleteAbsence.Click += (object sender, EventArgs e) =>
            {
                DeleteAbsence();
            };



            #endregion



            _view.Click += (object sender, EventArgs e) =>
            {
                var currentEmployee = _model.Employee;
                var viewEmployee = new MainView();
                viewEmployee.SetObjectToEdit = currentEmployee;
                viewEmployee.Show();
                _view.Close();
                };





            #region Permission

            permissionUC.buttonDIsplayEmployees.Click += (object sender, EventArgs e) =>
            {
                DisplayEmployeesPermisson();
            };

            permissionUC.buttonChangePermisson.Click += (object sender, EventArgs e) =>
            {
                ChangePermission();
            };

            #endregion

            #region Exit and logout
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
                var result = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Wylogowanie", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    LoginView login = new LoginView();
                    login.Show();
                    _view.Close();
                }
            };

            #endregion

            await Task.CompletedTask;
        }

        private async Task InitListAndDataGrid()
        {
            SectionShowList();
            ShowSectionsEmployees();
            CreateDataGridEmployee();
            ShowSectionAbsence();
            CreateDataGridMenageAbsence();

            await Task.CompletedTask;
        }

        public async Task InitViewModel()
        {
            if (_model == null)
            {
                _model = new AdminMainViewModel();
            }
            else
                await Task.CompletedTask;

        }

        #region Sections functions
        private void SectionShowList()
        {
            _view.listViewSections.Items.Clear();
            
            foreach (var item in _model.GetSections())
            {
                _view.listViewSections.Items.Add(item.Name);
            }
        }

        private void AddSection()
        {
            var section = new Section();
            var view = new SectionView();
            view.SetObjectToEdit = section;
            view.Show();
            if (view.DialogResult == DialogResult.OK)
            {
                var section2 = view.SetObjectToEdit;
                _model.AddSection(section2);

                SectionShowList();
                
            }
            SectionShowList();
        }

        private void UpdateSection()
        {
            if(_view.listViewSections.SelectedItems.Count > 0)
            {
                var section = _model.GetSections().Where(s => s.Name == _view.listViewSections.SelectedItems[0].Text).FirstOrDefault();
                var view = new SectionView();
                view.SetObjectToEdit = section;
                view.Show();
                if (view.DialogResult == DialogResult.OK)
                {
                    var section2 = view.SetObjectToEdit;
                    _model.UpdateSection(section2);
                }
                SectionShowList();
            }  
        }

        private void DeleteSection()
        {
            var deletedSection = _model.GetSections().Where(s => s.Name == menageSectionUC.listViewSections.SelectedItems[0].Text)
                .FirstOrDefault();

            _model.DeleteSection(deletedSection);
        }


        #endregion

        #region Employee functions

        private void ShowSectionsEmployees()
        {
            _view.comboBoxSections.Items.Clear();
            foreach(var item in _model.GetSections())
            {
                _view.comboBoxSections.Items.Add(item.Name);
            }
        }

        private void DisplayEmployees()
        {
            _view.dataGridViewEmployees.Rows.Clear();
            int i = 1;
            var employeeList = _model.GetEmployees();
            foreach(var item in employeeList)
            {
                if((item.Section.Name == (string)_view.comboBoxSections.SelectedItem) && (item.Section.Name != null))
                {
                    _view.dataGridViewEmployees.Rows.Add(item.Id, i, item.Surname, item.Name);
                    i++;
                }
            }
        }

        private void AddEmployee()
        {
            var newEmployee = new Employee();
            var view = new RegisterView();
            
            view.SetObjectToEdit = newEmployee;
            if(view.DialogResult == DialogResult.OK)
            {
                var newEmployee2 = view.SetObjectToEdit;
                _model.AddEmployee(newEmployee2);
            }
            
        }

        private void UpdateEmployee()
        {
            if (employeesUC.dataGridViewEmployees.CurrentRow != null) 
            {
                Guid id = Guid.Parse(employeesUC.dataGridViewEmployees[0, employeesUC.dataGridViewEmployees.CurrentRow.Index].Value.ToString());
                _employees = _model.GetEmployees();
                var employeeToEdit = _employees.Where(e => e.Id == id).FirstOrDefault();
                var view = new RegisterView();
                view.SetObjectToEdit = employeeToEdit;
                if (view.ShowDialog() == DialogResult.OK)
                {
                    var selectedEmlpoyee2 = view.SetObjectToEdit;
                    _model.UpdateEmployee(selectedEmlpoyee2);
                }
            }
        }

        private void DeleteEmployee()
        {
            Guid id = Guid.Parse(employeesUC.dataGridViewEmployees[0, employeesUC.dataGridViewEmployees.CurrentRow.Index].Value.ToString());
            _employees = _model.GetEmployees();
            var employeeToDelete = _employees.Where(e => e.Id == id).FirstOrDefault();
            _model.DeleteEmployee(employeeToDelete);
            DisplayEmployees();

        }

        private void CreateDataGridEmployee()
        {
            var detailDGV = _view.dataGridViewEmployees;           

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
            dgvTextColumn.Width = 45;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = false;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Lp.";
            dgvTextColumn.Name = "ID";
            dgvTextColumn.DataPropertyName = "Id";
            dgvTextColumn.Width = 45;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Nazwisko";
            dgvTextColumn.Name = "EmployeeSurname";
            dgvTextColumn.DataPropertyName = "Surname";
            dgvTextColumn.Width = 200;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Imie";
            dgvTextColumn.Name = "EmployeeName";
            dgvTextColumn.DataPropertyName = "Name";
            dgvTextColumn.Width = 200;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);
        }

        #endregion

        #region Absences functions

        private void ShowSectionAbsence()
        {
            _view.comboBoxSectionAbsence.Items.Clear();

            foreach(var item in _model.GetSections())
            {
                _view.comboBoxSectionAbsence.Items.Add(item.Name);
            }
        }

        private void AddAbsence()
        {
            Guid idEmployee = Guid.Parse(_view.dataGridViewVacations[0, _view.dataGridViewVacations.CurrentRow.Index].Value.ToString());
            var employee = new Employee();
            var view = new NewAbsenceView();
            view.SetObjectToEdit = employee;
            if(view.DialogResult == DialogResult.OK)
            {
                var employee2 = view.SetObjectToEdit;
                int index = employee2.Vacation.Count - 1;
                _model.AddVacation(employee2.Vacation[index]);
            }
        }

        private void DeleteAbsence()
        {
            Guid idEmployee = Guid.Parse(_view.dataGridViewVacations[0, _view.dataGridViewVacations.CurrentRow.Index].Value.ToString());
            Guid idVacation = Guid.Parse(_view.dataGridViewVacations[7, _view.dataGridViewVacations.CurrentRow.Index].Value.ToString());

            int employeeIndex = _model.GetEmployees().FindIndex(e => e.Id == idEmployee);
            var vacation = _model.GetEmployees()[employeeIndex].Vacation.Where(v => v.Id == idVacation).FirstOrDefault();

            _model.DeleteVacation(vacation);

            DisplayMenageAbsence();
        }

        private void DisplayMenageAbsence()
        {
            _view.dataGridViewVacations.Rows.Clear();
            string today = DateTime.Now.ToString("yyyy");
            int i = 1;
            var employeeList = _model.GetEmployees().Where(e => e.Section.Name == (string)_view.comboBoxSections.SelectedItem);
            if (employeeList != null)
            {
                foreach (var itemEmployee in employeeList)
                {
                    if (itemEmployee.Vacation != null)
                    {
                        foreach (var item in itemEmployee.Vacation)
                        {
                            if ((item.Approve == true) && (item.Start.ToString("yyyy").Equals(today)
                                || item.End.ToString("yyyy").Equals(today)))
                            {
                                _view.dataGridViewVacations.Rows.Add(itemEmployee.Id, i, itemEmployee.Surname, itemEmployee.Name, 
                                    item.Start.ToString("dd.MM.yyyy"), item.End.ToString("dd.MM.yyyy"), item.Description, item.Id);
                                i++;
                            }
                        }
                    }
                }
            }
        }

        private void CreateDataGridMenageAbsence()
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
            dgvTextColumn.HeaderText = "Id";
            dgvTextColumn.Name = "Id";
            dgvTextColumn.DataPropertyName = "Id";
            dgvTextColumn.Width = 50;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = false;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Lp.";
            dgvTextColumn.Name = "Lp";
            dgvTextColumn.DataPropertyName = "Lp";
            dgvTextColumn.Width = 50;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "nazwisko";
            dgvTextColumn.Name = "Surname";
            dgvTextColumn.DataPropertyName = "Surname";
            dgvTextColumn.Width = 200;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "imie";
            dgvTextColumn.Name = "Name";
            dgvTextColumn.DataPropertyName = "Name";
            dgvTextColumn.Width = 150;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "od";
            dgvTextColumn.Name = "StartVacation";
            dgvTextColumn.DataPropertyName = "Start";
            dgvTextColumn.Width = 125;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "do";
            dgvTextColumn.Name = "VacationEnd";
            dgvTextColumn.DataPropertyName = "End";
            dgvTextColumn.Width = 125;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "opis";
            dgvTextColumn.Name = "Description";
            dgvTextColumn.DataPropertyName = "Description";
            dgvTextColumn.Width = 239;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "VacationId";
            dgvTextColumn.Name = "VacationId";
            dgvTextColumn.DataPropertyName = "VacationId";
            dgvTextColumn.Width = 239;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = false;
            detailDGV.Columns.Add(dgvTextColumn);
        }

        #endregion


        

        #region VacationPermission

        private void DenayVacation()
        {
            Guid idVacation = Guid.Parse(vacationPermissionUC.dataGridViewVacationApplications
                [7, vacationPermissionUC.dataGridViewVacationApplications.CurrentRow.Index].Value.ToString());
            Guid idEmployee = Guid.Parse(vacationPermissionUC.dataGridViewVacationApplications
                [0, vacationPermissionUC.dataGridViewVacationApplications.CurrentRow.Index].Value.ToString());

            int employeeIndex = _model.GetEmployees().FindIndex(e => e.Id == idEmployee);
            int vacationIndex = _model.GetEmployees()[employeeIndex].Vacation.FindIndex(v => v.Id == idVacation);
            _model.GetEmployees()[employeeIndex].Vacation.RemoveAt(vacationIndex);

            DisplayVacationPermisson();
        }

        private void ApproveVacation()
        {
            Guid idVacation = Guid.Parse(vacationPermissionUC.dataGridViewVacationApplications
                [7, vacationPermissionUC.dataGridViewVacationApplications.CurrentRow.Index].Value.ToString());
            Guid idEmployee = Guid.Parse(vacationPermissionUC.dataGridViewVacationApplications
                [0, vacationPermissionUC.dataGridViewVacationApplications.CurrentRow.Index].Value.ToString());

            int employeeIndex = _model.GetEmployees().FindIndex(e => e.Id == idEmployee);
            int vacationIndex = _model.GetEmployees()[employeeIndex].Vacation.FindIndex(v => v.Id == idVacation);
            var vacationDates = _model.GetEmployees()[employeeIndex].Vacation.Where(v => v.Id == idVacation).First();

            if (ValidApproveVacation(_model.GetEmployees()[employeeIndex], vacationDates.Start, vacationDates.End))
            {
                _model.GetEmployees()[employeeIndex].Vacation[vacationIndex].Approve = true;
                CountVacationDays(_model.GetEmployees()[employeeIndex], vacationDates.Start, vacationDates.End);
            }
            DisplayVacationPermisson();
        }

        private void CountVacationDays(Employee employee, DateTime start, DateTime end)
        {
            long daysOfVacation = 0;
            DateTime day = start;
            foreach(var item in employee.Vacation)
            {
                if(item.Start == start && item.End == end)
                {
                    while(day <= end)
                    {
                        if((day.DayOfWeek != DayOfWeek.Saturday) && (day.DayOfWeek != DayOfWeek.Sunday))
                        {
                            daysOfVacation++;
                        }
                        day = day.AddDays(1.0);
                    }
                }
            }
            employee.VacationDays.Add(new VacationDays { Days = daysOfVacation });
            //_model.AddVacation(employee);
        }

        private bool ValidApproveVacation(Employee employee, DateTime start, DateTime end)
        {
            var result = true;
            foreach(var item in employee.Vacation)
            {
                if(item.Approve == true)
                {
                    if ((start >= item.Start) && (start <= item.End))
                    {
                        result = false;
                        MessageBox.Show("Urlop pokrywa się z innym urlopem");
                        break;
                    }

                    if ((end >= item.Start) && (end <= item.End))
                    {
                        result = false;
                        MessageBox.Show("Urlop pokrywa się z innym urlopem");
                        break;
                    }
                }
            }
            return result;
        }

        private void DisplayVacationPermisson()
        {
            vacationPermissionUC.dataGridViewVacationApplications.Rows.Clear();
            
            int i = 1;
            var employeeList = _model.GetEmployees().Where(e => e.Section.Name == (string)vacationPermissionUC.comboBoxSections.SelectedItem);
            if(employeeList != null)
            {
                foreach (var itemEmployee in employeeList)
                {
                    if(itemEmployee.Vacation != null)
                    {
                        foreach (var item in itemEmployee.Vacation)
                        {
                            if (item.Approve == false)
                            {
                                vacationPermissionUC.dataGridViewVacationApplications.Rows.Add(itemEmployee.Id, i, itemEmployee.Surname,
                                    itemEmployee.Name, item.Start.ToString("dd.MM.yyyy"), item.End.ToString("dd.MM.yyyy"), item.Description, item.Id);
                                i++;
                            }
                        }
                    }
                }
            }
        }

        private void CreateDataGridVacationPermisson()
        {

            var detailDGV = vacationPermissionUC.dataGridViewVacationApplications;

            detailDGV.AllowUserToAddRows = false;
            detailDGV.AutoGenerateColumns = false;
            detailDGV.RowHeadersVisible = false;
            detailDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            detailDGV.Columns.Clear();
            detailDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var dgvTextColumn = default(DataGridViewColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Id";
            dgvTextColumn.Name = "Id";
            dgvTextColumn.DataPropertyName = "Id";
            dgvTextColumn.Width = 50;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = false;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Lp.";
            dgvTextColumn.Name = "Lp";
            dgvTextColumn.DataPropertyName = "Lp";
            dgvTextColumn.Width = 50;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "nazwisko";
            dgvTextColumn.Name = "Surname";
            dgvTextColumn.DataPropertyName = "Surname";
            dgvTextColumn.Width = 200;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "imie";
            dgvTextColumn.Name = "Name";
            dgvTextColumn.DataPropertyName = "Name";
            dgvTextColumn.Width = 200;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "od";
            dgvTextColumn.Name = "StartVacation";
            dgvTextColumn.DataPropertyName = "Start";
            dgvTextColumn.Width = 150;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "do";
            dgvTextColumn.Name = "VacationEnd";
            dgvTextColumn.DataPropertyName = "End";
            dgvTextColumn.Width = 150;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "opis";
            dgvTextColumn.Name = "Description";
            dgvTextColumn.DataPropertyName = "Description";
            dgvTextColumn.Width = 239;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "VacationId";
            dgvTextColumn.Name = "VacationId";
            dgvTextColumn.DataPropertyName = "VacationId";
            dgvTextColumn.Width = 239;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = false;
            detailDGV.Columns.Add(dgvTextColumn);
        }

        #endregion

        #region Permisson functions

        private void DisplayEmployeesPermisson()
        {
            permissionUC.dataGridViewEmployees.Rows.Clear();
            int i = 1;
            var employeeList = _model.GetEmployees();
            foreach (var item in employeeList)
            {
                if (item.Section.Name == (string)permissionUC.comboBoxSections.SelectedItem)
                {
                    string vacper;
                    if (item.VacationPermisson == false)
                        vacper = "nie przyznano";
                    else
                        vacper = "przyznano";

                    string empper;
                    if (item.EmployeePermisson == false)
                        empper = "nie przyznano";
                    else
                        empper = "przyznano";

                    permissionUC.dataGridViewEmployees.Rows.Add(item.Id, i, item.Surname, item.Name, 
                        vacper, empper);
                    i++;
                }
            }
        }

        private void ChangePermission()
        {
            int rowindex = permissionUC.dataGridViewEmployees.CurrentRow.Index;
            Guid id = Guid.Parse(permissionUC.dataGridViewEmployees[0, permissionUC.dataGridViewEmployees.CurrentRow.Index].Value.ToString());
            int employeeIndex = _model.GetEmployees().FindIndex(e => e.Id == id);

            if (permissionUC.checkBoxVacations.Checked)
                _model.GetEmployees()[employeeIndex].VacationPermisson = true;
            else
                _model.GetEmployees()[employeeIndex].VacationPermisson = false;

            if (permissionUC.checkBoxEmployee.Checked)
                _model.GetEmployees()[employeeIndex].EmployeePermisson = true;
            else
                _model.GetEmployees()[employeeIndex].EmployeePermisson = false;
            DisplayEmployeesPermisson();
        }

        private void CreateDataGridEmployeePermisson()
        {
            var detailDGV = permissionUC.dataGridViewEmployees;

            detailDGV.AllowUserToAddRows = false;
            detailDGV.AutoGenerateColumns = false;
            detailDGV.RowHeadersVisible = false;
            detailDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            detailDGV.Columns.Clear();
            detailDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var dgvTextColumn = default(DataGridViewColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "ID";
            dgvTextColumn.Name = "ID";
            dgvTextColumn.DataPropertyName = "ID";
            dgvTextColumn.Width = 50;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = false;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Lp.";
            dgvTextColumn.Name = "Lp";
            dgvTextColumn.DataPropertyName = "Lp";
            dgvTextColumn.Width = 45;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Nazwisko";
            dgvTextColumn.Name = "EmployeeSurname";
            dgvTextColumn.DataPropertyName = "Surname";
            dgvTextColumn.Width = 200;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Imie";
            dgvTextColumn.Name = "EmployeeName";
            dgvTextColumn.DataPropertyName = "Name";
            dgvTextColumn.Width = 200;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Uprawnienia - wakacje";
            dgvTextColumn.Name = "VacationPermisson";
            dgvTextColumn.DataPropertyName = "VacationPermisson";
            dgvTextColumn.Width = 200;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Uprawnienia - pracownicy";
            dgvTextColumn.Name = "VacationPermisson";
            dgvTextColumn.DataPropertyName = "VacationPermisson";
            dgvTextColumn.Width = 200;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);
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
