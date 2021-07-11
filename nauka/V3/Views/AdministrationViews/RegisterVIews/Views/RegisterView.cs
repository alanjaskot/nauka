using nauka.V3.Models;
using nauka.V3.Views.AdministrationViews.RegisterVIews.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nauka.V3.Views.AdministrationViews.RegisterVIews.Views
{
    public partial class RegisterView : Form
    {
        private RegisterController _controller;
        public RegisterView()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            _controller = new RegisterController(this);
        }

        public Employee SetObjectToEdit
        {
            get
            {
                return _controller.SetEmployee;
            }
            set
            {
                _controller.SetEmployee = value;
            }
        }
    }
}
