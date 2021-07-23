using Microsoft.EntityFrameworkCore;
using nauka.V3.Repository;
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
            DataBaseContext context = new DataBaseContext();
            context.Database.Migrate();

            AppSettingsRepository appRepository = new AppSettingsRepository(context);
            EmployeeRepository employeeRepository = new EmployeeRepository(context);
            SectionRepository sectionRepository = new SectionRepository(context);
            VacationRepository vacationRepository = new VacationRepository(context);
            VacationDaysRepository vacationDaysRepository = new VacationDaysRepository(context);
            Vacation_EmployeeRepository vacation_EmployeeRepository = new Vacation_EmployeeRepository(context);

            AppSettings = new AppSettingsService(context, appRepository);
            Employees = new EmployeeService(context, employeeRepository);
            Sections = new SectionService(context, sectionRepository);
            Vacations = new VacationService(context, vacationRepository);
            VacationDays = new VacationDaysService(context, vacationDaysRepository);
            Vacation_EmployeeServices = new Vacation_EmployeeServices(context, vacation_EmployeeRepository);


        }
    }
}
