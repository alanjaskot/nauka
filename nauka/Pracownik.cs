using System;
using System.Collections.Generic;
using System.Text;

namespace nauka
{
    class Pracownik
    {
        private string firstName, lastName;
        private int  vacationHours;
        private int deafualtVacationHours = 176;
        private int toManyHours;

        public Pracownik() { }

        public Pracownik (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void SetFirstName (string firstName)   {this.firstName = firstName;}
        public string GetFirstName (){ return firstName; }

        public void SetLastName (string lastName)   {this.lastName = lastName;}
        public string GetLastName() { return lastName; }

        public void SetVacationHours (int vacationHours)   {this.vacationHours = vacationHours;}
        public int GetVacationHours() { return vacationHours; }
        
        public int SetVacationToDefault ()
        {
            vacationHours = deafualtVacationHours;
            return vacationHours;
        }

        public int PlanningVacation (int planningVacationDays)
        {
            int planningVacationHours = planningVacationDays * 8;

            if (vacationHours >= planningVacationHours)
            {
                vacationHours -= planningVacationHours;
                return vacationHours;
            }
            return -1;
        }

        public int PlanningPass (int planningPassHours)
        {
            if(planningPassHours >= vacationHours)
            {
                vacationHours -= planningPassHours;
            }
            return -1;
        }

        public Pracownik AddNewPracownik(string firstName, string lastName)
        {
            return new Pracownik(firstName, lastName);
        }

        public string DisplayPracownik(Pracownik pracownik)
        {
            string displayPracownik = pracownik.GetFirstName() + " " + pracownik.GetLastName() + "/n";
            return displayPracownik;
        }

    }
}
