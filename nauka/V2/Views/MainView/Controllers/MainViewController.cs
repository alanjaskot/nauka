using nauka.V2.Base;
using nauka.V2.Models;
using nauka.V2.Services.Employee;
using nauka.V2.Services.Sections;
using nauka.V2.Views.MainView.Models;
using nauka.V2.Views.MainView.Views;
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

        private List<Employee> _employees;
        private Timer _timeTimerUpdater;

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
                AddNewUser();
            };

            _mainView.buttonUserEdit.Click += (object sender, EventArgs e) =>
            {
               EditUser();
            };

            await Task.CompletedTask;
        }

        private void EditUser() 
        {
            // tu dodac edycje
            
            var editedEmployee = _employees[_mainView.dataGridViewUsers.CurrentRow.Index];
            var view = new Employees.Views.EmployeeView();
            view.SetObjectToEdit = editedEmployee;

            if (view.ShowDialog() == DialogResult.OK)
            {
                var selectedEmlpoyee2 = view.SetObjectToEdit;

                Task.Run(async () =>
                {
                   

                }).Wait();

                RefreshView();
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

    }
}
