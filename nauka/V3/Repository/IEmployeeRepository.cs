using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Repository
{
    public interface IEmployeeRepository
    {
        public bool Add(Employee employee);
        public bool Update(Guid employeeId, Employee employee);
        public bool Delete(Employee employee);
        public Employee GetEmployee(Guid employeeId);
        public List<Employee> GetEmployees();
    }
}
