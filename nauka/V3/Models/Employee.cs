using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace nauka.V3.Models
{
    public class Employee: ICloneable
    {

        [StringLength(36)]
        public Guid Id { get; set; }     // w baizei chyba masz ustaione uniklane to id
        /*
         * wiec jak robisz nowy to musisz jakos nadac nowe guid do obiektu
         * kiedys jak bylo id liczbowe to sama baza incementowala +1 wiec nie trzeba byloe toego robic 
         * 
         */
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(70)]
        public string Surname { get; set; }
        [MaxLength(16)]
        public string Username { get; set; }
        [MinLength(8)]
        [MaxLength(16)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }        
        public char Sex { get; set; }
        public bool EmployeePermisson { get; set; }
        public bool VacationPermisson { get; set; }
        public DateTime DateOfHire { get; set; }
        public byte YearsOfExpirence { get; set; }
        public byte CurrentFreeDays { get; private set; }
        public byte LastYearFreeDays { get; private set; }
        public byte ExtraFreeDays { get; set; }
                 
        //relation properties
        [StringLength(36)]
        public Guid SectionId { get;  set; }     
        public Section Section { get; set; }
        
        public List<Vacation_Employee> Vacation_Employees { get; set; }


        //
        // Functions
        //
        public byte GetYearsOfExpirence() 
        {
            DateTime currentYear = DateTime.Now;
            byte yearsInCompany = (byte)(currentYear.Year - DateOfHire.Year);

            return (byte)(YearsOfExpirence + yearsInCompany);
        }

        public byte GetCurrentFreeDays()
        {
            int yearsOfExperience = GetYearsOfExpirence();
            DateTime currentYear = DateTime.Now;
            DateTime dateOfHire = DateOfHire;
            DateTime startOfYear = new DateTime(currentYear.Year, 1, 1);

            byte result = 0;

            if(currentYear.Year - dateOfHire.Year > 0)
            {
                if (yearsOfExperience >= 10)
                    result = 26;
                if (yearsOfExperience < 10)
                    result = 20;
            }          
            else
            {
                double freeDays = 0;
                while (startOfYear <= DateTime.Now)
                {
                    if (yearsOfExperience >= 10)
                        freeDays += 2.16;
                    if (yearsOfExperience < 10)
                        freeDays += 1.66;
                    startOfYear = startOfYear.AddMonths(1);
                }
                result = (byte)Math.Ceiling(freeDays);
            }

            return result;
        }

        public byte GetLastYearFreeDays()
        {
            byte result = 0;
            int yearsOfExperience = GetYearsOfExpirence();
            DateTime dateOfHire = DateOfHire;
            DateTime lastYear = DateTime.Now.AddYears(-1);
            if (lastYear.Year - DateOfHire.Year < 0)
            {
                result = 0;
            }
            else if (dateOfHire.Year == lastYear.Year)
            {
                double freeDays = 0;
                DateTime endOfYear = new DateTime(lastYear.Year, 12, 31);
                while (dateOfHire < endOfYear)
                {
                    if(yearsOfExperience < 10)
                        freeDays += 1.66;
                    if (yearsOfExperience >= 10)
                        freeDays += 2.16;
                    dateOfHire = dateOfHire.AddMonths(1);
                }
                result = (byte)Math.Ceiling(freeDays);
            }
            else
            {
                if ((yearsOfExperience >= 10) && (dateOfHire.Year < lastYear.Year))
                    result = 26;

                if ((yearsOfExperience >= 2) && (yearsOfExperience < 10) && (dateOfHire.Year < lastYear.Year))
                    result = 20;
            }

            return result;
        }

        public Employee AddSurname (string surname)
        {
            var _emplyee = (Employee)MemberwiseClone();
            _emplyee.Surname = surname;
            return _emplyee;
        }

        public Employee AddName(string name)
        {
            var _employee = (Employee)MemberwiseClone();
            _employee.Name = name;
            return _employee;
        }

        public Employee AddUsername(string username)
        {
            var _employee = (Employee)MemberwiseClone();
            _employee.Username = username;
            return _employee;
        }

        public Employee AddPassword(string password)
        {
            var _employee = (Employee)MemberwiseClone();
            _employee.Password = password;
            return _employee;
        }

        public Employee AddEmail(string email)
        {
            var _employee = (Employee)MemberwiseClone();
            _employee.Email = email;
            return _employee;
        }

        public Employee AddSex(char sex)
        {
            var _employee = (Employee)MemberwiseClone();
            _employee.Sex = sex;
            return _employee;
        }

        public Employee AddEmployeePermisson(bool employeePermisson)
        {
            var _employee = (Employee)MemberwiseClone();
            _employee.EmployeePermisson = employeePermisson;
            return _employee;
        }

        public Employee AddVacationPermisson(bool vacationPermisson)
        {
            var _employee = (Employee)MemberwiseClone();
            _employee.VacationPermisson = vacationPermisson;
            return _employee;
        }

        public Employee AddDateOfHire(DateTime dateOfHire)
        {
            var _employee = (Employee)MemberwiseClone();
            _employee.DateOfHire = dateOfHire;
            return _employee;
        }

        public Employee AddYearsOfExperience(byte yearsOfExperience)
        {
            var _employee = (Employee)MemberwiseClone();
            _employee.YearsOfExpirence = yearsOfExperience;
            return _employee;
        }

        public Employee AddExtraFreeDays(byte extraFreeDays)
        {
            var _employee = (Employee)MemberwiseClone();
            _employee.ExtraFreeDays = extraFreeDays;
            return _employee;
        }

        public Employee AddSectionId(Guid sectionId)
        {
            var _employee = (Employee)MemberwiseClone();
            _employee.SectionId = sectionId;
            return _employee;
        }

        public Object Clone()
        {
            var _employee = (Employee)this.MemberwiseClone();
            return _employee;
        }


        // a po co tu appsettings 
        //dalem dni wolne od pracy
        // hm, ale co tam ma byc ilosc dnia i cos jeszcze ?? a co z innymi jak bedzie kilka ?? 
        //to jest przypisane 1:1, kazdy pracownik ma swoje wlasne dni
        //ale to i tak chce zmienic

        // ok chwila musze jeszcze cos zrobic 5 min



    }
}
