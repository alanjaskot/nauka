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
        private AppSettings _appSettings;

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
               // if (_appSettings == null)
               //     await InitAppSettings();

                if (_sections == null)
                    await InitSection();

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
                        VacationPermisson = true

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
                        VacationPermisson = false

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
    }
}
