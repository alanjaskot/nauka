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

        private EmployeeService _serviceEmployee;
        private VacationService _serviceVacation;

        public VacationApplicationModel()
        {
            _serviceEmployee = ManageService.Employees;
            _serviceVacation = ManageService.Vacations;
        }

        internal async Task Add(Vacation vacation, Employee employee)
        {
            await _serviceVacation.Add(vacation);
            await _serviceEmployee.Update(employee);
        }
    }
}
