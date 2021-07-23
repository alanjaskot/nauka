using nauka.V3.Models;
using nauka.V3.Services;
using nauka.V3.Views.LoginRegisterViews.Views;
using nauka.V3.Views.MianViews;
using nauka.V3.Views.UserViews.LoginViews.Model;
using nauka.V3.Views.UserViews.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V3.Views.UserViews.LoginRegisterViews.Controllers
{
    class LoginController
    {
        private readonly LoginView _view;
        private LoginModel _model;
      

        public LoginController(LoginView view)
        {
            _view = view;

            Task.Run(async () =>
            {
                await InitViewModel();
                await InitView();
            }).Wait();
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

        private async Task InitView()
        {

            _view.buttonOk.Click += (object sender, EventArgs e) =>
            {
                if (Validate())
                {
                    Login();
                }
                else
                    MessageBox.Show("Błędna nazwa użytkownika lub hasło");
                
            };

            _view.textBoxPassword.KeyPress += (object sender, KeyPressEventArgs e) =>
            {
                if (e.KeyChar == (char)Keys.Enter) 
                    Login();
            };
            await Task.CompletedTask;
        }

        private async Task Login()
        {
                    var loggedEmployee = _model.GetEmployees().Result
                        .Where(e => e.Username == _view.textBoxUsername.Text && e.Password == _view.textBoxPassword.Text).FirstOrDefault();
                    if (loggedEmployee != null)
                    {
                        var view = new MainView();
                        view.SetObjectToEdit = loggedEmployee;
                        view.Show();
                        _view.Hide();
                    }

            await Task.CompletedTask;
        }

        private bool Validate()
        {
            var result = false;

                var username1 = _model.GetEmployees().Result
                .Where(e => e.Username == _view.textBoxUsername.Text && e.Password == _view.textBoxPassword.Text).FirstOrDefault();
                string username = username1.Username;
                string password = username1.Password;

                if ((_view.textBoxUsername.Text == username) && (_view.textBoxPassword.Text == password))
                {
                    result = true;
                }

            
            return result;
        }


    }
}
