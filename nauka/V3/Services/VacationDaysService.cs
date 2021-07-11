using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Services
{
    public class VacationDaysService
    {
        public VacationDay VacationDay { get; set; }

        private List<VacationDay> _vacationDays;

        public async Task<List<VacationDay>> GetVacationDays()
        {
            if (_vacationDays == null)
                await GenerateVacationDays();

            return _vacationDays;

            await Task.CompletedTask;
        }
            
        private async Task GenerateVacationDays()
        {
            _vacationDays = new List<VacationDay>();

            await Task.CompletedTask;
        }

        internal async Task Add(VacationDay vacationDays)
        {
            _vacationDays.Add(vacationDays);

            await Task.CompletedTask;
        }

        internal async Task Remove(VacationDay vacationDays)
        {
            _vacationDays.Remove(vacationDays);

            await Task.CompletedTask;
        }

    }
}
