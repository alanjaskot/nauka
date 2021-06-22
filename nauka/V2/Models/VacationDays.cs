using nauka.V2.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V2.Models
{
    public class VacationDays : BaseModel
    {
        public Guid Id { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Description { get; set; }

    }
}
