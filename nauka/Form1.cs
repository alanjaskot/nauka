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
        DateTime[] dateTime = new DateTime[0]
        {

        };

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
                string newPass = "pracownikowi " + employee + " pozostało " + (allHours / 8) + " dni oraz " + (allHours % 8) + " godzin";
                MessageBox.Show(newPass);

                String passDate = passDatePicker.Value.ToString("dd mm yyyy");
                newPass = employee + ": przepustka na " + passHours + "godzin - " + passDate;
                list_passView.Items.Add(newPass);

            }
            else
            {
                MessageBox.Show("Wykorzystano limit przepustek");
            }
        }

        public static int BusinessDaysUntil(this DateTime firstDay, DateTime lastDay, params DateTime[] bankHolidays)
        {
            firstDay = firstDay.Date;
            lastDay = lastDay.Date;
            if (firstDay > lastDay)
                throw new ArgumentException("Incorrect last day " + lastDay);

            TimeSpan span = lastDay - firstDay;
            int businessDays = span.Days + 1;
            int fullWeekCount = businessDays / 7;
            // find out if there are weekends during the time exceedng the full weeks
            if (businessDays > fullWeekCount * 7)
            {
                // we are here to find out if there is a 1-day or 2-days weekend
                // in the time interval remaining after subtracting the complete weeks
                int firstDayOfWeek = (int)firstDay.DayOfWeek;
                int lastDayOfWeek = (int)lastDay.DayOfWeek;
                if (lastDayOfWeek < firstDayOfWeek)
                    lastDayOfWeek += 7;
                if (firstDayOfWeek <= 6)
                {
                    if (lastDayOfWeek >= 7)// Both Saturday and Sunday are in the remaining time interval
                        businessDays -= 2;
                    else if (lastDayOfWeek >= 6)// Only Saturday is in the remaining time interval
                        businessDays -= 1;
                }
                else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7)// Only Sunday is in the remaining time interval
                    businessDays -= 1;
            }

            // subtract the weekends during the full weeks in the interval
            businessDays -= fullWeekCount + fullWeekCount;

            // subtract the number of bank holidays during the time interval
            foreach (DateTime bankHoliday in bankHolidays)
            {
                DateTime bh = bankHoliday.Date;
                if (firstDay <= bh && bh <= lastDay)
                    --businessDays;
            }

            return businessDays;
        }
    }
}
