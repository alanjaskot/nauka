using nauka.V3.Models;
using nauka.V3.Views.AdministrationViews.NewAbsenceViews.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nauka.V3.Views.AdministrationViews.NewAbsenceViews.Views
{
    public partial class NewAbsenceView : Form
    {
        private NewAbsenceController _controller;
        public NewAbsenceView()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            _controller = new NewAbsenceController(this);
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
