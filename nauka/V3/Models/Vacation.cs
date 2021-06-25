using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Models
{
    class Vacation
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Description { get; set; }
    }
}
