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

            // tu robisz osobny watek 
            // robisz go asychrnonicze
            // musiz poczekac az sie zrobi czyli na konwu .Wait
            // jaktego nie ma to wotek startuje i sobie sam mysli 
            // ale ty chcesz tego uzyc wczesniej niz wotek to zrobil :) 

            //ok, czyli musi byc wait, zeby skonczyly sie ladowac watki?
            // to zalezy, w tym przyadku tak, bo on musi zrobic to co robi, 
            // ale niekiedy  w asysnc await mielisz dane, wtedy gui zyje, a dane sie miela, wtedy nie ma wait
            // zalezy od konkrentego przypadku
            // tu robilesz obiekt ktory dalej byl potrzebny i trzeba czekac 

            //ok, jak ponaprawiam, co trzeba i bedzie dobrze dzialac, to podpiac wszystko do bazy danych?
            // no mozesz zrobic, a robisz przez ef core czy reczenie 
            //chcialem prze ef core
            // ok, zrob, zoabczymy co wyjdzie 
            // popracuje jeszcze nad gui 
            // bo malo czytalene, bardzo skupione to jest 
            // masz caly erran :) 
            //ok powieksze wszystko i rozloze bardziej na caly ekran :)

            // moze nie byc caly ekran ale wieksze, ty masz inne perspektywe bo masz za duzy tv :) 
            // popracuj z dokowanie, do lwej pracwej, tak ze zwiekszasz okno i to sie skaluje,
            // albo daj panel i na panu ukladaj 
            // a panel zawsze na stroku ekranyu czyli formy 
            // ok :). Narazie to jest wsadzone w te kilka paneli i na glownym robie, ale pozmieniam to w takim razie

            // musisz pamietac ze mozesz miec kilka apek, i jak wrocisz do tego za pol roku to musisz wiedziec jak to jest zrobione 
             // ;) 
             //ok :)
            Task.Run(async () =>
            {
                await InitViewModel();
                await InitView();
            }).Wait();
        }

        private async Task InitView()
        {
            _view.buttonOk.Click += (object sender, EventArgs e) =>
            {
                RefreshView();
                RefreshModel();
                if (Validate())
                {
                    
                    _view.DialogResult = DialogResult.OK;
                    _view.Close();
                }
                else
                    MessageBox.Show("Proszę wypełnić wszystkie pola");
            };

            _view.buttonCancel.Click += (object sender, EventArgs e) =>
            {
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
            _model = new RegisterModel();

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
                _view.textBoxAppSetting.Text = _model.Employee.AppSettings.AvaibleVacationDays.ToString();
                if (_model.Employee.Sex == 'M')
                    _view.comboBoxSex.SelectedIndex = 1;
                if (_model.Employee.Sex == 'K')
                    _view.comboBoxSex.SelectedIndex = 0;

                _view.comboBoxSection.SelectedItem = _model.Employee.Section.Name;
            }
        }

        private void RefreshModel()
        {
            GetSex();
            GetSections();
            _model.Employee.Name = _view.textBoxName.Text;
            _model.Employee.Surname = _view.textBoxSurname.Text;
            _model.Employee.Username = _view.textBoxUsername.Text;
            _model.Employee.Password = _view.textBoxPassword.Text;
            _model.Employee.Email = _view.textBoxEmail.Text;
            if (_model.Employee.AppSettings == null)
                _model.Employee.AppSettings = new AppSettings { AvaibleVacationDays = byte.Parse(_view.textBoxAppSetting.Text) };
            else
            {
                try
                {
                    _model.Employee.AppSettings.AvaibleVacationDays = byte.Parse(_view.textBoxAppSetting.Text);
                }
                catch
                {
                    throw;
                }
            }
                
            _model.Employee.EmployeePermisson = false;
            _model.Employee.VacationPermisson = false;
            if (_view.comboBoxSex.SelectedIndex == 1)
                _model.Employee.Sex = 'M';
            if (_view.comboBoxSex.SelectedIndex == 0)
                _model.Employee.Sex = 'K';

            var sectionList = _model.GetSections();
            var selectedSection = sectionList.Result.Where(s => s.Name == (string)_view.comboBoxSection.SelectedItem).FirstOrDefault();
            _model.Employee.Section = selectedSection;
            /*if(_model.Employee.VacationId == null)
                _model.Employee.Vacations = new List<Guid>();

            if(_model.Employee.VacationDaysId == null)
                _model.Employee.VacationDays = new List<Guid>();*/          
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
            var sectionList = _model.GetSections().Result;
            foreach (var item in sectionList)
            {
                _view.comboBoxSection.Items.Add(item.Name);
            }
        }

        private bool Validate()
        {
            var result = true;
            if ((_view.textBoxName.Text == null) || (_view.textBoxSurname.Text == null)
                || (_view.textBoxUsername.Text == null) || (_view.textBoxPassword.Text == null)
                || (_view.textBoxEmail == null) || (_view.textBoxAppSetting.Text == null))              
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
