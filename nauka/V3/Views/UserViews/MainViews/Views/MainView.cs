using nauka.V3.BaseViews;
using nauka.V3.Views.MainViews.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace nauka.V3.Views.MianViews
{
    public partial class MainView : baseView
    {
        private readonly MainViewController _mainViewController;
        public MainView()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            _mainViewController = new MainViewController(this);
        }
    }
}
