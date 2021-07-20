using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Repository
{
    public interface IVacationDaysRepository
    {
        public bool Add(VacationDays vacationDays);

        public bool Update(Guid vacationDaysId, VacationDays vacationDays);

        public bool Delete(VacationDays vacationDays);

        public List<VacationDays> GetVacationDays();

        public VacationDays GetVacationDay(Guid vacationDaysId);
    }
}
