using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace nauka.V3.Models
{
    public class Vacation_Employee: IEntity
    {
        [StringLength(36)]
        public Guid Id { get; set; }


        //navigation properties
        [StringLength(36)]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        
        [StringLength(36)]
        public Guid VacationId { get; set; }
        public Vacation Vacation { get; set; }
    }
}
