using nauka.V2.Base;
using nauka.V2.Models;
using nauka.V2.Services.Sections;
using nauka.V2.Services.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nauka.V2.Services.Employee
{
    public class EmployeeService : BaseService
    {
        private List<Models.Section> _sections;
        private AppSettings _appSettings;
        public EmployeeService()
        {
        }

        public async Task<List<Models.Employee>> GetEmployees()
        {
            var result = default(List<Models.Employee>);
            try
            {
                Thread.Sleep(1000);

                if (_appSettings == null)
                    await InitAppSettings();

                if (_sections == null)
                    await InitSections();

                var employees = new List<V2.Models.Employee>
                {
                    new Models.Employee
                    {
                        Id = 1,
                        LoginName = "user1",
                        Name = "name1",
                        Password = "123",
                        Surname = "user1",
                        Section = _sections.Where(p => p.Name == "Section1").FirstOrDefault(),
                        Vacation = new Vacation{
                            VacationDaysCount = _appSettings.VacationDaysCount,
                        },
                        VacationDays = new List<VacationDays>(),
                    },
                    new Models.Employee
                    {
                        Id = 2,
                        LoginName = "user2",
                        Name = "name2",
                        Password = "123",
                        Surname = "user2",
                        Section = _sections.Where(p => p.Name == "Section3").FirstOrDefault(),
                        Vacation = new Vacation{
                            VacationDaysCount = _appSettings.VacationDaysCount,
                        },
                        VacationDays = new List<VacationDays>(),
                    },
                    new Models.Employee
                    {
                        Id = 3,
                        LoginName = "user3",
                        Name = "name3",
                        Password = "123",
                        Surname = "user3",
                        Section = _sections.Where(p => p.Name == "Section2").FirstOrDefault(),
                        Vacation = new Vacation{
                            VacationDaysCount = _appSettings.VacationDaysCount,
                        },
                        VacationDays = new List<VacationDays>(),
                    },
                };

                result = employees;
            }
            catch
            {
                throw;
            }

            return await Task.FromResult(result);
        }

        private async Task InitSections()
        {
            var _sectionService = new SectionService();
            _sections = await _sectionService.GetSections();
            
            await Task.CompletedTask;
        }

        private async Task InitAppSettings()
        {
            var _settingsService = new SettingsService();
            _appSettings = await _settingsService.GetAppSettings();

            await Task.CompletedTask;
        }
    }
}
