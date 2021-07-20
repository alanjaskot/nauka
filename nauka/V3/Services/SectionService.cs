using nauka.V3.Models;
using nauka.V3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Services
{
    public class SectionService
    {
        //private List<Section> _sections;
        private SectionRepository _repository;
        private DataBaseContext _context;

        public SectionService(){ }

        public SectionService(DataBaseContext context, SectionRepository repository) 
        {
            _repository = repository;
            _context = context;
        }

        public async Task<List<Section>> GetSections()
        {
            if (_repository.GetSections() == null)
                await InitSections();

            return await Task.FromResult(_repository.GetSections());
        }

        private async Task InitSections()
        {
            var section = new Section
            {
                    Id = Guid.NewGuid(),
                    Name = "HR"
            };
            if (_repository.Add(section))
                _context.SaveChanges();

            await Task.CompletedTask;
        }

        public async Task Add(Section section)
        {
            if (_repository.Add(section))
                _context.SaveChanges();

            await Task.CompletedTask;
        }

        public async Task Update(Guid sectionId, Section section)
        {

            if (_repository.Update(sectionId, section))
                _context.SaveChanges();

            await Task.CompletedTask;
        }

        public async Task Delete (Section section)
        {
            if (_repository.Delete(section))
                _context.SaveChanges();
            await Task.CompletedTask;
        }

        public async Task<Section> GetSection(Guid sectionId)
        {
            return await Task.FromResult(_repository.GetSection(sectionId));
        }
    }
}
