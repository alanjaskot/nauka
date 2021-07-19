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
        private List<VacationDays> _vacationDays;

        public VacationDaysService()
        {
            _vacationDays = new List<VacationDays>();
        }

        public async Task<List<VacationDays>> GetVacationDays()
        {
            if (_vacationDays == null)
                await GenerateVacationDays();

            return await Task.FromResult(_vacationDays);
        }
            
        private async Task GenerateVacationDays()
        {
            _vacationDays = default(List<VacationDays>);

            await Task.CompletedTask;
        }

        internal async Task Add(VacationDays vacationDays)
        {
            if (_vacationDays == null)
                _vacationDays = new List<VacationDays>();
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
