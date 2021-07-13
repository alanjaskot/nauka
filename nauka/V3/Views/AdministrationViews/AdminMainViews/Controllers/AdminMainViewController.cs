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
        private SectionComboBoxUC sectionComboBoxUC = new SectionComboBoxUC();
        private NewAbsenceUC newAbsenceUC = new NewAbsenceUC();

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
            
            #region  inicjalizacja user control
            employeesUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(employeesUC);

            permissionUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(permissionUC);

            menageVacationsUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(menageVacationsUC);

            vacationPermissionUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(vacationPermissionUC);

            sectionComboBoxUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(sectionComboBoxUC);

            newAbsenceUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(newAbsenceUC);

            menageSectionUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(menageSectionUC);

            #endregion  

            #region leftpanelUC
            _view.adminLeftPanelMenuuc1.buttonSection.Click += (object sender, EventArgs e) =>
            {
                SectionDisplayList();
                _view.panelMain.Controls["MenageSectionUC"].BringToFront();
            };

            _view.adminLeftPanelMenuuc1.buttonEmployees.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["EmployeesUC"].BringToFront();
                CreateDataGridEmployee();
                SectionDisplay();
            };

            _view.adminLeftPanelMenuuc1.buttonPermission.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["PermissionUC"].BringToFront();
                CreateDataGridEmployeePermisson();
                SectionDisplay();
            };

            _view.adminLeftPanelMenuuc1.buttonVacations.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["MenageVacationsUC"].BringToFront();
                CreateDataGridMenageVacation();
                SectionDisplay();
            };

            _view.adminLeftPanelMenuuc1.buttonVacationApplications.Click += (object sender, EventArgs e) =>
            {
                SectionDisplay();
                CreateDataGridVacationPermisson();
                _view.panelMain.Controls["VacationPermissionUC"].BringToFront();
            };

            _view.adminLeftPanelMenuuc1.buttonToEmployee.Click += (object sender, EventArgs e) =>
            {
                var currentEmployee = _model.Employee;
                var viewEmployee = new MainView();
                viewEmployee.SetObjectToEdit = currentEmployee;
                viewEmployee.Show();
                _view.Close();
                };

            #endregion

            #region   section menager functions

            menageSectionUC.buttonAdd.Click += (object sender, EventArgs e) =>
            {
                var newSection = new Section();
                var view = new SectionView();
                view.SetObjectToEdit = newSection;
                if (view.ShowDialog() == DialogResult.OK)
                {
                    var newSection2 = view.SetObjectToEdit;
                    _model.AddSection(newSection2);
                    SectionDisplay();
                }
            };

            menageSectionUC.buttonEdit.Click += (object sender, EventArgs e) =>
            {
                var currentSection = _model.GetSections().Where(s => s.Name == menageSectionUC.listViewSections.SelectedItems[0].Text)
                .FirstOrDefault();
                var view = new SectionView();
                view.SetObjectToEdit = currentSection;
                DeleteSection();
                if (view.ShowDialog() == DialogResult.OK)
                {

                }
            };

            menageSectionUC.buttonDelete.Click += (object sender, EventArgs e) =>
            {
                DeleteSection();
            };
            #endregion

            #region employeesUC

            employeesUC.buttonDisplayEmployees.Click += (object sender, EventArgs e) =>
            {
                DisplayEmployees();
            };

            employeesUC.buttonAdd.Click += (object sender, EventArgs e) =>
            {
                AddEmployee();
            };

            employeesUC.buttonEdit.Click += (object sender, EventArgs e) =>
            {
                EditEmployee();
            };

            employeesUC.buttonDelete.Click += (object sender, EventArgs e) =>
            {
                DeleteEmployee();
            };

            #endregion

            #region MenageVacation

            menageVacationsUC.buttonChooseSection.Click += (object sender, EventArgs e) =>
            {
                DisplayMenageVacation();
            };

            menageVacationsUC.buttonDelete.Click += (object sender, EventArgs e) =>
            {
                DeleteVacations();
            };

            menageVacationsUC.buttonNew.Click += (object sender, EventArgs e) =>
            {
                CreateDataGridEmployeeInAbsence();
                SectionDisplayList();
                DisplayDescriptionList();
                _view.panelMain.Controls["newAbsenceUC"].BringToFront();
            };

            #endregion

            #region NewAbsence

            newAbsenceUC.buttonSectionChoose.Click += (object sender, EventArgs e) =>
            {
                DisplayEmployeesInAbsence();
            };

            newAbsenceUC.buttonAdd.Click += (object sender, EventArgs e) =>
            {
                if (ValidateAbsence())
                {
                    AddAbsence();
                }

                if (!ValidateAbsence())
                    MessageBox.Show("Proszę wybrać pracownika i wypełnić wszystkie pola");
            };

            #endregion

            #region VacationPermisson

            vacationPermissionUC.buttonChooseSection.Click += (object sender, EventArgs e) =>
            {
                DisplayVacationPermisson();
            };

            vacationPermissionUC.buttonApprove.Click += (object sender, EventArgs e) =>
            {
                ApproveVacation();
            };

            vacationPermissionUC.buttonDenay.Click += (object sender, EventArgs e) =>
            {
                DenayVacation();
            };

            #endregion

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
        private void SectionDisplayList()
        {
            menageSectionUC.listViewSections.Items.Clear();
            
            foreach (var item in _model.GetSections())
            {
                menageSectionUC.listViewSections.Items.Add(item.Name);
            }
        }

        private void DeleteSection()
        {
            var deletedSection = _model.GetSections().Where(s => s.Name == menageSectionUC.listViewSections.SelectedItems[0].Text)
                .FirstOrDefault();
            
            _model.Section = deletedSection;
            _model.DeleteSection(deletedSection);
        }


        #endregion

        #region Employee functions
        private void SectionDisplay()
        {
            employeesUC.comboBoxSections.Items.Clear();
            vacationPermissionUC.comboBoxSections.Items.Clear();
            permissionUC.comboBoxSections.Items.Clear();
            menageVacationsUC.comboBoxSections.Items.Clear();
            newAbsenceUC.comboBoxSecitions.Items.Clear();
            foreach (var item in _model.GetSections())
            {
                employeesUC.comboBoxSections.Items.Add(item.Name);
                vacationPermissionUC.comboBoxSections.Items.Add(item.Name);
                permissionUC.comboBoxSections.Items.Add(item.Name);
                menageVacationsUC.comboBoxSections.Items.Add(item.Name);
                newAbsenceUC.comboBoxSecitions.Items.Add(item.Name);
            }
        }

        private void DisplayEmployees()
        {
            employeesUC.dataGridViewEmployees.Rows.Clear();
            int i = 1;
            var employeeList = _model.GetEmployees();
            foreach(var item in employeeList)
            {
                if((item.Section.Name == (string)employeesUC.comboBoxSections.SelectedItem) && (item.Section.Name != null))
                {
                    employeesUC.dataGridViewEmployees.Rows.Add(item.Id, i, item.Surname, item.Name);
                    i++;
                }
            }
        }

        private void AddEmployee()
        {
            var newEmployee = new Employee();
            var view = new RegisterView();
            view.SetObjectToEdit = newEmployee;
            view.DialogResult = DialogResult.OK;
        }

        private void EditEmployee()
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
            var detailDGV = employeesUC.dataGridViewEmployees;           

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

        #region MenageVacation functions

        private void DeleteVacations()
        {
            string idEmployee = menageVacationsUC.dataGridViewVacations
                [0, vacationPermissionUC.dataGridViewVacationApplications.CurrentRow.Index].Value.ToString();
            Guid idVacation = Guid.Parse(menageVacationsUC.dataGridViewVacations
                [7, vacationPermissionUC.dataGridViewVacationApplications.CurrentRow.Index].Value.ToString());

            int employeeIndex = _model.GetEmployees().FindIndex(e => e.Id == Guid.Parse(idEmployee));
            int vacationIndex = _model.GetEmployees()[employeeIndex].Vacation.FindIndex(v => v.Id == idVacation);
            _model.GetEmployees()[employeeIndex].Vacation.RemoveAt(vacationIndex);

            DisplayVacationPermisson();
        }

        private void DisplayMenageVacation()
        {
            menageVacationsUC.dataGridViewVacations.Rows.Clear();

            int i = 1;
            var employeeList = _model.GetEmployees().Where(e => e.Section.Name == (string)menageVacationsUC.comboBoxSections.SelectedItem);
            if (employeeList != null)
            {
                foreach (var itemEmployee in employeeList)
                {
                    if (itemEmployee.Vacation != null)
                    {
                        foreach (var item in itemEmployee.Vacation)
                        {
                            if (item.Approve == true)
                            {
                                menageVacationsUC.dataGridViewVacations.Rows.Add(itemEmployee.Id, i, itemEmployee.Surname, itemEmployee.Name, 
                                    item.Start.ToString("dd.MM.yyyy"), item.End.ToString("dd.MM.yyyy"), item.Description, item.Id, "Edytuj");
                                i++;
                            }
                        }
                    }
                }
            }
        }

        private void CreateDataGridMenageVacation()
        {

            var detailDGV = menageVacationsUC.dataGridViewVacations;

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
            dgvTextColumn.Visible = true;
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

            dgvTextColumn = new DataGridViewButtonColumn();
            dgvTextColumn.HeaderText = "Edycja";
            dgvTextColumn.Name = "Edit";
            dgvTextColumn.DataPropertyName = "Edit";
            dgvTextColumn.Width = 90;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);
        }

        #endregion

        #region NewAbsense Functions

        private void AddAbsence()
        {
            var idEmployee = Guid.Parse(newAbsenceUC.dataGridViewEmployees[0, newAbsenceUC.dataGridViewEmployees.CurrentRow.Index].Value.ToString());
            int index = _model.GetEmployees().FindIndex(i => i.Id == idEmployee);
            var employee = _model.GetEmployees()[index]; 
            var vacation = new Vacation
            {
                Id = Guid.NewGuid(),
                Start = newAbsenceUC.dateTimePickerStart.Value,
                End = newAbsenceUC.dateTimePickerEnd.Value,
                Description = newAbsenceUC.listViewDescription.SelectedItems[0].Text,
                Approve = true
            };
            employee.Vacation.Add(vacation);
            _model.AddVacation(employee);
        }

        private bool ValidateAbsence()
        {
            var result = true;

            if ((newAbsenceUC.dateTimePickerStart == null) || (newAbsenceUC.dateTimePickerEnd == null)
                || (newAbsenceUC.listViewDescription.SelectedItems == null))
                result = false;

            return result;
        }

        private void DisplayDescriptionList()
        {
            newAbsenceUC.listViewDescription.Items.Clear();
            foreach(var item in VacationDescriptionList.adminDescriptions)
            {
                newAbsenceUC.listViewDescription.Items.Add(item);
            }
        }

        private void DisplayEmployeesInAbsence()
        {
            newAbsenceUC.dataGridViewEmployees.Rows.Clear();
            int i = 1;
            var employeeList = _model.GetEmployees();
            foreach (var item in employeeList)
            {
                if ((item.Section.Name == (string)newAbsenceUC.comboBoxSecitions.SelectedItem) && (item.Section.Name != null))
                {
                    newAbsenceUC.dataGridViewEmployees.Rows.Add(item.Id, i, item.Surname, item.Name);
                    i++;
                }
            }
        }

        private void CreateDataGridEmployeeInAbsence()
        {
            var detailDGV = newAbsenceUC.dataGridViewEmployees;

            detailDGV.AllowUserToAddRows = false;
            detailDGV.AutoGenerateColumns = false;
            detailDGV.RowHeadersVisible = false;
            detailDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            detailDGV.Columns.Clear();
            detailDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var dgvTextColumn = default(DataGridViewColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Id.";
            dgvTextColumn.Name = "ID";
            dgvTextColumn.DataPropertyName = "Id";
            dgvTextColumn.Width = 45;
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
            employee.VacationDays.Add(new VacationDay { VacationDays = daysOfVacation });
            _model.AddVacation(employee);
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
