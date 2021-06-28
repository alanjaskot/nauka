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
        //private EmployeeService _employeeService;

        public LoginModel()
        {
            //_employeeService = MenageService.Employees;
        }

        public Employee Employee { get; set; }

        internal List<Employee> GetEmployee()
        {
            var result = default(List<Employee>);
            try
            {
                result = ManageService.Employees.GetEmployees().Result;
            }
            catch
            {
                throw;
            }
            return result;
        }
    }

    

}
