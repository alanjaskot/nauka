using nauka.V3.Models;
using nauka.V3.Views.AdministrationViews.AdminMainViews.Models;
using nauka.V3.Views.AdministrationViews.AdminMainViews.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using nauka.V3.Views.AdministrationViews.SectionViews.SectionViews;
using nauka.V3.Views.LoginRegisterViews.Views;
using nauka.V3.Views.AdministrationViews.RegisterVIews.Views;
using System.Collections.Generic;
using nauka.V3.Resources;
using nauka.V3.Views.MianViews;
using nauka.V3.Views.AdministrationViews.NewAbsenceViews.Views;

namespace nauka.V3.Views.AdministrationViews.AdminMainViews.Controller
{
    class AdminMainViewController
    {
        private readonly AdminMainView _view;
        private AdminMainViewModel _model;

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
                if (_model.Employee.EmployeePermisson == true)
                    DisplayEmployees();
                else
                    MessageBox.Show("Brak uprawnień");
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
                if (_model.Employee.VacationPermisson == true)
                    DisplayMenageAbsence();
                else
                    MessageBox.Show("Brak uprawnień");
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

            #region MenageVacApp buttons

            _view.buttonMenageAppSection.Click += (object sender, EventArgs e) =>
            {
                if (_model.Employee.VacationPermisson == true)
                    DisplayVacAppPermissons();
                else
                    MessageBox.Show("Brak uprawnień");
            };

            _view.buttonMenageAppApprove.Click += (object sender, EventArgs e) =>
            {
                ApproveVacation();
            };

            _view.buttonMenageAppDenay.Click += (object sender, EventArgs e) =>
            {
                DenayVacation();
            };

            #endregion

            #region Permisson buttons

            _view.buttonShowEmployeePermisson.Click += (object sender, EventArgs e) =>
            {
                DisplayEmployeesPermisson();
            };

            _view.buttonChangePermisson.Click += (object sender, EventArgs e) =>
            {
                ChangePermission();
            };

            #endregion

            #region Exit and logout buttons
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
            await SectionShowList(); //Sections
            await ShowSectionsEmployees(); //Employees
            await CreateDataGridEmployee(); //Employees
            await ShowSectionAbsence(); //Absence
            await CreateDataGridMenageAbsence(); //Absence
            await CreateDataGridVacApp(); //VacApp
            await ShowSectionVacApp(); //Vacapp
            await CreateDataGridEmployeePermisson(); //Permisson
            await ShowSectionPermisson(); //Permisson

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
        private async Task SectionShowList()
        {
            _view.listViewSections.Items.Clear();
            
            foreach (var item in _model.GetSections().Result)
            {
                _view.listViewSections.Items.Add(item.Name);
            }

            await Task.CompletedTask;
        }

        private async Task AddSection()
        {
            var section = new Section();
            var view = new SectionView();
            view.SetObjectToEdit = section;
            view.Show();
            if (view.DialogResult == DialogResult.OK)
            {
                var section2 = view.SetObjectToEdit;
                await _model.AddSection(section2);

                await SectionShowList();
                
            }
            await SectionShowList();
        }

        private async Task UpdateSection()
        {
            if(_view.listViewSections.SelectedItems.Count > 0)
            {
                var section = _model.GetSections().Result.Where(s => s.Name == _view.listViewSections.SelectedItems[0].Text).FirstOrDefault();
                var view = new SectionView();
                view.SetObjectToEdit = section;
                view.Show();
                if (view.DialogResult == DialogResult.OK)
                {
                    var section2 = view.SetObjectToEdit;
                    await _model.UpdateSection(section2);
                }
                await SectionShowList ();
            }  
        }

        private async Task DeleteSection()
        {
            var deletedSection = _model.GetSections().Result.Where(s => s.Name == _view.listViewSections.SelectedItems[0].Text)
                .FirstOrDefault();

            await _model.DeleteSection(deletedSection);
        }


        #endregion

