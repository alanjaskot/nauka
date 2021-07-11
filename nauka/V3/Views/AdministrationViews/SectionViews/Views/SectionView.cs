using nauka.V3.Models;
using nauka.V3.Views.AdministrationViews.SectionViews.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nauka.V3.Views.AdministrationViews.SectionViews.SectionViews
{
    public partial class SectionView : Form
    {
        private SectionController _controller;

        public SectionView()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            _controller = new SectionController(this);
        }

        public Section SetObjectToEdit
        {
            get
            {
                return _controller.SetSection;
            }
            set
            {
                _controller.SetSection = value;
            }
        }
    }
}
