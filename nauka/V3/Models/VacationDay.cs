using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace nauka.V3.Models
{
    public class VacationDay: IEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public long VacationDays { get; set; }
    }
}
