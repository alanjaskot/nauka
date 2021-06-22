using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nauka.V2.Base;
using nauka.V2.Models;
using nauka.V2.Services.VacationDays;

namespace nauka.V2.Services.Vacations
{
    public class VacationService : BaseService
    {
        private VacationsDaysService _vacationDaysService;
        private List<Vacation> _vacations;
        public VacationService()
        {
        }


        // dobra pokaze ci jeszcze cos 
        // do kazdego obiektu ktory chcesz zapamietac dodasz unikalne id, bedzie to szlo potem uzuc do bazy dnayhch 

        public void SumVacation()
        {
            var vacationDaysList = _vacationDaysService.GetVacationDays();
            /*
            foreach (item in vacationDaysList)
            {
                item
            }
            */
        }

        
        public void AddVacation(Vacation vacation)
        {
            
            _vacations.Add(vacation);
        }

        public void RemoveVacation(Vacation vacation)
        {
            _vacations.Remove(vacation);
        }

        public void EditVacation(int id)
        {
            
        }

        public async Task<List<Vacation>> GetVacations()
        {
            Thread.Sleep(1000);
            if (_vacations == null)
            {
                await InitVacation();
            }

            return await Task.FromResult(_vacations);
        }

        public async Task InitVacation()
        {
            Thread.Sleep(1000);

            var vacation = new List<Vacation>
            {
                new Vacation
                {
                    VacationDaysCount = 1
                },
                new Vacation
                {
                    VacationDaysCount = 3
                }
            };

            _vacations = vacation;

            await Task.CompletedTask;
        }

    }
}
