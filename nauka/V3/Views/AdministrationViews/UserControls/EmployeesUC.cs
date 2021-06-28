using nauka.V3.Views.AdministrationViews.RegisterVIews.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nauka.V3.Views.AdministrationViews.UsereControls
{
    public partial class EmployeesUC : UserControl
    {
        public EmployeesUC()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            RegisterView registerView = new RegisterView();
            registerView.Show();

        }
    }
}
