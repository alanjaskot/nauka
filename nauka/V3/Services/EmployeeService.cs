using nauka.V3.Models;
using nauka.V3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        private async Task InitDemos()
        {
            if(_repository.GetEmployees() == null)
                await GenerateDemos();
            
            await Task.CompletedTask;
        }

        private async Task GenerateDemos()
        {
            try
            {

                /*if (_sections == null)
                    await InitSection();

                if (_vacations == null)
                    await InitVacation();

                if (_vacationDays == null)
                    await InitVacationDays();*/


                var employee = new Employee
                    {
                        Id = Guid.NewGuid(),
                        Name = "Jan",
                        Surname = "Kowalski",
                        Username = "jkowalski",
                        Password = "123",
                        Email = "j.kowalski@aa.a",
                        Sex = 'M',
                        Section = _context.Sections.Where(s => s.Name == "HR").FirstOrDefault(),
                        EmployeePermisson = true,
                        VacationPermisson = true,
                        AppSettings = new AppSettings{ AvaibleVacationDays =24 },

                };
                if (_repository.Add(employee))
                    _context.SaveChanges();
            }
            catch
            {
                throw;
            }
            await Task.CompletedTask;
        }

       /* private async Task InitSection()
        {
            var _sectionService = new SectionService();
            _sections = await _sectionService.GetSections();

            await Task.CompletedTask;
        }

        private async Task InitVacationDays()
        {
            var _vacationDaysService = new VacationDaysService();
            _vacationDays = await _vacationDaysService.GetVacationDays();

            await Task.CompletedTask;
        }

        private async Task InitVacation()
        {
            var _vacationService = new VacationService();
            _vacations = await _vacationService.GetVacations() ;

            await Task.CompletedTask;
        }*/

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
            if (_repository.GetEmployees() == null)
                await InitDemos();

            return await Task.FromResult(_repository.GetEmployees());
        }
    }
}
