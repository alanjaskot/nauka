using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Models
{
    public class Vacation
    {
        public Guid VacationId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Description { get; set; }
        public bool Approve { get; set; }
    }
}
