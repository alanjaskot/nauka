using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace nauka.V3.Models
{
    public class Vacation: IEntity<Guid>
    {
        [Key]
        [StringLength(36)]
        public Guid Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Start { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime End { get; set; }

        [Required]
        public  string Description { get; set; }

        [Required]
        public bool Approve { get; set; }

        public List<VacationOfEmployee> VacationOfEmployees { get; set; }
    }
}
