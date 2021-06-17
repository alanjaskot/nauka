using nauka.V2.Base;
using nauka.V2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nauka.V2.Services.Sections
{
    public class SectionService : BaseService
    {
        private List<Section> _sections;
        public SectionService()
        {   
        }

        private async Task InitSections()
        {
            Thread.Sleep(1000);

            var sections = new List<Section>
            {
                new Section
                {
                    Name = "Section1",
                },
                
                new Section
                {
                    Name = "Section2",
                },
                
                new Section
                {
                    Name = "Section3",
                },

            };

            _sections = sections;
            
            await Task.CompletedTask;
        }

        public void AddSection(Section section)
        { 
            _sections.Add(section);
        }
 
        public async Task<List<Section>> GetSections()
        {
            Thread.Sleep(1000);

            if (_sections == null)
                await InitSections();

            return await Task.FromResult(_sections);
        }

        
    }
}
