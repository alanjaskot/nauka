using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nauka.V3.Repository
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private DataBaseContext _context;

        public EmployeeRepository(DataBaseContext context)
        {
            _context = context;
        }

        public bool Add(Employee employee)
        {
            var result = false;
            
            if(employee != null)
            {
                _context.Employees.Add(employee);
                result = true;
            }

            return result;
        }

        public bool Update(Guid employeeId, Employee employee)
        {
            var employeeTemp = _context.Employees.Where(e => e.Id == employeeId).FirstOrDefault();
            var result = false;
            if (employeeTemp == null)
            {
                _context.Employees.Add(employee);
                result = true;
            }
            if(employeeTemp != null)
            {
                _context.Employees.Update(employee);
                result = true;
            }

            return result;
        }

        public bool Delete(Employee employee)
        {
            var result = false;

            if(employee != null)
            {
                _context.Employees.Remove(employee);
                result = true;
            }

            return result;
        }

        public Employee GetEmployee(Guid employeeId)
        {
            return _context.Employees.Where(e => e.Id == employeeId).FirstOrDefault();
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