        #region Employee functions

        private async Task ShowSectionsEmployees()
        {
            _view.comboBoxSections.Items.Clear();
            foreach(var item in _model.GetSections().Result)
            {
                _view.comboBoxSections.Items.Add(item.Name);
            }
            await Task.CompletedTask;
        }

        private async Task DisplayEmployees()
        {
            _view.dataGridViewEmployees.Rows.Clear();
            int i = 1;
            var employeeList = _model.GetEmployees().Result;
            foreach(var item in employeeList)
            {
                if((item.Section.Name == (string)_view.comboBoxSections.SelectedItem) && (item.Section.Name != null))
                {
                    _view.dataGridViewEmployees.Rows.Add(item.Id, i, item.Surname, item.Name);
                    i++;
                }
            }

            await Task.CompletedTask;
        }

        private async Task AddEmployee()
        {
            var newEmployee = new Employee();
            var view = new RegisterView();
            view.SetObjectToEdit = newEmployee;
            if(view.DialogResult == DialogResult.OK)
            {
                var newEmployee2 = view.SetObjectToEdit;
                await _model.AddEmployee(newEmployee2);
            }
            
        }

        private async Task UpdateEmployee()
        {
            if (_view.dataGridViewEmployees.CurrentRow != null) 
            {
                Guid id = Guid.Parse(_view.dataGridViewEmployees[0, _view.dataGridViewEmployees.CurrentRow.Index].Value.ToString());
                var employeeToEdit = _model.GetEmployees().Result.Where(e => e.Id == id).FirstOrDefault();
                var view = new RegisterView();
                view.SetObjectToEdit = employeeToEdit;
                if (view.ShowDialog() == DialogResult.OK)
                {
                    var selectedEmlpoyee2 = view.SetObjectToEdit;
                    await _model.UpdateEmployee(selectedEmlpoyee2);
                }
            }
        }

        private async Task DeleteEmployee()
        {
            Guid id = Guid.Parse(_view.dataGridViewEmployees[0, _view.dataGridViewEmployees.CurrentRow.Index].Value.ToString());
            var employees = _model.GetEmployees().Result;
            var employeeToDelete = employees.Where(e => e.Id == id).FirstOrDefault();
            await _model.DeleteEmployee(employeeToDelete);
            await DisplayEmployees();

        }

        private async Task CreateDataGridEmployee()
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

            await Task.CompletedTask;
        }

        #endregion

        #region Absences functions

        private async Task ShowSectionAbsence()
        {
            _view.comboBoxSectionAbsence.Items.Clear();

            foreach(var item in _model.GetSections().Result)
            {
                _view.comboBoxSectionAbsence.Items.Add(item.Name);
            }
            await Task.CompletedTask;
        }

        private void AddAbsence()
        {
            var employee = new Employee();
            var view = new NewAbsenceView();
            view.SetObjectToEdit = employee;
            view.Show();
        }

        private async Task DeleteAbsence()
        {
            Guid idEmployee = Guid.Parse(_view.dataGridViewAbsence[0, _view.dataGridViewAbsence.CurrentRow.Index].Value.ToString());
            Guid idVacation = Guid.Parse(_view.dataGridViewAbsence[7, _view.dataGridViewAbsence.CurrentRow.Index].Value.ToString());

            var employee = _model.GetEmployees().Result.Where(e => e.Id == idEmployee).FirstOrDefault();
            var vacation = _model.GetVacations().Result.Where(v => v.Id == idVacation).FirstOrDefault();
            employee.Vacations.Remove(idVacation);

            await _model.DeleteVacation(vacation);
            await _model.UpdateEmployee(employee);

            await DisplayMenageAbsence ();
        }

