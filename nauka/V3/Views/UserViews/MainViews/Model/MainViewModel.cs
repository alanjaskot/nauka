
using nauka.V3.Models;
using nauka.V3.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Views.MainViews.Model
{
    public class MainViewModel
    {
        public Employee Employee { get; set; }
        public Vacation Vacation { get; set; }
        public VacationDays VacationDays { get; set; }

        private EmployeeService _employeeService;
        private SectionService _sectionService;
        private VacationService _vacationService;
        private VacationDaysService _vacationDayService;

        public MainViewModel()
        {
            _employeeService = ManageService.Employees;
            _sectionService = ManageService.Sections;
            _vacationService = ManageService.Vacations;
            _vacationDayService = ManageService.VacationDays;
        }

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

        internal List<VacationDays> GetVacationDays()
        {
            var result = default(List<VacationDays>);
            try
            {
                result = _vacationDayService.GetVacationDays().Result;
            }
            catch
            {
                throw;
            }
            return result;
        }

        #region Vacation

        internal List<Vacation> GetVacations()
        {
            var result = default(List<Vacation>);
            try
            {
                result = _vacationService.GetVacations().Result;
            }
            catch
            {
                throw;
            }

            return result;
        }

        internal void DeleteVacation(Vacation vacation)
        {
            _vacationService.Delete(vacation);
        }

        #endregion

        internal void UpdateEmployee(Employee employee)
        {
            _employeeService.Update(employee);
        }

    }
}
