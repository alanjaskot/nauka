using nauka.V2.Models;
using nauka.V2.Views.Vacations.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nauka.V2.Views.Vacations.Views
{
    public partial class VacationView : Form
    {
        private readonly VacationController _vacationController;
        public VacationView()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            _vacationController = new VacationController(this);
        }

        public Vacation SetObjectToEdit
        {
            get
            {
                return _vacationController.SetVacation;
            }
            set
            {
                _vacationController.SetVacation = value;
            }
        }
    }
}
