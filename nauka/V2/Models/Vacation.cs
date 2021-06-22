using nauka.V2.Base;
using nauka.V2.Services.Vacations;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V2.Models
{
    public class Vacation : BaseModel
    {
        public Guid Id { get; set; }

        public long VacationDaysCount { get; set; }
    }
}
