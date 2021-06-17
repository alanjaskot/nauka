using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using nauka.V2.Views.Logins.Controllers;
using nauka.V2.Models;

namespace nauka.V2.Views.Logins.Views
{
    public partial class LoginView : Form
    {
        private readonly LoginController _loginController;
        public LoginView()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            _loginController = new LoginController(this);
        }

        public Employee SetObjectToEdit
        {
            get
            {
                return _loginController.SetEployee;
            }
            set
            {
                _loginController.SetEployee = value;
            }
        }
    }
}
