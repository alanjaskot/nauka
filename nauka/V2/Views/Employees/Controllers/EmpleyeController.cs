using nauka.V2.Models;
using nauka.V2.Views.Employees.Models;
using nauka.V2.Views.Employees.Views;
using System;
using System.Collections.Generic;
using System.Linq;
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
                if (!ValidateModel())
                    return;

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

        private bool ValidateModel()
        {
            var result = true;

            if (result)
            {
                if (_view.comboBoxSection.SelectedIndex == 0)
                {
                    MessageBox.Show("Wybierz sekcje");
                    result = false;
                }
            }

            if (result)
            {
                var sectionList = _sectionService.GetSections().Result;

                var sectionText = (string)_view.comboBoxSection.SelectedItem;

                var section = sectionList.Where(p => p.Name == sectionText).FirstOrDefault();

                if (section == null)
                {
                    MessageBox.Show("Błąd sekcji");
                    result = false;
                }
            }

            return result;
        }


        private void UpdateModel()
        {   
            _model.Employee.Name = _view.textBoxName.Text;
            _model.Employee.Surname = _view.textBoxSurname.Text;
            _model.Employee.LoginName = _view.textBoxLogin.Text ;
            _model.Employee.Password = _view.textBoxPassword.Text ;

            var  sectionList = _sectionService.GetSections().Result;

            var section = sectionList.Where(p => p.Name == (string)_view.comboBoxSection.SelectedItem).First();

            _model.Employee.Section = section;
            // to jest zapytanie przez linq 
            // masaz liste, na niej robisz zapytanie jak na sql, skladnia podobna.

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

        private void DisplaySection()
        {
            _view.comboBoxSection.Items.Clear();
            _view.comboBoxSection.Items.Add("-- wybierz --");

            var sectionList = _sectionService.GetSections().Result;

            foreach (var item in sectionList)
            {
                _view.comboBoxSection.Items.Add(item.Name);
            }

            _view.comboBoxSection.SelectedIndex = 0;
        }

    }
}
