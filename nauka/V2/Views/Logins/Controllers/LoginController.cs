using System;
using System.Collections.Generic;
using System.Text;
using nauka.V2.Views.Logins.Views;
using nauka.V2.Views.Logins.Models;
using nauka.V2.Views.MainView.Controllers;
using System.Threading.Tasks;
using System.Windows.Forms;
using nauka.V2.Models;
using System.Diagnostics;

namespace nauka.V2.Views.Logins.Controllers
{
    class LoginController
    {
        private readonly LoginView _view;
        private LoginModel _model;
        
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
                _view.DialogResult = DialogResult.Cancel;
            };
            _view.buttonLogin.Click += (object sender, EventArgs e) =>
            {
                if (!Valid())
                {
                    LoginFailed();
                }
                else
                {
                    _view.DialogResult = DialogResult.OK;
                }
            };

            AutoLogininDebugger();

            await Task.CompletedTask;
        }

        private void AutoLogininDebugger()
        {
            if(Debugger.IsAttached)
            {
                _view.textBoxLogin.Text = "user1";
                _view.textBoxPassword.Text = "123";
            }
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
            MessageBox.Show($"Użytkownik {_model.Employee.GetFullName} został zalogowany");
        }

        private void LoginFailed()
        {
            MessageBox.Show("Błędny login lub hasło");
        }

        private bool Valid()
        {  
            if(_model.Employee.LoginName.Equals(_view.textBoxLogin.Text) && _model.Employee.Password.Equals(_view.textBoxPassword.Text))
            {
                LoginSucces();
                return true;
            }
            else
            {
                return false;
            }
        }

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
