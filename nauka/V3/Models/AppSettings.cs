using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace nauka.V3.Models
{
    public class AppSettings: IEntity
    {

        public Guid Id { get; set; }
        
        [Required]
        public byte AvaibleVacationDays { get; set; }
        
        [Required]
        public DateTime Year { get; set; }
    }
}
