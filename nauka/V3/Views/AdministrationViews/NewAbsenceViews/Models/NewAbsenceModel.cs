using nauka.V3.Models;
using nauka.V3.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Views.AdministrationViews.NewAbsenceViews.Models
{
    public class NewAbsenceModel
    {
        public Employee Employee;
        public Vacation Vacation;
        private EmployeeService _employeeService;
        private SectionService _sectionsService;
        private VacationService _vacationService;
        private Vacation_EmployeeServices _vacation_EmployeeService;

        public NewAbsenceModel()
        {
            _employeeService = ManageService.Employees;
            _sectionsService = ManageService.Sections;
            _vacationService = ManageService.Vacations;
            _vacation_EmployeeService = ManageService.Vacation_EmployeeServices;
        }

        #region Employee

        public async Task<List<Employee>> GetEmployees()
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

        internal async Task UpdateEmployee(Guid employeeId, Employee employee)
        {
            await _employeeService.Update(employeeId, employee);
        }

        #endregion

        #region Vacations

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

        internal async Task AddVacation(Vacation vacation)
        {
            await _vacationService.Add(vacation);
        }

        #endregion

        #region Vacation_Employee

        internal async Task AddVacation_Employee(Vacation_Employee vacation_Employee)
        {
            await _vacation_EmployeeService.Add(vacation_Employee);
        }

        internal async Task DeleteVacationEmployee(Vacation_Employee vacation_Employee)
        {
            await _vacation_EmployeeService.Delete(vacation_Employee);
        }

        internal async Task<List<Vacation_Employee>> GetVacation_Employees()
        {
            return await Task.FromResult(_vacation_EmployeeService.GetVacation_Employees().Result);
        }


        #endregion

        public async Task<List<Section>> GetSections()
        {
            var result = default(List<Section>);
            try
            {
                result = _sectionsService.GetSections().Result;
            }
            catch
            {
                throw;
            }

            return await Task.FromResult(result);
        }

    }
}
