using System;
using System.Collections.Generic;
using System.Text;
using nauka.V2.Views.Logins.Views;
using nauka.V2.Views.Logins.Models;
using nauka.V2.Views.MainView.Controllers;
using System.Threading.Tasks;
using System.Windows.Forms;
using nauka.V2.Models;

namespace nauka.V2.Views.Logins.Controllers
{
    class LoginController
    {
        private readonly LoginView _view;
        private LoginModel _model;
        private readonly MainViewController _mainViewController;

        public LoginController(LoginView loginView)
        {
            _view = loginView;
            
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
            _view.buttonLogin.Click += (object sender, EventArgs e) =>
            {
                if (!Valid())
                {
                    LoginFailed();
                }
                else
                {
                      _view.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            };

            await Task.CompletedTask;
        }

        private async Task InitViewModel()
        {
            if (_model == null)
            {
                _model = new LoginModel();
            }
            else

                await Task.CompletedTask;
        }

        private void LoginSucces()
        {
            
        }

        private void LoginFailed()
        {
            MessageBox.Show("Błędny login lub hasło");
        }

        private bool Valid()
        {
            return true;
        }

        public Employee SetEployee
        {
            get
            {
                LoginSucces();

                return _model.Employee;
            }
            set
            {
                if (value == null)
                    return;

                _model.Employee = value;

                LoginSucces();
            }
        }

    }
}
