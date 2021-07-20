using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nauka.V3.Repository
{
    public class SectionRepository: ISectionRepository
    {
        DataBaseContext _context;
        public SectionRepository(DataBaseContext context)
        {
            _context = context;
        }

        public bool Add(Section section)
        {
            var result = false;
            if(section != null)
            {
                _context.Sections.Add(section);
                result = true;
            }   

            return result;
        }

        public bool Update(Guid sectionId, Section section)
        {
            var result = false;
            var sectionTemp = _context.Sections.Where(s => s.Id == sectionId).FirstOrDefault();
            if(sectionTemp == null)
            {
                _context.Sections.Add(section);
                result = true;
            }
            if(sectionTemp != null)
            {
                _context.Sections.Update(section);
                result = true;
            }

            return result;
        }

        public bool Delete(Section section)
        {
            var result = false;
                        
            if (section != null)
            {
                _context.Sections.Remove(section);
                result = true;
            }

            return result;
        }

        public Section GetSection(Guid guid)
        {
            return _context.Sections.Where(s => s.Id == guid).FirstOrDefault();

        }

        public List<Section> GetSections()
        {
            return _context.Sections.ToList();
        }
    }
}
