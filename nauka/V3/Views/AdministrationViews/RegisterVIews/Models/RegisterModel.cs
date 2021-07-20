using nauka.V3.Models;
using nauka.V3.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Views.AdministrationViews.RegisterVIews.Models
{
    class RegisterModel
    {
        public Employee Employee { get; set; }
        private EmployeeService _service;
        private SectionService _sectionService;

        public RegisterModel()
        {
            _service = ManageService.Employees;
            _sectionService = ManageService.Sections;
        }

        internal async Task<List<Employee>> GetEmployees()
        {
            var result = default(List<Employee>);
            try
            {
                result = _service.GetEmployees().Result;
            }
            catch
            {
                throw;
            }
            return await Task.FromResult(result);
        }

        internal async Task<List<Section>> GetSections()
        {
            var result = default(List<Section>);
            try
            {
                result = _sectionService.GetSections().Result;
            }
            catch
            {
                throw;
            }
            return await Task.FromResult(result);
        }

    }
}
