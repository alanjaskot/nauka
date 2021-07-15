using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Repository
{
    public interface ISectionRepository
    {
        public bool Add(Section section);
        public bool Update(Section section);
        public bool Delete(Guid sectionId);

        public Section GetSection(Guid sectionID);

        public List<Section> GetSections();
    }
}
