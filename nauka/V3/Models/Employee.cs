using System;
using System.Collections.Generic;
using System.Text;


namespace nauka.V3.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }        
        public char Sex { get; set; }
        public bool EmployeePermisson { get; set; }
        public bool VacationPermisson { get; set; }
        public Section Section { get; set; }

        public virtual string FullName
        {
            get
            {
                return $"{Name + Surname}";
            }
        }
    }
}
