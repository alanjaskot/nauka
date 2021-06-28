
using nauka.V3.Models;
using nauka.V3.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Views.MainViews.Model
{
    public class MainViewModel
    {
        private EmployeeService _employeeService;
        private SectionService _sectionService;

        public MainViewModel()
        {
            _employeeService = ManageService.Employees;
        }

        public Employee Employee { get; set; }

        internal List<Section> GetSections()
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
            return result;
        }
    }
}
