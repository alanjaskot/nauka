using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nauka.V2.Services.VacationDays
{
    public class VacationsDaysService
    {
        private List<Models.VacationDays> _vacationDays;
        public VacationsDaysService() { }

        public List<Models.VacationDays> GetVacationDays()
        {
            
            if (_vacationDays == null)
               InitList();

            return _vacationDays;
        }

        private async Task<List<Models.VacationDays>> InitVacationDays()
        {
            _vacationDays = new List<Models.VacationDays>();
            return await Task.FromResult(_vacationDays);
        }

        public void Add(Models.VacationDays vacationDays)
        {
            var ddd = vacationDays;
            _vacationDays.Add(vacationDays);
        }

        public void Remove(Models.VacationDays vacationDays)
        {
            _vacationDays.Remove(vacationDays);
        }

        public void InitList()
        {
            var newList = new List<Models.VacationDays>
            {
                new Models.VacationDays
                {
                    Start = DateTime.Parse("20.06.2021"),
                    End = DateTime.Parse("25.06.2021"),
                    Description = "Wyjazd na basen"
                },
            };
        }

        
    }
}
