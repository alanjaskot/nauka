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
        /// <summary>
        /// dobra dziala
        /// troche ci namieszalem 
        /// zmienilem ci ten pasek na dole zeby sie nie laczyly ikont tak jest szybciej 
        /// no i ukrywaniue 
        /// to sie przydaje bo wiecej widac 
        /// jeszcze cos chcesz :) 
        /// narazie tyle, dzieki
        /// ok
        /// 
        /// </summary>
        public MainViewView()
        {
            InitializeComponent();

            _mainViewController = new MainViewController(this);
        }

    }
}
