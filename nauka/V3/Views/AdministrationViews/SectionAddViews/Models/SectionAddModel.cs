using nauka.V3.Models;
using nauka.V3.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Views.AdministrationViews.SectionAddViews.Models
{
    class SectionAddModel
    {
        private readonly SectionService _sectionService;

        public SectionAddModel()
        {
            _sectionService = ManageService.Sections;
        }

        public Section Section { get; set; }

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

        internal void Save()
        {
            _sectionService.Add(Section);
        }

        internal void Delete()
        {
            _sectionService.Delete(Section);
        }
    }
}
