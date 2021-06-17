using nauka.V2.Models;
using nauka.V2.Services;
using nauka.V2.Services.Employee;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V2.Views.MainView.Models
{
    public class MainViewModel
    {
        private readonly EmployeeService _employeeService;

        public MainViewModel()
        {
            _employeeService = ServiceManager.Employees;
        }

        public async Task<List <Employee>> GetEmployees()
        {
            var result = default(List<Employee>);

            try
            {
                result = await _employeeService.GetEmployees();
            }
            catch
            {
                throw;
            }

            return result;
        }

        internal async Task Add(Employee employee)
        {
            await _employeeService.Add(employee);
        }
    }
}
