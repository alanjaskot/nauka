using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace nauka.V3.Models
{
    public class ExeptionCatcher: IEntity
    {
        [StringLength(36)]
        public Guid Id { get; set; }

        public String Exeption { get; set; }

        public string Entity { get; set; }

        public DateTime dateError { get; set; }
    }
}
