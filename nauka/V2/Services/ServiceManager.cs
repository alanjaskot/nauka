using nauka.V2.Services.Employee;
using nauka.V2.Services.Sections;
using nauka.V2.Services.Settings;
using nauka.V2.Services.Vacations;
using nauka.V2.Services.VacationDays;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V2.Services
{
    public static class ServiceManager
    {
        // to jest taki magazyn 
        // jest to statyczne czyli robisz obiekt raz i on zawsze zostaje 
        // wazne zeby go zaincjowac i on sobie zyje 
        // taka baza danych w ram 

        public static EmployeeService Employees { get; set; }
        public static SectionService Sections { get; set; }
        public static SettingsService Settings { get; set; }
        public static VacationService Vacations { get; set; }
        public static VacationsDaysService VacationDays { get; set; }

        public static void Init()
        {
            Employees = new EmployeeService();
            Sections = new SectionService();
            Settings = new SettingsService();
            Vacations = new VacationService();
            VacationDays = new VacationsDaysService();
        }
    }
}
