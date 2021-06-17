using nauka.V2.Views.MainView.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V2.Views.MainView.Views
{
    public partial class MainViewView : Form
    {
        private readonly IMainViewController _mainViewController;
        
        public MainViewView()
        {
            InitializeComponent();

            _mainViewController = new MainViewController(this);
        }

    }
}
