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

        public Employee Employee { get; set; }
        public Section Section { get; set; }

        public AdminMainViewModel() 
        {
            _employeeService = ManageService.Employees;
            _sectionService = ManageService.Sections;
            _vacationService = ManageService.Vacations;
        }

        #region Vacations

        internal void AddVacation(Vacation vacation)
        {
            _vacationService.Add(vacation);
        }

        internal void DeleteVacation(Vacation vacation)
        {
            _vacationService.Delete(vacation);
        }

        #endregion

        #region sections

        internal void AddSection(Section section)
        {
            _sectionService.Add(Section);
        }

        internal void UpdateSection(Section section)
        {
            _sectionService.Update(section);
        }

        internal void DeleteSection(Section section)
        {
            _sectionService.Delete(Section);
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
        #endregion

        #region Employees

        internal List<Employee> GetEmployees()
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
            return result;
        }

        internal void AddEmployee(Employee employee)
        {
            _employeeService.Add(employee);
        }

        internal void UpdateEmployee(Employee employee)
        {
            _employeeService.Update(employee);
        }

        internal void DeleteEmployee(Employee employee)
        {
            _employeeService.Delete(employee);
        }

        #endregion
    }
}
