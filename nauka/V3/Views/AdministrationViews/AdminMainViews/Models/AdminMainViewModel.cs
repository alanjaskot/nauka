using nauka.V3.Models;
using nauka.V3.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;

namespace nauka.V3.Views.AdministrationViews.AdminMainViews.Models
{
    public class AdminMainViewModel
    {
        private EmployeeService _employeeService;
        private SectionService _sectionService;
        private VacationService _vacationService;
        private VacationDaysService _vacationDaysService;

        public Employee Employee { get; set; }
        public Section Section { get; set; }

        public AdminMainViewModel() 
        {
            _employeeService = ManageService.Employees;
            _sectionService = ManageService.Sections;
            _vacationService = ManageService.Vacations;
            _vacationDaysService = ManageService.VacationDays;
        }

        #region Vacations

        internal async Task AddVacation(Vacation vacation)
        {
            await _vacationService.Add(vacation);
        }

        internal async Task UpdateVacation(Vacation vacation)
        {
            await _vacationService.Update(vacation);
        }

        internal async Task DeleteVacation(Vacation vacation)
        {
            await _vacationService.Delete(vacation);
        }

        public async Task<List<Vacation>> GetVacations()
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
            return await Task.FromResult(result);
        }

        #endregion

        #region sections

        internal async Task AddSection(Section section)
        {
            await _sectionService.Add(Section);
        }

        internal async Task UpdateSection(Section section)
        {
            await _sectionService.Update(section);
        }

        internal async Task DeleteSection(Section section)
        {
            await _sectionService.Delete(Section);
        }
        
        internal async Task<List<Section>> GetSections()
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
            return await Task.FromResult(result);
        }
        #endregion

        #region Employees

        internal async Task<List<Employee>> GetEmployees()
        {
            var result = default(List<Employee>);
            try
            {
                result = _employeeService.GetEmployees().Result;
            }
            catch
            {
                throw;
            }
            return await Task.FromResult(result);
        }

        internal async Task AddEmployee(Employee employee)
        {
            await _employeeService.Add(employee);
        }

        internal async Task UpdateEmployee(Employee employee)
        {
            await _employeeService.Update(employee);
        }

        internal async Task DeleteEmployee(Employee employee)
        {
            await _employeeService.Delete(employee);
        }

        #endregion

        #region VacationDays

        internal async Task DeleteVacationDay(VacationDays vacationDays)
        {
            await _vacationDaysService.Delete(vacationDays);
        }

        internal async Task AddVacationDays(VacationDays vacationDays)
        {
            await _vacationDaysService.Add(vacationDays);
        }

        internal async Task UpdateVacationDays(VacationDays vacationDays)
        {
            await _vacationDaysService.Update(vacationDays);
        }

        #endregion
    }
}
