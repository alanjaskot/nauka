using nauka.V2.Models;
using nauka.V2.Views.Employees.Models;
using nauka.V2.Views.Employees.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V2.Views.Employees.Controllers
{
    public class EmpleyeController
    {
        private readonly EmployeeView _view;
        private EmployeModel _model;
        private V2.Services.Sections.SectionService _sectionService;

        public EmpleyeController(EmployeeView employeeView)
        {
            _view= employeeView;
            _sectionService = new Services.Sections.SectionService();

            Task.Run(async () =>
            {
                await InitViewModel();
                await InitView();
            }).Wait();
        }

        private async Task InitView()
        {
            _view.buttonCancel.Click += (object sender, EventArgs e) =>
            {
                _view.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            };
            _view.buttonOk.Click += (object sender, EventArgs e) =>
            {
                _view.DialogResult = System.Windows.Forms.DialogResult.OK;
            };

            _view.Load += _view_Load;

            await Task.CompletedTask;
        }

        private void _view_Load(object sender, EventArgs e)
        {
            RefreshView();

            DisplaySection();
        }

        private async Task InitViewModel()
        {

            if (_model == null)
            {
                _model = new EmployeModel();
            } else 


            await Task.CompletedTask;
        }

        public Employee SetEployee
        {
            get
            {
                UpdateModel();

                return _model.Employee;
            }
            set
            {
                if (value == null)
                    return;

                _model.Employee = value;

                RefreshView();
            }
        }

        private void UpdateModel()
        {
            _model.Employee.Name = _view.textBoxName.Text;
            _model.Employee.Surname = _view.textBoxSurname.Text;
            _model.Employee.LoginName = _view.textBoxLogin.Text ;
            _model.Employee.Password = _view.textBoxPassword.Text ;
            _model.Employee.Section.Name = _view.comboBoxSection.GetItemText(_view.comboBoxSection.SelectedText);


        }

        private void RefreshView()
        {
            _view.textBoxName.Text = _model.Employee.Name;
            _view.textBoxSurname.Text = _model.Employee.Surname;
            _view.textBoxLogin.Text = _model.Employee.LoginName;
            _view.textBoxPassword.Text = _model.Employee.Password;
            if(_model.Employee.Section != null)
                _view.comboBoxSection.SelectedText = _model.Employee.Section.Name;
        }

        private async Task DisplaySection()
        {
            _view.comboBoxSection.SelectedText = " --wybierz-- ";


            List<Section> newSectionList = await _sectionService.GetSections();

            foreach (var item in newSectionList)
            {
                _view.comboBoxSection.Items.Add(item.Name);
            }

        }

    }
}
