using nauka.V3.Views.LoginRegisterViews.Views;
using nauka.V3.Views.MianViews;
using nauka.V3.Views.UserViews.UserControls;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V3.Views.UserViews.LoginRegisterViews.Controllers
{
    class LoginController
    {
        private readonly LoginView _view;

        public LoginController(LoginView loginRegisterView)
        {
            _view = loginRegisterView;

            Task.Run(async () =>
            {
                await InitView();
            }).Wait();
        }

        private async Task InitView()
        {
            LoginUC login = new LoginUC();
            login.Dock = DockStyle.Fill;
            _view.panelMain.Controls.Add(login);
            await Task.CompletedTask;

            _view.buttonOK.Click += (object sender, EventArgs e) =>
            {
                MainView mainView = new MainView();
                mainView.Show();
                _view.Hide();
            };
        }


    }
}
