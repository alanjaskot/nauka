using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Services
{
    public class VacationService
    {
        private List<Vacation> _vacations;
        public VacationService(){}

        public async Task<List<Vacation>> GetVacations()
        {
            if (_vacations == null)
                await InitVacations();

            return await Task.FromResult(_vacations);
        }

        internal async Task InitVacations()
        {
            var result = default(List<Vacation>);
            result = new List<Vacation>
                {
                    new Vacation()
                    {
                        Id = Guid.NewGuid(),
                        Start = DateTime.Parse("01.08.2021"),
                        End = DateTime.Parse("10.08.2021"),
                        Description = "wypoczynkowy",
                        Approve = true
                    }
                };
            _vacations = result;

            await Task.CompletedTask;
        }
            
        internal void Add(Vacation vacation)
        {
            if (_vacations != null)
                _vacations.Add(vacation);

        }

        internal void Update(Vacation vacation)
        {
            var vacationId = _vacations.Where(v => v.Id == vacation.Id).FirstOrDefault();
            _vacations.Remove(vacationId);
            _vacations.Add(vacation);
        }

        internal void Delete(Vacation vacation)
        {
            _vacations.Remove(vacation);
        }

    }
}
