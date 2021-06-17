using nauka.V2.Models;
using nauka.V2.Services;
using nauka.V2.Services.Sections;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V2.Views.Employees.Models
{
    public class EmployeModel
    {
        private SectionService _sectionService;

        public EmployeModel()
        {
            _sectionService = ServiceManager.Sections;
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
