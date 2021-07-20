using nauka.V3.Models;
using nauka.V3.Resources;
using nauka.V3.Views.AdministrationViews.NewAbsenceViews.Models;
using nauka.V3.Views.AdministrationViews.NewAbsenceViews.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V3.Views.AdministrationViews.NewAbsenceViews.Controllers
{
    public class NewAbsenceController
    {
        private readonly NewAbsenceView _view;
        private NewAbsenceModel _model;

        public NewAbsenceController(NewAbsenceView view)
        {
            _view = view;

            Task.Run(async () =>
            {
                await InitViewModel();
                await InitView();
            }).Wait();
        }

        private async Task InitViewModel()
        {
            if (_model == null)
                _model = new NewAbsenceModel();

            await Task.CompletedTask;
        }

        private async Task InitView()
        {
            ShowSection();
            CreateDataGridViewEmployees();
            ShowDescriptionList();

            _view.buttonSectionChoose.Click += (object sender, EventArgs e) =>
            {
                if(_view.comboBoxSecitions.SelectedIndex > -1)
                    ShowEmployees();
            };

            _view.buttonAdd.Click += (object sender, EventArgs e) =>
            {
                if (ValidateDate())
                {
                    if (Validate())
                    {
                        AddAbsence();
                        _view.DialogResult = DialogResult.OK;
                        _view.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wszystkie pola nie są uzupełnione");
                    }
                } 
                else
                {
                    MessageBox.Show("Podana data pokrywa się z inną nieobecnością pracowika");
                }

            };

            _view.buttonCancel.Click += (object sender, EventArgs e) =>
            {
                _view.DialogResult = DialogResult.Cancel;
                _view.Close();
            };

            await Task.CompletedTask;
        }

        private bool Validate()
        {
            var result = true;

            //if(_view.dataGridViewEmployees.CurrentRow.Index > -1)
             //   result = false;

            if(_view.dateTimePickerStart.Value == null)
                result = false;

            if (_view.dateTimePickerEnd.Value == null)
                result = false;

            if (_view.listViewDescription.SelectedItems == null)
                result = false;

            return result;
        }

        private bool ValidateDate()
        {
            Guid idEmployee = Guid.Parse(_view.dataGridViewEmployees[0, _view.dataGridViewEmployees.CurrentRow.Index].Value.ToString());
            var employee = _model.GetEmployees().Result.Where(e => e.Id == idEmployee).FirstOrDefault();
            var result = true;
            foreach(var itemVacEmp in _model.GetVacation_Employees().Result)
            {
                if(itemVacEmp.EmployeeId == idEmployee)
                {
                    foreach (var item in _model.GetVacations().Result)
                    {
                        if ((itemVacEmp.VacationId == item.Id) && (item.Approve == true))
                        {
                            if ((_view.dateTimePickerStart.Value >= item.Start) && (_view.dateTimePickerStart.Value <= item.End))
                                result = false;

                            if ((_view.dateTimePickerEnd.Value >= item.Start) && (_view.dateTimePickerEnd.Value <= item.End))
                                result = false;
                            if ((_view.dateTimePickerStart.Value < item.Start) && (_view.dateTimePickerEnd.Value > item.End))
                            {
                                result = false;
                            }
                        }
                    }
                }
                
            }
            return result;
        }

        private async Task AddAbsence()
        {
            Guid idEmployee = Guid.Parse(_view.dataGridViewEmployees[0, _view.dataGridViewEmployees.CurrentRow.Index].Value.ToString());
            var employee = _model.GetEmployees().Result.Where(e => e.Id == idEmployee).FirstOrDefault();
            var newVacation = new Vacation
            {
                Id = Guid.NewGuid(),
                Start = _view.dateTimePickerStart.Value,
                End = _view.dateTimePickerEnd.Value,
                Approve = true,
                Description = _view.listViewDescription.SelectedItems[0].Text
            };
            var vacation_Employee = new Vacation_Employee
            {
                Id = Guid.NewGuid(),
                EmployeeId = idEmployee,
                VacationId = newVacation.Id
            };

            employee.Vacation_Employees.Add(vacation_Employee);
                      
            await _model.AddVacation(newVacation);
            await _model.AddVacation_Employee(vacation_Employee);
            await _model.UpdateEmployee(idEmployee, employee);

        }

        private void ShowDescriptionList()
        {
            _view.listViewDescription.Items.Clear();
            foreach(var item in VacationDescriptionList.adminDescriptions)
            {
                _view.listViewDescription.Items.Add(item);
            }
        }

        private void ShowEmployees()
        {
            _view.dataGridViewEmployees.Rows.Clear();
            string sectionName = _view.comboBoxSecitions.SelectedItem.ToString();
            int i = 1;
            if(_model.GetEmployees() != null)
            {
                foreach (var item in _model.GetEmployees().Result.Where(e => e.Section.Name == sectionName))
                {
                    _view.dataGridViewEmployees.Rows.Add(item.Id, i, item.Surname, item.Name);
                    i++;
                }
            }
            
        }

        private void CreateDataGridViewEmployees()
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
            dgvTextColumn.HeaderText = "Id.";
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

        private void ShowSection()
        {
            _view.comboBoxSecitions.Items.Clear();
            foreach(var item in _model.GetSections().Result)
            {
                _view.comboBoxSecitions.Items.Add(item.Name);
            }
        }

        public Employee SetEmployee
        {
            get
            {
                return _model.Employee;
            }
            set
            {
                _model.Employee = value;
            }
        }
    }
}
