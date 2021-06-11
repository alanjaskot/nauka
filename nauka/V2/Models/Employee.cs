using nauka.V2.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V2.Models
{
    public class Employee : BaseModel
    {
        public long Id { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Section Section { get; set; }
        public Vacation Vacation { get; set; }

        public List<VacationDays> VacationDays { get; set; }

        public virtual string GetFullName
        {
            get
            {
                return $@"{Surname} {Name}";
            }     
        }

        public virtual string GetSectionName
        {
            get
            {
                return $@"{Section.Name}";
            }
        }

        public virtual string SetSectionName
        {
            set
            {
                Section.Name = "Section2";
            }
        }

    }
}
