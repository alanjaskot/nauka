using nauka.V3.Models;
using nauka.V3.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Services
{
    public class Vacation_EmployeeServices
    {
        private Vacation_EmployeeRepository _repository;
        private DataBaseContext _context;

        public Vacation_EmployeeServices() { }

        public Vacation_EmployeeServices(DataBaseContext context, Vacation_EmployeeRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        public async Task Add(Vacation_Employee vacation_Employee)
        {
            if(_repository.Add(vacation_Employee))
                _context.SaveChanges();

            await Task.CompletedTask;
        }

        public async Task Delete(Vacation_Employee vacation_Employee)
        {
            if (_repository.Delete(vacation_Employee))
                _context.SaveChanges();

            await Task.CompletedTask;
        }

        public async Task<List<Vacation_Employee>> GetVacation_Employees()
        {
            return await Task.FromResult(_repository.GetVacationOfEmployees());
        }

        public async Task<Vacation_Employee> GetVacation_Employee(Guid vacation_employeeId, Guid employeeId)
        {
            return await Task.FromResult(_repository.GetVacationOfEmployee(vacation_employeeId, employeeId));
        }

    }
}
