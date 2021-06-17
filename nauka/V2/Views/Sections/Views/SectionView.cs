using nauka.V2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using nauka.V2.Views.Sections.Controllers;

namespace nauka.V2.Views.Sections.Views
{
    public partial class SectionView : Form
    {
        private readonly SectionController _sectionController;

        public SectionView()
        {
            InitializeComponent();
        
            if (DesignMode)
                return;

            _sectionController= new SectionController(this);
        }

        public Section SetObjectToEdit
        {
            get
            {
                return _sectionController.SetSection;
            }
            set
            {
                _sectionController.SetSection = value;
            }
        }
    }
}
