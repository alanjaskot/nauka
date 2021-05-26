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

        public Pracownik() { }

        public Pracownik (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.vacationHours = 176;
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
      
        public string GetFullName()
        {
            string fullName = GetFirstName() + " " + GetLastName();
            return fullName;
        }

    }
}
