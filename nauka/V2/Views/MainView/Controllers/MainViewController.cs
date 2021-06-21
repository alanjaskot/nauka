using nauka.V2.Base;
using nauka.V2.Models;
using nauka.V2.Services.Employee;
using nauka.V2.Services.Sections;
using nauka.V2.Views.MainView.Models;
using nauka.V2.Views.MainView.Views;
using nauka.V2.Views.Vacations.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V2.Views.MainView.Controllers
{
    public class MainViewController : BaseController, IMainViewController
    {
        private readonly MainViewView _mainView;
        private MainViewModel _mainViewModel;
        private int indexNumber = -1;
        private List<Employee> _employees;
        private Timer _timeTimerUpdater;
        private bool logged = false;

        public MainViewController(MainViewView mainView)
        {
            this._mainView = mainView;

            InitTimeUpdater();

            Task.Run(async () =>
            {
                await InitViewModel();
                await InitView();
            }).Wait();
        }

        private void InitTimeUpdater()
        {
            _mainView.labelTimer.Text = DateTime.Now.ToLongTimeString();

            _timeTimerUpdater = new System.Windows.Forms.Timer();
            _timeTimerUpdater.Interval = 1000;
            _timeTimerUpdater.Tick += (object sender, EventArgs e) =>
            {
                _mainView.labelTimer.Text = DateTime.Now.ToLongTimeString();
            };
            _timeTimerUpdater.Enabled = true;
            _timeTimerUpdater.Start();
        }
        private async Task InitView()
        {

            #region Init users DGV
            var detailDGV = _mainView.dataGridViewUsers;
            
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
            dgvTextColumn.DataPropertyName = "Id";
            dgvTextColumn.Width = 50;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = false;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Nazwisko";
            dgvTextColumn.Name = "EmployeeSurname";
            dgvTextColumn.DataPropertyName = "Surname";
            //dgvTextColumn.Width = 80;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Imie";
            dgvTextColumn.Name = "EmployeeName";
            dgvTextColumn.DataPropertyName = "Name";
            //dgvTextColumn.Width = 80;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Dział";
            dgvTextColumn.Name = "SectionName";
            dgvTextColumn.DataPropertyName = "GetSectionName";
            //dgvTextColumn.Width = 80;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            #endregion

            _mainView.buttonInfo.Click += (object sender, EventArgs e) =>
            {
                MessageBox.Show("Asynchroniczne działanie", "Info");
            };

            _mainView.buttonUserAdd.Click += (object sender, EventArgs e) =>
            {
                if (!logged)
                {
                    NotLogged();
                }
                else
                {
                    AddNewUser();
                } 
            };

            _mainView.buttonUserEdit.Click += (object sender, EventArgs e) =>
            {
                if (!logged)
                {
                    NotLogged();
                }
                else
                {
                    EditUser();
                }
            };

            _mainView.buttonUserRemove.Click += (object sender, EventArgs e) =>
            {
                if (!logged)
                {
                    NotLogged();
                }
                else
                {
                    RemoveUser();
                }
            };

            _mainView.buttonVacations.Click += (object sender, EventArgs e) =>
            {
                if (!logged)
                {
                    NotLogged();
                }
                else
                {
                    VacationEditor();
                }
            };

            _mainView.buttonLogin.Click += (object sender, EventArgs e) =>
            {
                LoginIn();
            };

            _mainView.buttonLogout.Click += (object sender, EventArgs e) =>
            {
                Logout();
            };

            _mainView.Load += (object sender, EventArgs e) =>
            {
                RefreshView();
            };

            await Task.CompletedTask;
        }

        private void VacationEditor()
        {
            var vacationOfEmpoloyee = _employees[_mainView.dataGridViewUsers.CurrentRow.Index].Vacation;
            var view = new VacationView();
            view.SetObjectToEdit = vacationOfEmpoloyee;
            if(view.ShowDialog() == DialogResult.OK)
            {
                RefreshView();
            }
        }

        private void EditUser() 
        {
            var editedEmployee = _employees[_mainView.dataGridViewUsers.CurrentRow.Index];
            var view = new Employees.Views.EmployeeView();
            view.SetObjectToEdit = editedEmployee;
            if (indexNumber == _mainView.dataGridViewUsers.CurrentRow.Index)
            {
                if (view.ShowDialog() == DialogResult.OK)
                {
                    var selectedEmlpoyee2 = view.SetObjectToEdit;
                    RefreshView();
                }
            }
            else
            {
                MessageBox.Show("Nie można edytować innego użytkownika");
            }
        }

        private void AddNewUser()
        {
            var newEmployee = new Employee();
            var view = new Employees.Views.EmployeeView();
            view.SetObjectToEdit = newEmployee;

            // gdy result jest ok to zapisuje
            if (view.ShowDialog() == DialogResult.OK)
            {
                var newEmployee2 = view.SetObjectToEdit;

                Task.Run(async () =>
                {
                    await _mainViewModel.Add(newEmployee2);

                }).Wait();

                RefreshView();
            }
        }

        private void RemoveUser()
        {
            var employeeToRemove = _employees[_mainView.dataGridViewUsers.CurrentRow.Index];
            if(indexNumber == _mainView.dataGridViewUsers.CurrentRow.Index)
            {
                const string message = "Czy na pewno chcesz usunąć pracownika?";
                const string caption = "Usunięcie pracownika";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _employees.Remove(employeeToRemove);
                }
            }
            else
            {
                MessageBox.Show("Nie można usunąć innego użytkownika");
            }
            RefreshView();
        }

        private void LoginIn()
        {
            var employeeToLogin = _employees[_mainView.dataGridViewUsers.CurrentRow.Index];
            var view = new Logins.Views.LoginView();
            view.SetObjectToEdit = employeeToLogin;
            indexNumber = _mainView.dataGridViewUsers.CurrentRow.Index;
            if (view.ShowDialog() == DialogResult.OK)
            {
                Logged();
            }
        }

        private void Logout()
        {
            logged = false;
            _mainView.buttonUserAdd.Enabled = false;
            _mainView.buttonUserEdit.Enabled = false;
            _mainView.buttonUserRemove.Enabled = false;
            _mainView.buttonLogin.Enabled = true;

        }

        public void RefreshView()
        {
            _mainView.Cursor = Cursors.WaitCursor;
            
            try
            {
                Task.Run(async () =>
                {
                    _employees = await _mainViewModel.GetEmployees();
                }).Wait();
            }
            catch 
            {
                throw;
            }

            _mainView.dataGridViewUsers.DataSource = null; // ale to zle dziala,musze sobie przypomniec
            _mainView.dataGridViewUsers.DataSource = _employees;
            _mainView.dataGridViewUsers.Refresh();

            _mainView.Cursor = Cursors.Default;
            
        }

        private async Task InitViewModel()
        {
            _mainViewModel = new MainViewModel();
            
            await Task.CompletedTask;
        }

        private void NotLogged()
        {
            MessageBox.Show("Proszę się zalogować!");
        }

        private void Logged()
        {
            logged = true;
            _mainView.buttonUserAdd.Enabled = true;
            _mainView.buttonUserEdit.Enabled = true;
            _mainView.buttonUserRemove.Enabled = true;
            _mainView.buttonLogin.Enabled = false;
        }

    }
}
