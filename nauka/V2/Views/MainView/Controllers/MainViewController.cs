using nauka.V2.Base;
using nauka.V2.Models;
using nauka.V2.Services.Employee;
using nauka.V2.Services.Sections;
using nauka.V2.Views.MainView.Models;
using nauka.V2.Views.MainView.View;
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

        private EmployeeService _employeeService;

        private List<Employee> _employees;
        private Timer _timeTimerUpdater;

        public MainViewController(MainViewView mainView)
        {
            this._mainView = mainView;

            InitTimeUpdater();

            Task.Run(async () =>
            {
                _employeeService = new EmployeeService();

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

            await Task.CompletedTask;
        }

        public async Task RefreshView()
        {
            if (_mainView.InvokeRequired)
            {
                _mainView.Invoke(new MethodInvoker(() =>
                {
                    _mainView.Cursor = Cursors.WaitCursor;
                }));
            }

            try
            {
                _employees = await _mainViewModel.GetEmployees();
            }
            catch 
            {
                throw;
            }

            if (_mainView.InvokeRequired)
            {
                _mainView.Invoke(new MethodInvoker(() =>
                {
                    _mainView.dataGridViewUsers.DataSource = _employees;
                    
                    _mainView.Cursor = Cursors.Default;
                }));
            }            
        }

        private async Task InitViewModel()
        {
            _mainViewModel = new MainViewModel();
            
            await Task.CompletedTask;
        }
    }
}