        private async Task DisplayMenageAbsence()
        {
            _view.dataGridViewAbsence.Rows.Clear();
            DateTime today = DateTime.Now;
            int i = 1;
            var employeeList = _model.GetEmployees().Result.Where(e => e.Section.Name == (string)_view.comboBoxSectionAbsence.SelectedItem);
            var vacationApprovedList = _model.GetVacations().Result.Where(v => (v.Approve == true) &&
            (v.End.ToString("yyyy").Equals(DateTime.Now.ToString("yyyy")) || (v.End.ToString("yyyy").Equals(DateTime.Now.ToString("yyyy"))))).ToList();

            if(employeeList != null && vacationApprovedList != null)
            {
                foreach(var item in employeeList)
                {
                    foreach(var itemVacId in item.Vacations)
                    {
                        foreach(var itemVacation in vacationApprovedList)
                        {
                            if(itemVacId == itemVacation.Id)
                            {
                                _view.dataGridViewAbsence.Rows.Add(item.Id, i, item.Surname, item.Name, itemVacation.Start.ToString("dd.MM.yyyy"),
                                    itemVacation.End.ToString("dd.MM.yyyy"), itemVacation.Description, itemVacId);
                                i++;
                            }
                            
                        }
                    }
                } 
            }

            await Task.CompletedTask;
        }

        private async Task CreateDataGridMenageAbsence()
        {

            var detailDGV = _view.dataGridViewAbsence;

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

            await Task.CompletedTask;
        }

        #endregion

        #region VacationPermission

        private async Task DenayVacation()
        {
            Guid idVacation = Guid.Parse(_view.dataGridViewVacApp[7, _view.dataGridViewVacApp.CurrentRow.Index].Value.ToString());
            Guid idEmployee = Guid.Parse(_view.dataGridViewVacApp[0, _view.dataGridViewVacApp.CurrentRow.Index].Value.ToString());
            var employee = _model.GetEmployees().Result.Where(e => e.Id == idEmployee).FirstOrDefault();
            employee.Vacations.Remove(idVacation);

            await _model.DeleteVacation(_model.GetVacations().Result.Where(v => v.Id == idVacation).FirstOrDefault());
            await _model.UpdateEmployee(employee);

            await DisplayVacAppPermissons ();
        }

        private async Task ApproveVacation()
        {
            Guid idVacation = Guid.Parse(_view.dataGridViewVacApp[7, _view.dataGridViewVacApp.CurrentRow.Index].Value.ToString());
            Guid idEmployee = Guid.Parse(_view.dataGridViewVacApp[0, _view.dataGridViewVacApp.CurrentRow.Index].Value.ToString());

            var employee = _model.GetEmployees().Result.Where(e => e.Id == idEmployee).FirstOrDefault();
            var vacation = _model.GetVacations().Result.Where(v => v.Id == idVacation).FirstOrDefault();


            if (ValidApproveVacation(employee, vacation))
            {
                vacation.Approve = true;
                await _model.UpdateVacation(vacation);
                await CountVacationDays(employee, vacation);
            }
            await DisplayVacAppPermissons ();
        }

        private async Task CountVacationDays(Employee employee, Vacation vacation)
        {
            long daysOfVacation = 0;
            DateTime day = vacation.Start;

            while (day <= vacation.End)
            {
                if ((day.DayOfWeek != DayOfWeek.Saturday) && (day.DayOfWeek != DayOfWeek.Sunday))
                {
                    daysOfVacation++;
                }
                day = day.AddDays(1.0);
            }

            var vacationDays = new VacationDays
            {
                Id = Guid.NewGuid(),
                Days = daysOfVacation,
                Year = DateTime.Now,
                VacationId = vacation.Id
            };

            await _model.AddVacationDays(vacationDays);
            
        }

