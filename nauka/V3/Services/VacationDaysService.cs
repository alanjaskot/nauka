using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Services
{
    public class VacationDaysService
    {
        public VacationDays VacationDay { get; set; }

        private List<VacationDays> _vacationDays;

        public async Task<List<VacationDays>> GetVacationDays()
        {
            if (_vacationDays == null)
                await GenerateVacationDays();

            return _vacationDays;

            await Task.CompletedTask;
        }
            
        private async Task GenerateVacationDays()
        {
            _vacationDays = new List<VacationDays>();

            await Task.CompletedTask;
        }

        internal async Task Add(VacationDays vacationDays)
        {
            _vacationDays.Add(vacationDays);

            await Task.CompletedTask;
        }

        internal async Task Update(VacationDays vacationDays)
        {
            int vacationDaysId = _vacationDays.FindIndex(v => v.Id == vacationDays.Id);
            _vacationDays[vacationDaysId] = vacationDays;

            await Task.CompletedTask;
        }

        internal async Task Delete(VacationDays vacationDays)
        {
            _vacationDays.Remove(vacationDays);

            await Task.CompletedTask;
        }

    }
}
