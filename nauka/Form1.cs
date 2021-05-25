using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka
{
    public partial class Form1 : Form
    {
        Pracownik pracownik = new Pracownik();
        
        List<Pracownik> employeeList = new List<Pracownik>();

        

        public Form1()
        {
            InitializeComponent();
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddEmployee();
            ShowEmployee();
        }

        public void ShowEmployee()
        {
            string displayText;
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            
            foreach(Pracownik eployees in employeeList)
            {
                displayText = eployees.GetFirstName() + " " + eployees.GetLastName();
                listBox1.Items.Add(displayText.ToString());
            }
        }

        public void AddEmployee()
        {
            employeeList.Add(new Pracownik("Zosia", "Jaskot"));
            employeeList.Add(new Pracownik("Zygmunt", "Jaskot"));
            employeeList.Add(new Pracownik("Alan", "Jaskot"));
        }



        private void newEmloyee_Click(object sender, EventArgs e)
        {
            string firstName = txt_firstName.Text;
            string lastName = txt_lastName.Text;
            employeeList.Add(new Pracownik(firstName, lastName));
            label2.Text = firstName;
            ShowEmployee();
        }
    }
}
