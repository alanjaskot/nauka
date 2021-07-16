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
                    RefreshModel();
                    _view.DialogResult = DialogResult.OK;
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
                if(_model.Employee != null)
                    RefreshView();
                
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

        private void RefreshView()
        {
            if(_model.Employee != null)
            {
                GetSex();
                GetSections();
                _view.textBoxName.Text = _model.Employee.Name;
                _view.textBoxSurname.Text = _model.Employee.Surname;
                _view.textBoxUsername.Text = _model.Employee.Username;
                _view.textBoxPassword.Text = _model.Employee.Password;
                _view.textBoxEmail.Text = _model.Employee.Email;
                var appsetting = _model.Employee.AppSettings.Where(ap => ap.Year.ToString("yyyy").Equals(DateTime.Now.ToString("yyyy"))).FirstOrDefault();
                _view.textBoxAppSetting.Text = appsetting.AvaibleVacationDays.ToString();
                if (_model.Employee.Sex == 'M')
                    _view.comboBoxSex.SelectedIndex = 1;
                if (_model.Employee.Sex == 'K')
                    _view.comboBoxSex.SelectedIndex = 0;

                _view.comboBoxSection.SelectedItem = _model.Employee.Section.Name;
            }

        }

        private void RefreshModel()
        {
            var employee = new Employee();

            var vacation = employee.AppSettings.Where(a => a.Year.ToString("yyyy") == (DateTime.Now.ToString("yyyy")));

            _model.Employee.Name = _view.textBoxName.Text;
            _model.Employee.Surname = _view.textBoxSurname.Text;
            _model.Employee.Username = _view.textBoxUsername.Text;
            _model.Employee.Password = _view.textBoxPassword.Text;
            _model.Employee.Email = _view.textBoxEmail.Text;
            _model.Employee.AppSettings.Add( new AppSettings { AvaibleVacationDays = byte.Parse(_view.textBoxAppSetting.Text), Year = DateTime.Now });
            _model.Employee.EmployeePermisson = false;
            _model.Employee.VacationPermisson = false;
            if (_view.comboBoxSex.SelectedIndex == 1)
                _model.Employee.Sex = 'M';
            if (_view.comboBoxSex.SelectedIndex == 0)
                _model.Employee.Sex = 'K';

            var sectionList = _model.GetSections();
            var selectedSection = sectionList.Where(s => s.Name == (string)_view.comboBoxSection.SelectedItem).FirstOrDefault();
            _model.Employee.Section = selectedSection;
            _model.Employee.Vacation = new List<Vacation>();
            _model.Employee.VacationDays = new List<VacationDays>();          
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
