
using nauka.V3.Models;
using nauka.V3.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Views.MainViews.Model
{
    public class MainViewModel
    {
        private EmployeeService _employeeService;
        private SectionService _sectionService;
        private VacationService _vacationService;


        public MainViewModel()
        {
            _employeeService = ManageService.Employees;
            _sectionService = ManageService.Sections;
            _vacationService = ManageService.Vacations;
        }

        public Employee Employee { get; set; }

        internal List<Section> GetSections()
        {
            var result = default(List<Section>);
            try
            {
                result = _sectionService.GetSections().Result;
            }
            catch
            {
                throw;
            }
            return result;
        }

        internal List<Vacation> GetVacations()
        {
            var result = default(List<Vacation>);
            try
            {
                result = _employeeService.GetVacations();
            }
            catch
            {
                throw;
            }

            return result;
            
        }

        internal void DeleteVacation(Vacation vacation)
        {
            _employeeService.DeleteVacation(Employee, vacation);
        }
    }
}
