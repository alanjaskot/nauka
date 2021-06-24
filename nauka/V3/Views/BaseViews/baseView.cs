using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nauka.V3.BaseViews
{
    public partial class baseView : Form
    {
        public baseView()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => labelTitle.Text;
            set => labelTitle.Text = value;
        }

    }
}
