using nauka.V3.Models;
using nauka.V3.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Views.UserViews.VacationApplicationViews.Models
{
    public class VacationApplicationModel
    {
        public Employee Employee { get; set; }
        private EmployeeService _serviceEmployee;
        public Vacation Vacation { get; set; }
        private VacationService _serviceVacation;

        public VacationApplicationModel()
        {
            _serviceEmployee = ManageService.Employees;
            _serviceVacation = ManageService.Vacations;
        }

    }
}
