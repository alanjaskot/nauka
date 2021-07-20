using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace nauka.V3.Models
{
    public class VacationDays : IEntity
    {
        [StringLength(36)]
        public Guid Id { get; set; }
        public long Days { get; set; }
        public DateTime Year { get; set; }

        [StringLength(36)]
        public Guid VacationId { get; set; }
        [ForeignKey(nameof(VacationId))]
        public Vacation Vacation { get; set; }
    }
}
