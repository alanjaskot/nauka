using nauka.V3.Models;
using nauka.V3.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Views.UserViews.VacationApplicationViews.Models
{
    public class VacationApplicationModel
    {
        public Employee Employee { get; set; }
        public Vacation Vacation { get; set; }

        private Vacation_EmployeeServices _vacation_employeeService;
        private EmployeeService _employeeService;
        private VacationService _vacationService;

        public VacationApplicationModel()
        {
            _employeeService = ManageService.Employees;
            _vacationService = ManageService.Vacations;
            _vacation_employeeService = ManageService.Vacation_EmployeeServices;
        }

        internal async Task AddVacation(Vacation vacation)
        {
            try
            {
                await _vacationService.Add(vacation);
            }
            catch
            {
                throw;
            }
            
        }

        internal async Task UpdateEmployee(Guid employeeId, Employee employee)
        {
            try
            {
                await _employeeService.Update(employeeId, employee);
            }
            catch
            {
                throw;
            }
            
        }

        internal async Task AddVacation_Employee(Vacation_Employee vacation_Employee)
        {
            try
            {
                await _vacation_employeeService.Add(vacation_Employee);
            }
            catch
            {
                throw;
            }
            
        }


    }
}
