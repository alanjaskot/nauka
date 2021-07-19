using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace nauka.V3.Models
{
    public class AppSettings
    {

        [Required]
        public byte AvaibleVacationDays { get; set; }

    }
}
