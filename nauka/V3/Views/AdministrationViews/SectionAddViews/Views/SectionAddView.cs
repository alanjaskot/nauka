﻿using nauka.V3.Views.SectionViews.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nauka.V3.Views.SectionViews.Views
{
    public partial class SectionAddView : Form
    {
        private readonly SectionAddController _controller;
        public SectionAddView()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            
        }
    }
}