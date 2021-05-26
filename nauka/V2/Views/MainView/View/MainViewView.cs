using nauka.V2.Views.MainView.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V2.Views.MainView.View
{
    public partial class MainViewView : Form
    {
        private readonly IMainViewController _mainViewController;
        
        public MainViewView()
        {
            InitializeComponent();

            Shown += MainViewView_Load;

            _mainViewController = new MainViewController(this);
        }

        private void MainViewView_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                await _mainViewController.RefreshView();
            }); 
        }
    }
}
