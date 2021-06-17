using nauka.V2.Models;
using nauka.V2.Views.Employees.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nauka.V2.Views.Employees.Views
{
    public partial class EmployeeView : Form
    {
        private readonly EmpleyeController _empleyeController; // zeby dodac referencje to ctrl + . 
       
        public EmployeeView()
        {
            InitializeComponent();

            // to sprawdza czy dane okno otwiera sie w ide - jak tak to nie jest wykonywany dalej zaden kod, bo moze sie cos wywalic
            if (DesignMode)
                return;

            _empleyeController = new EmpleyeController(this);


        }

        public Employee SetObjectToEdit
        {
            get
            {
                return _empleyeController.SetEployee;
            }
            set
            {
                _empleyeController.SetEployee = value;
            }
        }

    }
}
