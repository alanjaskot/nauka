using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Services
{
    public static class ManageService
    {
        public static AppSettingsService AppSettings { get; set; }
        public static EmployeeService Employees { get; set; }
        public static SectionService Sections { get; set; }
        public static VacationService Vacations { get; set; }
        public static VacationDaysService VacationDays { get; set; }

        public static Vacation_EmployeeServices Vacation_EmployeeServices { get; set; }

        public static void Init()
        {
            AppSettings = new AppSettingsService();
            Employees = new EmployeeService();
            Sections = new SectionService();
            Vacations = new VacationService();
            VacationDays = new VacationDaysService();
            Vacation_EmployeeServices = new Vacation_EmployeeServices();
        }
    }
}
