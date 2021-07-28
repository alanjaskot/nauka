using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Models
{
    public class NLogModel
    {
        public string Application { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }
        public string Logger { get; set; }
        public string Callsite { get; set; }
        public string Exception { get; set; }
    }
}
