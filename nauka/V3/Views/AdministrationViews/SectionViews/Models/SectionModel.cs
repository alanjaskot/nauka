using nauka.V3.Models;
using nauka.V3.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Views.AdministrationViews.SectionViews.Models
{
    class SectionModel
    {
        private readonly SectionService _sectionService;

        public SectionModel()
        {
            _sectionService = ManageService.Sections;
        }

        public Section Section { get; set; }

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
