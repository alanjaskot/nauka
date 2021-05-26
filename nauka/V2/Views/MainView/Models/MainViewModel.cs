using nauka.V2.Models;
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
            _employeeService = new EmployeeService();
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
    }
}