        private bool ValidApproveVacation(Employee employee, Vacation vacation)
        {
            var result = true;

            foreach(var itemEmployeeVacation in employee.Vacations)
            {
                foreach (var item in _model.GetVacations().Result)
                {
                    if(item.Id == itemEmployeeVacation && item.Id != vacation.Id)
                    {
                        if ((vacation.Start >= item.Start) && (vacation.End <= item.End))
                        {
                            result = false;
                            MessageBox.Show("Wniosek pokrywa się z innym urlopem");
                            break;
                        }

                        if ((vacation.End >= item.Start) && (vacation.End <= item.End))
                        {
                            result = false;
                            MessageBox.Show("Wniosek pokrywa się z innym urlopem");
                            break;
                        }

                        if ((vacation.Start < item.Start) && (vacation.End > item.End))
                        {
                            result = false;
                            MessageBox.Show("Wniosek pokrywa się z innym urlopem");
                            break;
                        }
                    }
                }
            }
            return result;
        }

        private async Task DisplayVacAppPermissons()
        {
            _view.dataGridViewVacApp.Rows.Clear();
            
            int i = 1;
            var employeeList = _model.GetEmployees().Result.Where(e => e.Section.Name == (string)_view.comboBoxSectionVacApp.SelectedItem);
            if(employeeList != null)
            {
                foreach(var itemEmployee in employeeList)
                {
                    if (itemEmployee.VacationId != null)
                    {
                        foreach(var itemId in itemEmployee.Vacations.ToList())
                        {
                            foreach(var item in _model.GetVacations().Result)
                            {
                                if((itemId == item.Id) && (item.Approve == false))
                                {
                                    _view.dataGridViewVacApp.Rows.Add(itemEmployee.Id, i, itemEmployee.Surname, itemEmployee.Name,
                                        item.Start.ToString("dd.MM.yyyy"), item.End.ToString("dd.MM.yyyy"), item.Description, item.Id);
                                    i++;
                                }
                                    
                            }
                        }
                    }
                }
            }
            await Task.CompletedTask;
        }

        private async Task ShowSectionVacApp()
        {
            _view.comboBoxSectionVacApp.Items.Clear();

            foreach(var item in _model.GetSections().Result)
            {
                _view.comboBoxSectionVacApp.Items.Add(item.Name);
            }
            await Task.CompletedTask;
        }

        private async Task CreateDataGridVacApp()
        {

            var detailDGV = _view.dataGridViewVacApp;

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

            await Task.CompletedTask;
        }

        #endregion

        #region Permisson functions

        private async Task ChangePermission()
        {
            int rowindex = _view.dataGridViewPermisson.CurrentRow.Index;
            Guid employeeId = Guid.Parse(_view.dataGridViewPermisson[0, _view.dataGridViewPermisson.CurrentRow.Index].Value.ToString());
            var employee = _model.GetEmployees().Result.Where(e => e.Id == employeeId).FirstOrDefault();

            if (_view.checkBoxVacations.Checked)
                employee.VacationPermisson = true;
            else
                employee.VacationPermisson = false;

            if (_view.checkBoxEmployee.Checked)
                employee.EmployeePermisson = true;
            else
                employee.EmployeePermisson = false;

            await _model.UpdateEmployee(employee);
            await DisplayEmployeesPermisson();
        }

        private async Task DisplayEmployeesPermisson()
        {
            _view.dataGridViewPermisson.Rows.Clear();
            int i = 1;
            var employeeList = _model.GetEmployees().Result;
            if(employeeList != null)
            {
                foreach (var item in employeeList)
                {
                    if (item.Section.Name == (string)_view.comboBoxSectionPermisson.SelectedItem)
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

                        _view.dataGridViewPermisson.Rows.Add(item.Id, i, item.Surname, item.Name,
                            vacper, empper);
                        i++;
                    }
                }
            }

            await Task.CompletedTask;
        }

        private async Task ShowSectionPermisson()
        {
            _view.comboBoxSectionPermisson.Items.Clear();

            foreach(var item in _model.GetSections().Result)
            {
                _view.comboBoxSectionPermisson.Items.Add(item.Name);
            }

            await Task.CompletedTask;
        }

        private async Task CreateDataGridEmployeePermisson()
        {
            var detailDGV = _view.dataGridViewPermisson;

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

            await Task.CompletedTask;
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
