using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace nauka.V3.Models
{
    public class AppSettings: IEntity
    {
        [Key]
        [StringLength(36)]
        public Guid Id { get; set; }
        public byte AvaibleVacationDays { get; set; }
       
        [StringLength(36)]
        public Guid EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }


    }
}
