
using nauka.V3.Models;
using nauka.V3.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Views.MainViews.Model
{
    public class MainViewModel
    {
        public Employee Employee { get; set; }
        public Vacation Vacation { get; set; }
        public VacationDays VacationDays { get; set; }
        public Vacation_Employee Vacation_Employee { get; set; }
        public AppSettings AppSettings { get; set; }

        private AppSettingsService _appSettingsService;
        private EmployeeService _employeeService;
        private SectionService _sectionService;
        private VacationService _vacationService;
        private VacationDaysService _vacationDayService;
        private Vacation_EmployeeServices _vacation_EmployeeServices;

        public MainViewModel()
        {
            _employeeService = ManageService.Employees;
            _sectionService = ManageService.Sections;
            _vacationService = ManageService.Vacations;
            _vacationDayService = ManageService.VacationDays;
            _vacation_EmployeeServices = ManageService.Vacation_EmployeeServices;
            _appSettingsService = ManageService.AppSettings;
        }

        internal async Task<List<Section>> GetSections()
        {
            var result = default(List<Section>);

                result = _sectionService.GetSections().Result;

            await Task.CompletedTask;

            return await Task.FromResult(result);
        }

        internal async Task<List<VacationDays>> GetVacationDays()
        {
            var result = default(List<VacationDays>);

                result = _vacationDayService.GetVacationDays().Result;

            await Task.CompletedTask;

            return await Task.FromResult(result);
        }

        #region Vacation

        internal async Task<List<Vacation>> GetVacations()
        {
            var result = default(List<Vacation>);

                result = _vacationService.GetVacations().Result;

            return await Task.FromResult(result);
        }

        internal async Task DeleteVacation(Vacation vacation)
        {
            await _vacationService.Delete(vacation);   
        }

        internal async Task AddVacation(Vacation vacation)
        {
            await _vacationService.Add(vacation); 
        }

        #endregion

        internal async Task UpdateEmployee(Guid employeeId, Employee employee)
        {
            await _employeeService.Update(employeeId, employee);   
        }

        #region Vacation_Employee

        internal async Task<List<Vacation_Employee>> GetVacation_Employees()
        {
            return await Task.FromResult(await _vacation_EmployeeServices.GetVacation_Employees());         
        }

        internal async Task AddVacation_Employee(Vacation_Employee vacation_Employee)
        {
                await _vacation_EmployeeServices.Add(vacation_Employee);  
        }

        internal async Task DeleteVacation_Employee(Vacation_Employee vacation_Employee)
        {
            await _vacation_EmployeeServices.Delete(vacation_Employee);
        }

        #endregion

        internal async Task<AppSettings> GetAppSetting(Guid appSettingId)
        {
            return await Task.FromResult(await _appSettingsService.GetAppSetting(appSettingId));
        }
    }
}
