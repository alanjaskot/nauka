using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Repository
{
    public interface IVacationRepository
    {
        public bool Add(Vacation vacation);

        public bool Update(Guid vacationId, Vacation vacation);

        public bool Delete(Vacation vacation);

        public List<Vacation> GetVacations();

        public Vacation GetVacation(Guid vacationId);
    }
}
