using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Services
{
    public static class ManageService
    {
        public static EmployeeService Employees { get; set; }
        public static SectionService Sections { get; set; }

        public static void Init()
        {
            Employees = new EmployeeService();
            Sections = new SectionService();
        }
    }
}
