using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace nauka.V3.Models
{
    public class Vacation: IEntity<Guid>
    {

        [StringLength(36)]
        public Guid Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Start { get; set; }
        [DataType(DataType.Date)]
        public DateTime End { get; set; }
        public  string Description { get; set; }
        public bool Approve { get; set; }

        //relation properties
        [StringLength(36)]
        public Guid VacationDaysId { get; set; }
        public VacationDays VacationDays { get; set; }
        public List<Vacation_Employee> Vacation_Employees { get; set; }
    }
}
