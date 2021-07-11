using nauka.V3.Models;
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
        LoginUC login = new LoginUC();

        

        public LoginController(LoginView loginRegisterView)
        {
            _view = loginRegisterView;

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
            login.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(login);
            await Task.CompletedTask;

            _view.buttonExit.Click += (object sender, EventArgs e) =>
            {
                if (Validate())
                {
                    Login();
                }
                else
                    MessageBox.Show("Błędna nazwa użytkownika lub hasło");
                
            };

            login.textBoxPassword.KeyPress += (object sender, KeyPressEventArgs e) =>
            {
                if (e.KeyChar == (char)Keys.Enter) 
                    Login();
            };
        }

        private void Login()
        {
            var logedEmployee = _model.GetEmployee().Where(e => (e.Username == login.textBoxUsername.Text)
                && (e.Password == login.textBoxPassword.Text)).First();
            var view = new MainView();
            view.SetObjectToEdit = logedEmployee;
            _view.Hide();
            if (view.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private bool Validate()
        {
            var result = false;
            /*if (_model.GetEmployee().Where(e => (e.Username == login.textBoxUsername.Text)
                 && (e.Password == login.textBoxPassword.Text).First*/
            var employees = _model.GetEmployee();
            foreach(var item in employees)
            {
                if((item.Username == login.textBoxUsername.Text) &&
                    (item.Password == login.textBoxPassword.Text))
                {
                    result = true;
                }

            }
            return result;
        }


    }
}
