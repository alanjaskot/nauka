using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Services
{
    public class SectionService
    {
        private List<Section> _sections;
        public SectionService() { }

        public async Task<List<Section>> GetSections()
        {
            if (_sections == null)
                await InitSections();

            return await Task.FromResult(_sections);
        }

        private async Task InitSections()
        {
            var sections = new List<Section>
            {
                new Section
                {
                    SectionId = Guid.NewGuid(),
                    Name = "HR"
                },
                new Section
                {
                    SectionId = Guid.NewGuid(),
                    Name = "IT"
                }
            };

            _sections = sections;

            await Task.CompletedTask;
        }

        public void Add(Section section)
        {
            _sections.Add(section);
        }

        public void Delete (Section section)
        {
            _sections.Remove(section);
        }
    }
}
