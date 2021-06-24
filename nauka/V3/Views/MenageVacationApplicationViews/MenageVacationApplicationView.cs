using nauka.V3.BaseViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nauka.V3.Views.MenageVacationApplicationViews
{
    public partial class MenageVacationApplicationView : baseView
    {
        private bool editView = false;
        public MenageVacationApplicationView()
        {
            InitializeComponent();
        }

        public bool IsEditView(bool editedView)
        {
            if (editedView)
            {
                editView = true;
                return true;
            }
            else
            {
                editView = false;
                return false;
            }
        }

        private void ChangeUserController()
        {
            if (!editView)
            {
                menageAdmnistrtationVacationApplicationUserControl1.Show();
                menageVacationApplicatoinUserControl1.Hide();
            }
            else
            {
                menageAdmnistrtationVacationApplicationUserControl1.Hide();
                menageVacationApplicatoinUserControl1.Show();
            }
        }
    }
}
