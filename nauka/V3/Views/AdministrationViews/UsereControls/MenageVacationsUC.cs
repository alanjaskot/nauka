﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nauka.V3.Views.AdministrationViews.UsereControls
{
    public partial class MenageVacationsUC : UserControl
    {
        public MenageVacationsUC()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            VacationView vacationView = new VacationView();
            vacationView.Show();
        }
    }
}