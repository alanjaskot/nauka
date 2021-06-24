using nauka.V3.BaseViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nauka.V3.Views.AdministrationsViewsViews.AdministrationViews
{
    public partial class AdministrationView : baseView
    {
        private bool hasPermison = false;
        
        public AdministrationView()
        {
            InitializeComponent();
        }



        public bool SetPermission(bool hasPermited)
        {
            if (hasPermited)
            {
                hasPermison = true;
            }
            else
            {
                hasPermison = false;
            }
            return hasPermison;
        }

        private void NoPermisionLoad(object sender, EventArgs e)
        {
            SetPermission(false);
            if (!hasPermison)
            {
                permittedUserControl1.Hide();
                noPermissionUserControl1.Show();
            }
            else
            {
                noPermissionUserControl1.Hide();
                permittedUserControl1.Show();
                }
        }


    }
}
