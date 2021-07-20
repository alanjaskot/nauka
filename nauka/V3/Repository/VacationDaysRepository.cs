using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nauka.V3.Repository
{
    public class VacationDaysRepository : IVacationDaysRepository
    {
        private DataBaseContext _context;
        public VacationDaysRepository(DataBaseContext context)
        {
            _context = context;
        }

        public bool Add(VacationDays vacationDays)
        {
            var result = false;
            if (vacationDays != null)
            {
                _context.VacationDays.Add(vacationDays);
                result = true;
            }
            
            return result;
        }

        public bool Update(Guid vacationDaysId, VacationDays vacationDays)
        {
            var result = false;
            var vacationTemp = _context.VacationDays.Where(v => v.Id == vacationDaysId).FirstOrDefault();
            
            if(vacationTemp == null)
            {
                _context.VacationDays.Add(vacationDays);
                result = true;
            }
            if(vacationTemp != null)
            {
                _context.VacationDays.Update(vacationDays);
                result = true;
            }
            
            return result;
        }

        public bool Delete(VacationDays vacationDays)
        {
            var result = false;
            if(vacationDays != null)
            {
                _context.VacationDays.Remove(vacationDays);
                result = true;
            }

            return result;
        }

        public VacationDays GetVacationDay(Guid vacationId)
        {
            return _context.VacationDays.Where(v => v.Id == vacationId).FirstOrDefault();
        }

        public List<VacationDays> GetVacationDays()
        {
            return _context.VacationDays.ToList();
        }

    }
}
