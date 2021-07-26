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
        private NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

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
            InitLists();
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
                _view.DialogResult = DialogResult.Cancel;
            };

            _view.Load += (object sender, EventArgs e) =>
            {
                RefreshView();
            };

            await Task.CompletedTask;
        }

        private async Task InitViewModel()
        {
            _model = new RegisterModel();

            await Task.CompletedTask;
        }

        private void InitLists()
        {
            GetSex();
            Task.Run(async () => await GetSectionsList());
        }

        private void RefreshView()
        {
            try
            {
                if (_model.Employee != null)
                {
                    _view.textBoxName.Text = _model.Employee.Name;
                    _view.textBoxSurname.Text = _model.Employee.Surname;
                    _view.textBoxUsername.Text = _model.Employee.Username;
                    _view.textBoxPassword.Text = _model.Employee.Password;
                    _view.textBoxEmail.Text = _model.Employee.Email;
                    _view.textBoxYearsOfExperience.Text = _model.Employee.GetYearsOfExpirence().ToString();
                    if(_model.Employee.DateOfHire > DateTime.MinValue && _model.Employee.DateOfHire < DateTime.MinValue)
                        _view.dateTimePickerHireDate.Value = _model.Employee.DateOfHire;
                    if (_model.Employee.Sex == 'M')
                        _view.comboBoxSex.SelectedIndex = 2;
                    if (_model.Employee.Sex == 'K')
                        _view.comboBoxSex.SelectedIndex = 1;
                    
                    if (_model.Employee.SectionId != Guid.Empty)
                    {
                        var section = _model.GetSections().Result.Where(s => s.Id == _model.Employee.SectionId).FirstOrDefault();
                        _view.comboBoxSection.SelectedItem = section.Name;
                    }
                        
                }
            }
            catch
            {
                throw;
            }
        }

        private void RefreshModel()
        {
            try
            {
                char sex = 'a';
                int sexIndex = _view.comboBoxSex.SelectedIndex;
                if (sexIndex == 2)
                    sex = 'M';
                if (sexIndex == 1)
                    sex = 'K';

                var _employee = (Employee)_model.Employee.Clone();

                var sectionList = _model.GetSections();
                var selectedSection = sectionList.Result.Where(s => s.Name == (string)_view.comboBoxSection.SelectedItem).FirstOrDefault();
                byte extraDays = 0;
                try
                {
                    extraDays = byte.Parse(_view.textBoxExtraFreeDays.Text);
                }
                catch (InvalidCastException err)
                {
                    MessageBox.Show("Proszę wypełnić pole 'dodatkowe dni' wolne tylko pełnymi liczbami " + err.InnerException);
                    _logger.Error(err.Message);
                }
                

                try
                {
                    /*if (_employee.Id == Guid.Parse("00000000-0000-0000-0000-000000000000"))
                    _employee = _employee.Id = Guid.NewGuid();*/
                    _employee = _employee.AddName(_view.textBoxName.Text)
                            .AddSurname(_view.textBoxSurname.Text)
                            .AddUsername(_view.textBoxUsername.Text)
                            .AddPassword(_view.textBoxPassword.Text)
                            .AddEmail(_view.textBoxEmail.Text)
                            .AddSex(sex)
                            .AddYearsOfExperience(byte.Parse(_view.textBoxYearsOfExperience.Text))
                            .AddDateOfHire(_view.dateTimePickerHireDate.Value)
                            .AddExtraFreeDays(extraDays)
                            .AddSectionId(selectedSection.Id);
                }
                catch (Exception er) 
                {
                    _logger.Error(er.Message);
                }
                
                _model.Employee = (Employee)_employee.Clone();
            }
            catch (Exception er)
            {
                _logger.Error("Refresh model " + er.Message);
                MessageBox.Show(er.Message);
            }
        }

        private void GetSex()
        {
            try
            {
                _view.comboBoxSex.Items.Clear();

                _view.comboBoxSex.Items.Add("ustaw");
                _view.comboBoxSex.Items.Add("kobieta");
                _view.comboBoxSex.Items.Add("mężczyzna");

                _view.comboBoxSex.SelectedIndex = 0;
            }
            catch
            {
                throw;
            }
            
        }

        private async Task GetSectionsList()
        {
            try
            {
                _view.comboBoxSection.Items.Clear();
                var sectionList = _model.GetSections().Result;

                _view.comboBoxSection.Items.Add("ustaw");

                foreach (var item in sectionList)
                {
                    _view.comboBoxSection.Items.Add(item.Name);
                }

                _view.comboBoxSection.SelectedIndex = 0;
            }
            catch
            {
                throw;
            }
            await Task.CompletedTask;
        }

        private bool Validate()
       {
            var result = true;
            try
            {
                if (_view.textBoxSurname == null)
                    result = false;
                if (_view.textBoxName == null)
                    result = false;
                if (_view.textBoxUsername == null)
                    result = false;
                if (_view.textBoxPassword == null)
                    result = false;
                if (_view.textBoxEmail.Text == null)
                    result = false;
                if (_view.dateTimePickerHireDate.Value == null)
                    result = false;
                if (_view.comboBoxSection.SelectedIndex < 1)
                    result = false;
                if (_view.comboBoxSex.SelectedIndex < 1)
                    result = false;
            }
            catch
            {
                throw;
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

// tak jest lepiej bo robisz nowy model
// jak bedziesz chail to pczytaj o niemutowalnych obiektach,
// moze zrozumiesz cos 
// to jest o tyle fajne ze masz za kazdym razem nowy obiekt :) 
// nie wiem czy rozumiesz to 
// tak, ze wywoluje tymczasowy obiekt w varze, ktory potem przypisuje
// do wlasciwego obiektu
// tak to ci teraz pokazalem - ale idzie zrobic innym model nie mutowalny zaraz poszukam i sobie pczytasz 
//ok:)
// dobra musze cos zrobic, jak znajde to ci na fb wysle :) 
// baw sie dalej 
// ok