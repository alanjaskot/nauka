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
        int listboxIndexNumber;

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
            MessageBox.Show("Pracownik został dodany");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxIndexNumber = listBox1.SelectedIndex;

        }

        private void button_addPass_Click(object sender, EventArgs e)
        {
            int passHours = Int32.Parse(txt_hourStop.Text) - Int32.Parse(txt_hourStart.Text);
            int allHours = employeeList[listboxIndexNumber].GetVacationHours();
            allHours -= passHours;
             
            if (allHours > 0)
            {
                employeeList[listboxIndexNumber].SetVacationHours(allHours);
                string employee = employeeList[listboxIndexNumber].GetFullName().ToString();
                string newPass = "pracownikowi " + employee + " pozostało " + (allHours / 8) + " dni oraz " + (allHours % 8) + " godz.";
                MessageBox.Show(newPass);

                String passDate = passDatePicker.Value.ToString("dd.MM.yyyy");
                newPass = employee + ": przepustka na " + passHours + "godzin - " + passDate;
                list_passView.Items.Add(newPass);

            }
            else
            {
                MessageBox.Show("Wykorzystano limit przepustek");
            }
        }

        private void button_addVacation_Click(object sender, EventArgs e)
        {
           int vacationDays = DaysOfVacations(datePicker_hollidayStart.Value, datePicker_HolidayEnd.Value);
            int allHours = employeeList[listboxIndexNumber].GetVacationHours() - (vacationDays * 8);
            if (vacationDays > 0)
            {
                employeeList[listboxIndexNumber].SetVacationHours(allHours);
                string employee = employeeList[listboxIndexNumber].GetFullName().ToString();
                string newPass = "pracownikowi " + employee + " pozostało " + (allHours / 8) + " dni oraz " + (allHours % 8) + " godz.";
                MessageBox.Show(newPass);
            }
        }

        public int DaysOfVacations(DateTime start, DateTime end)
        {
            if (end < start)
            {
                throw new ArgumentException("Urlop nie może zaczynać się po zakończeniu", nameof(end));
            }
            if(end.Date == start.Date)
            {
                return 0;
            }
            int days = 0;
            DateTime nextDate = start;
            while (nextDate <= end.Date)
            {
                if(nextDate.DayOfWeek != DayOfWeek.Saturday && nextDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    days++;
                }
                nextDate = nextDate.AddDays(1);
            }
            return days;
        }

    }
}

