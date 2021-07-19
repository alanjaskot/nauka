using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
                    Id = Guid.NewGuid(),
                    Name = "HR"
                },
                new Section
                {
                    Id = Guid.NewGuid(),
                    Name = "IT"
                }
            };

            _sections = sections;

            await Task.CompletedTask;
        }

        public async Task Add(Section section)
        {
            _sections.Add(section);

            await Task.CompletedTask;
        }

        public async Task Update(Section section)
        {
            int sectionId = _sections.FindIndex(s => s.Id == section.Id);
            _sections[sectionId] = section;

            await Task.CompletedTask;
        }

        public async Task Delete (Section section)
        {
            _sections.Remove(section);
            await Task.CompletedTask;
        }
    }
}
