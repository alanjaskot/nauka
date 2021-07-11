using nauka.V3.Models;
using nauka.V3.Views.AdministrationViews.RegisterVIews.Models;
using nauka.V3.Views.AdministrationViews.RegisterVIews.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V3.Views.AdministrationViews.RegisterVIews.Controllers
{
    class RegisterController
    {
        private readonly RegisterView _view;
        private RegisterModel _model;

        public RegisterController(RegisterView registerView)
        {
            _view = registerView;

            Task.Run(async () =>
            {
                await InitViewModel();
                await InitView();
            });
        }

        private async Task InitView()
        {
            _view.buttonOk.Click += (object sender, EventArgs e) =>
            {              
                if (Validate())
                {
                    Add();
                    _view.Close();
                }
                else
                    MessageBox.Show("Proszę wypełnić wszystkie pola");
            };

            _view.buttonCancel.Click += (object sender, EventArgs e) =>
            {
                if(_view.DialogResult == DialogResult.Cancel)
                    _view.Close();
            };

            _view.Load += (object sender, EventArgs e) =>
            {
                GetSex();
                GetSections();
            };

            await Task.CompletedTask;
        }

        private async Task InitViewModel()
        {
            if (_model == null)
            {
                _model = new RegisterModel();
            }

            await Task.CompletedTask;
        }

        private void Add()
        {
            var employee = new Employee();
            employee.Name = _view.textBoxName.Text;
            employee.Surname = _view.textBoxSurname.Text;
            employee.Username = _view.textBoxUsername.Text;
            employee.Password = _view.textBoxPassword.Text;
            employee.Email = _view.textBoxEmail.Text;
            employee.AppSettings.AvaibleVacationDays = long.Parse(_view.textBoxAppSetting.Text);
            employee.EmployeePermisson = false;
            employee.VacationPermisson = false;
            if (_view.comboBoxSex.SelectedIndex == 1)
                employee.Sex = 'M';
            if (_view.comboBoxSex.SelectedIndex == 0)
                employee.Sex = 'K';

            var sectionList = _model.GetSections();
            var selectedSection = sectionList.Where(s => s.Name == (string)_view.comboBoxSection.SelectedItem).FirstOrDefault();
            employee.Section = selectedSection;
            employee.Vacation = new List<Vacation>();
            employee.VacationDays = new List<VacationDay>();
            _model.Add(employee);
        }

        private void GetSex()
        {
            _view.comboBoxSex.Items.Clear();
            _view.comboBoxSex.Items.Add("kobieta");
            _view.comboBoxSex.Items.Add("mężczyzna");
        }

        private void GetSections()
        {
            _view.comboBoxSection.Items.Clear();
            var sectionList = _model.GetSections();
            foreach (var item in sectionList)
            {
                _view.comboBoxSection.Items.Add(item.Name);
            }
        }

        private bool Validate()
        {
            var result = true;
            if ((_view.textBoxName == null) || (_view.textBoxSurname == null)
                || (_view.textBoxUsername == null) || (_view.textBoxPassword == null)
                || (_view.textBoxEmail == null) || (_view.comboBoxSection.SelectedItem == null)
                || (_view.comboBoxSex.SelectedItem == null) || (_view.textBoxAppSetting == null))              
            {
                result = false;
            }

            return result;
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
