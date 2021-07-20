using nauka.V3.Models;
using nauka.V3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Services
{
    public class VacationDaysService
    {
        private DataBaseContext _context;
        private VacationDaysRepository _repository;
        //private List<VacationDays> _vacationDays;

        public VacationDaysService(){ }

        public VacationDaysService(DataBaseContext context, VacationDaysRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        public async Task<List<VacationDays>> GetVacationDays()
        {
            if (_repository.GetVacationDays() == null)
                await GenerateVacationDays();

            return await Task.FromResult(_repository.GetVacationDays());
        }
            
        private async Task GenerateVacationDays()
        {
            DateTime year = DateTime.Now;
            var vacationDay = new VacationDays
            {
                Id = Guid.NewGuid(),
                Days = 0,
                Year = year
            };
            if (_repository.Add(vacationDay))
                _context.SaveChanges();

            await Task.CompletedTask;
        }

        public async Task<VacationDays> GetVacationDay(Guid vacationDaysId)
        {
            return await Task.FromResult(_repository.GetVacationDay(vacationDaysId));
        }
        internal async Task Add(VacationDays vacationDays)
        {
            if (_repository.Add(vacationDays))
                _context.SaveChanges();

            await Task.CompletedTask;
        }

        internal async Task Update(Guid vacationDayId, VacationDays vacationDays)
        {
            if (_repository.Update(vacationDayId, vacationDays))
                _context.SaveChanges();

            await Task.CompletedTask;
        }

        internal async Task Delete(VacationDays vacationDays)
        {
            if (_repository.Delete(vacationDays))
                _context.SaveChanges();

            await Task.CompletedTask;
        }


    }
}
