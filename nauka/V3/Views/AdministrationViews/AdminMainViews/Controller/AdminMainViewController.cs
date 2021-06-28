using nauka.V3.Models;
using nauka.V3.Views.AdministrationViews.AdminMainViews.Models;
using nauka.V3.Views.AdministrationViews.AdminMainViews.Views;
using nauka.V3.Views.AdministrationViews.UsereControls;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using nauka.V3.Views.SectionViews.Views;
using System.Linq;

namespace nauka.V3.Views.AdministrationViews.AdminMainViews.Controller
{
    class AdminMainViewController
    {
        private readonly AdminMainView _view;
        private AdminMainViewModel _model;

        private EmployeesUC employeesUC = new EmployeesUC();
        private PermissionUC permissionUC = new PermissionUC();
        private MenageVacationsUC menageVacationsUC = new MenageVacationsUC();
        private VacationPermissionUC vacationPermissionUC = new VacationPermissionUC();
        private MenageSectionUC menageSectionUC = new MenageSectionUC();

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
            #region  //inicjalizacja user control
            employeesUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(employeesUC);

            permissionUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(permissionUC);

            menageVacationsUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(menageVacationsUC);

            vacationPermissionUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(vacationPermissionUC);

            #endregion  

            #region //leftpanel UC
            //leftpanel buttons
            _view.adminLeftPanelMenuuc1.buttonSection.Click += (object sender, EventArgs e) =>
            {
                SectionDisplay();
                _view.panelMain.Controls["MenageSectionUC"].BringToFront();
            };

            _view.adminLeftPanelMenuuc1.buttonEmployees.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["EmployeesUC"].BringToFront();
                SectionDisplayInEmployee();
             };

            _view.adminLeftPanelMenuuc1.buttonPermission.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["PermissionUC"].BringToFront();
            };

            _view.adminLeftPanelMenuuc1.buttonVacations.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["MenageVacationsUC"].BringToFront();
            };

            _view.adminLeftPanelMenuuc1.buttonVacationApplications.Click += (object sender, EventArgs e) =>
            {
                _view.panelMain.Controls["VacationPermissionUC"].BringToFront();
            };

            #endregion

            #region   //section menager functions

            menageSectionUC.buttonAdd.Click += (object sender, EventArgs e) =>
            {
                SectionAddView sectionAddView = new SectionAddView();
                sectionAddView.Show();
            };

            menageSectionUC.buttonEdit.Click += (object sender, EventArgs e) =>
            {
                //var currentSection = menageSectionUC.listViewSections.Se;
                var view = new SectionAddView();
                //view.SetObjectToEdit = currentSection;
            };

            menageSectionUC.buttonDelete.Click += (object sender, EventArgs e) =>
            {
                
                _model.Delete(_model.GetSections()[1]);
                SectionDisplay();
            };
            #endregion

            _view.buttonOK.Click += (object sender, EventArgs e) => 
            {
                var result = MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Wyjście", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };

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

            menageSectionUC.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(menageSectionUC);
            SectionDisplay();
        }

        private void SectionDisplay()
        {
            menageSectionUC.listViewSections.Items.Clear();
            
            foreach (var item in _model.GetSections())
            {
                menageSectionUC.listViewSections.Items.Add(item.Name);
            }
        }

        #region //functions for leftpanelUC
        private void SectionDisplayInEmployee()
        {
            foreach(var item in _model.GetSections())
            {
                employeesUC.comboBoxSections.Items.Add(item.Name);
            }

            /*employeesUC.comboBoxSections.SelectedIndexChanged += (object sender, EventArgs e)
                {
            }*/
        }

        private void DisplayEmployees(string selectedSection)
        {
            int i = 1;//
            CreateDataGridEmployee();           
            foreach (var item in _model.GetEmployees().Where(e => e.Section.Name == selectedSection))
            {
                employeesUC.dataGridViewEmployees.Rows.Add(i, item.Surname, item.Name);
                i++;
            }
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
            dgvTextColumn.HeaderText = "ID";
            dgvTextColumn.Name = "ID";
            dgvTextColumn.DataPropertyName = "Id";
            dgvTextColumn.Width = 150;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTextColumn.Visible = false;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Nazwisko";
            dgvTextColumn.Name = "EmployeeSurname";
            dgvTextColumn.DataPropertyName = "Surname";
            dgvTextColumn.Width = 150;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "Imie";
            dgvTextColumn.Name = "EmployeeName";
            dgvTextColumn.DataPropertyName = "Name";
            dgvTextColumn.Width = 150;
            dgvTextColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
