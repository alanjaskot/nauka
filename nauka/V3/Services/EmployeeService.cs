using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Services
{
    public class EmployeeService
    {
        private List<Employee> _employees;
        private List<Section> _sections;
        private List<VacationDay> _vacationDays;
        private List<Vacation> _vacations;

        public EmployeeService() { }

        public async Task<List<Employee>> GetEmployees()
        {
            if(_employees == null)
                await InitDemos();

            return _employees;
        }

        private async Task InitDemos()
        {
            if(_employees == null)
            {
                _employees = await GenerateDemos();
            }
            await Task.CompletedTask;
        }

        private async Task <List<Employee>> GenerateDemos()
        {
            var result = default(List<Employee>);
            try
            {

                if (_sections == null)
                    await InitSection();

                if (_vacations == null)
                    await InitVacation();

                if (_vacationDays == null)
                    await InitVacationDays();

                var employees = new List<Employee>
                {
                    new Employee
                    {
                        EmployeeId = Guid.NewGuid(),
                        Name = "Jan",
                        Surname = "Kowalski",
                        Username = "jkowalski",
                        Password = "123",
                        Email = "j.kowalski@aa.a",
                        Sex = 'M',
                        Section = _sections.Where(s => s.Name == "HR").FirstOrDefault(),
                        EmployeePermisson = true,
                        VacationPermisson = true,
                        Vacation = _vacations,
                        AppSettings = new AppSettings{ AvaibleVacationDays = 24 },
                        VacationDays = new List<VacationDay> { new VacationDay { VacationDays = 0 } }
                    },
                    new Employee
                    {
                        EmployeeId = Guid.NewGuid(),
                        Name = "Adam",
                        Surname = "Nowak",
                        Username = "anowak",
                        Password = "123",
                        Email = "a.nowak@aa.a",
                        Sex = 'M',
                        Section = _sections.Where(s => s.Name == "HR").FirstOrDefault(),
                        EmployeePermisson = true,
                        VacationPermisson = false,
                        Vacation = new List<Vacation>(),
                        AppSettings = new AppSettings{ AvaibleVacationDays = 24 },
                        VacationDays = new List<VacationDay> { new VacationDay { VacationDays = 0 } }
                    },
                    new Employee
                    {
                        EmployeeId = Guid.NewGuid(),
                        Name = "Jaś",
                        Surname = "Kapela",
                        Username = "jkapela",
                        Password = "321",
                        Email = "j.kapela@aa.a",
                        Sex = 'M',
                        Section = _sections.Where(s => s.Name == "IT").FirstOrDefault(),
                        EmployeePermisson = false,
                        VacationPermisson = false,
                        Vacation = new List<Vacation>(),
                        AppSettings = new AppSettings{ AvaibleVacationDays = 24 },
                        VacationDays = new List<VacationDay> { new VacationDay { VacationDays = 0 } }
                    }
                };
                result = employees;
            }
            catch
            {
                throw;
            }
            return await Task.FromResult(result);
        }

        private async Task InitSection()
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
        }

        public List<Vacation> GetVacations()
        {
            return _vacations;
            //await Task.CompletedTask;
        }

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Update(Employee employee)
        {
            int index = _employees.FindIndex(e => e.EmployeeId == employee.EmployeeId);
            _employees[index] = employee;
        }

        public void Delete(Employee employee)
        {
            _employees.Remove(employee);
        }

        public void DeleteVacation(Employee employee, Vacation vacation)
        {
            employee.Vacation.Remove(vacation);
        }
    }
}
