using nauka.V3.Models;
using nauka.V3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nauka.V3.Services
{
    public class EmployeeService
    {
        /*private List<Employee> _employees;
        private List<Section> _sections;
        private List<VacationDays> _vacationDays;
        private List<Vacation> _vacations;*/


        private DataBaseContext _context;
        private EmployeeRepository _repository;

        public EmployeeService(){ }

        public EmployeeService(DataBaseContext context, EmployeeRepository repository) 
        {
            _context = context;
            _repository = repository;
        }

        public async Task Add(Employee employee)
        {
            if (_repository.Add(employee))
                _context.SaveChanges();
            await Task.CompletedTask;
        }

        public async Task Update(Guid employeeId, Employee employee)
        {
            if (_repository.Update(employeeId, employee))
                _context.SaveChanges();

            await Task.CompletedTask;
        }

        public async Task Delete(Employee employee)
        {
            if (_repository.Delete(employee))
                _context.SaveChanges();

            await Task.CompletedTask;
        }

        public async Task<Employee> GetEmployee(Guid employeeId)
        {
            return await Task.FromResult(_repository.GetEmployee(employeeId));
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await Task.FromResult(_repository.GetEmployees());
        }
    }
}
