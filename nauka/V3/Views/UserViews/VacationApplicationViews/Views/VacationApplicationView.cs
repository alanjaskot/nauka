using nauka.V3.Models;
using nauka.V3.Views.UserViews.VacationApplicationViews.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nauka.V3.Views.UserViews.VacationApplicationViews.Views
{
    public partial class VacationApplicationView : Form
    {
        private VacationApplicationController _controller;
        public VacationApplicationView()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            _controller = new VacationApplicationController(this);
        }

        public Vacation SetObjectToEdit
        {
            get
            {
                return _controller.SetVacation;
            }
            set
            {
                _controller.SetVacation = value;
            }
        }

        public Employee SetEmployee
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
