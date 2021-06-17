using nauka.V2.Views.VacationDays.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nauka.V2.Views.VacationDays.Views
{
    public partial class VacationDaysView : Form
    {
        private readonly VacationDayController _vacationDaysController;

        public VacationDaysView()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            _vacationDaysController = new VacationDayController(this);
        }

        public nauka.V2.Models.VacationDays SetObjectToEdit
        {
            get
            {
                return _vacationDaysController.SetVacationDays;
            }
            set
            {
                _vacationDaysController.SetVacationDays = value;
            }
        }


    }
}
