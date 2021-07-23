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
            InitDataGrids();
            await InitLists();


            #region Sections buttons

            _view.buttonAddSection.Click += (object sender, EventArgs e) =>
            {
                Task.Run(async () => await AddSection());
            };

            _view.buttonEditSection.Click += (object sender, EventArgs e) =>
            {
                Task.Run(async () => await UpdateSection());
            };

            _view.buttonDeleteSection.Click += (object sender, EventArgs e) =>
            {
                Task.Run(async () => await DeleteSection());
            };

            #endregion

            #region MenageEmployees buttons

            _view.buttonDisplayEmployees.Click += (object sender, EventArgs e) =>
            {
                if (_model.Employee.EmployeePermisson == true)
                    Task.Run(async () => await DisplayEmployees());
                else
                    MessageBox.Show("Brak uprawnień");
            };

            _view.buttonAddEmployee.Click += (object sender, EventArgs e) =>
            {
                Task.Run(async () => await AddEmployee());
            };

            _view.buttonUpdateEmployee.Click += (object sender, EventArgs e) =>
            {
                Task.Run(async () => await UpdateEmployee());
            };

            _view.buttonDeleteEmployee.Click += (object sender, EventArgs e) =>
            {
                Task.Run(async () => await DeleteEmployee());
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
                    Task.Run(async () => await DisplayVacAppPermissons()) ;
                else
                    MessageBox.Show("Brak uprawnień");
            };

            _view.buttonMenageAppApprove.Click += (object sender, EventArgs e) =>
            {
                Task.Run(async () => await ApproveVacation()) ;
            };

            _view.buttonMenageAppDenay.Click += (object sender, EventArgs e) =>
            {
                Task.Run(async () => await DenayVacation());
            };

            #endregion

            #region Permisson buttons

            _view.buttonShowEmployeePermisson.Click += (object sender, EventArgs e) =>
            {
                Task.Run(async () => await DisplayEmployeesPermisson());
            };

            _view.buttonChangePermisson.Click += (object sender, EventArgs e) =>
            {
                Task.Run(async () => await ChangePermission());
            };

            #endregion

            #region Exit and logout buttons
            _view.buttonExit.Click += (object sender, EventArgs e) => 
            {
                try
                {
                    var result = MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Wyjście", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
                catch
                {
                    throw;
                }
                
            };

            _view.buttonLogout.Click += (object sender, EventArgs e) =>
            {
                try
                {
                    var result = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Wylogowanie", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        LoginView login = new LoginView();
                        login.Show();
                        _view.Close();
                    }
                }
                catch
                {
                    throw;
                }
                
            };

            #endregion 

            await Task.CompletedTask;
        }

        private async Task InitLists()
        {
            try
            {
                await SectionShowList();
                await ShowSectionsEmployees();
                await ShowSectionAbsence();
                await ShowSectionVacApp();
                await ShowSectionPermisson();
            }
            catch
            {
                throw;
            }
        }
        private void InitDataGrids()
        {
            try
            {
                CreateDataGridEmployee();
                CreateDataGridMenageAbsence();
                CreateDataGridVacApp();
                CreateDataGridEmployeePermisson();
            }
            catch
            {
                throw;
            }           
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
                view.ShowDialog();
                if (view.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        var section2 = view.SetObjectToEdit;
                        await _model.AddSection(section2);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
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
                    view.ShowDialog();
                    if (view.DialogResult == DialogResult.OK)
                    {
                        try
                        {
                            var section2 = view.SetObjectToEdit;
                            var section2Id = section2.Id;
                            await _model.UpdateSection(section2Id, section2);
                        }
                        catch
                        {
                            throw;
                        }
                        
                    }
                    await SectionShowList();               
            }  
        }

        private async Task DeleteSection()
        {

                var deleteSection = _model.GetSections().Result.Where(s => s.Name == _view.listViewSections.SelectedItems[0].Text)
                .FirstOrDefault();

                await _model.DeleteSection(deleteSection);
            
            await SectionShowList();
        }


        #endregion

        #region Employee functions

        private async Task ShowSectionsEmployees()
        {
            _view.comboBoxSections.Items.Clear();
            foreach (var item in _model.GetSections().Result)
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
                foreach (var item in employeeList)
                {
                    if ((item.Section.Name == (string)_view.comboBoxSections.SelectedItem) && (item.Section.Name != null))
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
                view.ShowDialog();
                if (view.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        var newEmployee2 = view.SetObjectToEdit;
                        await _model.AddEmployee(newEmployee2);
                    }
                    catch
                    {
                        throw;
                    }
                }

            await DisplayEmployees();
        }

        private async Task UpdateEmployee()
        {

                if (_view.dataGridViewEmployees.CurrentRow != null)
                {
                    Guid id = Guid.Parse(_view.dataGridViewEmployees[0, _view.dataGridViewEmployees.CurrentRow.Index].Value.ToString());
                    var employeeToUpdate = _model.GetEmployees().Result.Where(e => e.Id == id).FirstOrDefault();
                    var view = new RegisterView();
                    view.SetObjectToEdit = employeeToUpdate;
                    if (view.ShowDialog() == DialogResult.OK)
                    {
                        var employeeToUpdate2 = view.SetObjectToEdit;
                        var employeeToUpdate2Id = employeeToUpdate2.Id;
                        await _model.UpdateEmployee(employeeToUpdate2Id, employeeToUpdate2);
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

        private async Task ShowSectionAbsence()
        {
            try
            {
                _view.comboBoxSectionAbsence.Items.Clear();
                foreach (var item in _model.GetSections().Result)
                {
                    _view.comboBoxSectionAbsence.Items.Add(item.Name);
                }
            }
            catch
            {
                throw;
            }
            
            await Task.CompletedTask;
        }

        private void AddAbsence()
        {
            try
            {
                var employee = new Employee();
                var view = new NewAbsenceView();
                view.SetObjectToEdit = employee;
                view.Show();
            }
            catch
            {
                throw;
            }
            
        }

        private async Task DeleteAbsence()
        {
            try
            {
                Guid idEmployee = Guid.Parse(_view.dataGridViewAbsence[0, _view.dataGridViewAbsence.CurrentRow.Index].Value.ToString());
                Guid idVacation = Guid.Parse(_view.dataGridViewAbsence[7, _view.dataGridViewAbsence.CurrentRow.Index].Value.ToString());

                var employee = _model.GetEmployees().Result.Where(e => e.Id == idEmployee).FirstOrDefault();
                var vacation = _model.GetVacations().Result.Where(v => v.Id == idVacation).FirstOrDefault();
                var vacation_employee = _model.GetVacation_Employees().Result.Where(voe => voe.VacationId == idVacation).FirstOrDefault();

                await _model.DeleteVacationEmployee(vacation_employee);
                await _model.DeleteVacation(vacation);
            }
            catch
            {
                throw;
            }
            

            await DisplayMenageAbsence ();
        }

        private async Task DisplayMenageAbsence()
        {
            try
            {
                _view.dataGridViewAbsence.Rows.Clear();
                DateTime today = DateTime.Now;
                int i = 1;
                var employeeList = _model.GetEmployees().Result.Where(e => e.Section.Name == (string)_view.comboBoxSectionAbsence.SelectedItem);
                var vacationApprovedList = _model.GetVacations().Result.Where(v => (v.Approve == true) &&
                (v.End.ToString("yyyy").Equals(DateTime.Now.ToString("yyyy")) || (v.End.ToString("yyyy").Equals(DateTime.Now.ToString("yyyy"))))).ToList();

                if (employeeList != null && vacationApprovedList != null)
                {
                    foreach (var item in employeeList)
                    {
                        foreach (var itemVacEmp in _model.GetVacation_Employees().Result)
                        {
                            foreach (var itemVacation in vacationApprovedList)
                            {
                                if (itemVacEmp.VacationId == itemVacation.Id && item.Id == itemVacEmp.EmployeeId)
                                {
                                    _view.dataGridViewAbsence.Rows.Add(item.Id, i, item.Surname, item.Name, itemVacation.Start.ToString("dd.MM.yyyy"),
                                        itemVacation.End.ToString("dd.MM.yyyy"), itemVacation.Description, itemVacation.Id);
                                    i++;
                                }

                            }
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
            await Task.CompletedTask;
        }

        private void CreateDataGridMenageAbsence()
        {
            try
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
            }
            catch
            {
                throw;
            }
            

        }

        #endregion

        #region VacationPermission

        private async Task DenayVacation()
        {
            try
            {
                Guid idVacation = Guid.Parse(_view.dataGridViewVacApp[7, _view.dataGridViewVacApp.CurrentRow.Index].Value.ToString());
                Guid idEmployee = Guid.Parse(_view.dataGridViewVacApp[0, _view.dataGridViewVacApp.CurrentRow.Index].Value.ToString());
                var vacation_employee = _model.GetVacation_Employees().Result
                    .Where(voe => voe.VacationId == idVacation && voe.EmployeeId == idEmployee).FirstOrDefault();
                var employee = _model.GetEmployees().Result.Where(e => e.Id == idEmployee).FirstOrDefault();

                employee.Vacation_Employees.Remove(vacation_employee);
                await _model.DeleteVacationEmployee(vacation_employee);
                await _model.DeleteVacation(_model.GetVacations().Result.Where(v => v.Id == idVacation).FirstOrDefault());
                await _model.UpdateEmployee(idEmployee, employee);
            }
            catch
            {
                throw;
            }
            

            await DisplayVacAppPermissons ();
        }

        private async Task ApproveVacation()
        {
            try
            {
                Guid idVacation = Guid.Parse(_view.dataGridViewVacApp[7, _view.dataGridViewVacApp.CurrentRow.Index].Value.ToString());
                Guid idEmployee = Guid.Parse(_view.dataGridViewVacApp[0, _view.dataGridViewVacApp.CurrentRow.Index].Value.ToString());

                var employee = _model.GetEmployees().Result.Where(e => e.Id == idEmployee).FirstOrDefault();
                var vacation = _model.GetVacations().Result.Where(v => v.Id == idVacation).FirstOrDefault();

                if (ValidApproveVacation(employee, vacation))
                {
                    vacation.Approve = true;
                    await _model.UpdateVacation(idVacation, vacation);
                    await CountVacationDays(employee, vacation);
                }
            }
            catch
            {
                throw;
            }
            
            await DisplayVacAppPermissons ();
        }

        private async Task CountVacationDays(Employee employee, Vacation vacation)
        {
            try
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

                vacation.VacationDaysId = vacationDays.Id;

                await _model.AddVacationDays(vacationDays);
                await _model.UpdateVacation(vacation.Id, vacation);
            }
            catch
            {
                throw;
            } 
        }

        private bool ValidApproveVacation(Employee employee, Vacation vacation)
        {
            var result = true;
            try
            {
                foreach (var itemEmployeeVacation in _model.GetVacation_Employees().Result.Where(voe => voe.EmployeeId == employee.Id))
                {
                    foreach (var item in _model.GetVacations().Result)
                    {
                        if (item.Id == itemEmployeeVacation.VacationId && item.Id != vacation.Id)
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
            }
            catch
            {
                throw;
            }
            
            return result;
        }

        private async Task DisplayVacAppPermissons()
        {
            try
            {
                _view.dataGridViewVacApp.Rows.Clear();

                int i = 1;
                var employeeList = _model.GetEmployees().Result.Where(e => e.Section.Name == (string)_view.comboBoxSectionVacApp.SelectedItem);
                employeeList = employeeList.Where(e => e.Vacation_Employees != null);
                if (employeeList != null)
                {
                    foreach (var itemEmployee in employeeList)
                    {
                        foreach (var itemVacEmp in _model.GetVacation_Employees().Result.Where(voe => voe.EmployeeId == itemEmployee.Id))
                        {
                            foreach (var item in _model.GetVacations().Result)
                            {
                                if ((itemVacEmp.VacationId == item.Id) && (item.Approve == false))
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
            catch
            {
                throw;
            }

            await Task.CompletedTask;
        }

        private async Task ShowSectionVacApp()
        {
            try
            {
                _view.comboBoxSectionVacApp.Items.Clear();

                foreach (var item in _model.GetSections().Result)
                {
                    _view.comboBoxSectionVacApp.Items.Add(item.Name);
                }
            }
            catch
            {
                throw;
            }
            await Task.CompletedTask;
        }

        private void CreateDataGridVacApp()
        {
            try
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
            }
            catch
            {
                throw;
            }
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

                await _model.UpdateEmployee(employeeId, employee);
                await DisplayEmployeesPermisson();
        }

        private async Task DisplayEmployeesPermisson()
        {

                _view.dataGridViewPermisson.Rows.Clear();
                int i = 1;
                var employeeList = _model.GetEmployees().Result;
                if (employeeList != null)
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
        }

        private async Task ShowSectionPermisson()
        {
                _view.comboBoxSectionPermisson.Items.Clear();
                foreach (var item in _model.GetSections().Result)
                {
                    _view.comboBoxSectionPermisson.Items.Add(item.Name);
                }
                await Task.CompletedTask;
        }

        private void CreateDataGridEmployeePermisson()
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
