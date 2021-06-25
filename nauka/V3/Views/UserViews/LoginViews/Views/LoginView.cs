using nauka.V3.BaseViews;
using nauka.V3.Views.UserViews.LoginRegisterViews.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nauka.V3.Views.LoginRegisterViews.Views
{
    public partial class LoginView : baseView
    {
        private readonly LoginController _controller;
        public LoginView()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            _controller = new LoginController(this);
        }

        
    }
}
