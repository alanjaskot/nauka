using nauka.V3.BaseViews;
using nauka.V3.Models;
using nauka.V3.Views.AdministrationViews.AdminMainViews.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nauka.V3.Views.AdministrationViews.AdminMainViews.Views
{
    public partial class AdminMainView : baseView
    {
        private readonly AdminMainViewController _controller;
        
        public AdminMainView()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            _controller = new AdminMainViewController(this);
        }

        public Employee SetObjectToEdit
        {
            get
            {
                return _controller.SetEployee;
            }
            set
            {
                _controller.SetEployee = value;
            }
        }

    }
}
