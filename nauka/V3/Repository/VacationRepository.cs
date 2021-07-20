using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nauka.V3.Repository
{
    public class VacationRepository: IVacationRepository
    {
        DataBaseContext _context;

        public VacationRepository(DataBaseContext context)
        {
            _context = context;
        }

        public bool Add(Vacation vacation)
        {
            var result = false;         
           if(vacation != null)
            {
                _context.Vacations.Add(vacation);
                result = true;
            }

            return result;
        }

        public bool Update(Guid vacationId, Vacation vacation)
        {
            var vacationTemp = _context.Vacations.Where(v => v.Id == vacationId).FirstOrDefault();
            var result = false;
            if(vacationTemp == null)
            {
                _context.Vacations.Add(vacation);
                result = true;
            }
            if(vacationTemp != null)
            {
                _context.Vacations.Update(vacation);
                result = true;
            }

            return result;
        }

        public bool Delete(Vacation vacation)
        {
            var result = false;

            if (vacation != null)
            {
                _context.Vacations.Remove(vacation);
                result = true;
            }
            return result;
        }

        public Vacation GetVacation(Guid vacationId)
        {
            return _context.Vacations.Where(v => v.Id == vacationId).FirstOrDefault();
        }

        public List<Vacation> GetVacations()
        {
            return _context.Vacations.ToList();
        }
    }
}
