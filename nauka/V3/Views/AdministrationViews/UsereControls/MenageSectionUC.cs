using nauka.V3.Views.SectionViews.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nauka.V3.Views.AdministrationViews.UsereControls
{
    public partial class MenageSectionUC : UserControl
    {
        public MenageSectionUC()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SectionAddView sectionAddView = new SectionAddView();
            sectionAddView.Show();
        }
    }
}
