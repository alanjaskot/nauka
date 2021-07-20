using nauka.V3.Models;
using nauka.V3.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Views.UserViews.LoginViews.Model
{
    public class LoginModel
    {
        private EmployeeService _employeeService;

        public LoginModel()
        {
            _employeeService = ManageService.Employees;
        }

        public Employee Employee { get; set; }

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
    }

    

}
