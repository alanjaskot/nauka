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
            result = new List<Vacation>{};
            _vacations = result;

            await Task.CompletedTask;
        }
            
        internal async Task Add(Vacation vacation)
        {
            //  aczemu nie zadziaalo oddanie 
            // robisz juz update 
            // a gdzie dodanie 
            // problemem jest na pacztek ze nie dodaje sie add 
            // gdzie to oddajesz
            //moj blad, ja przypisuje odrazu wakacje do pracownika przy dodawaniu
            // czyli bledna logica 
            //  masz dodac wakacje 
            // i id wakacje dodac do pracowanika 
            // ?? 
            //ok, juz rozumiem to juz wiem co trzeba zrobic, moge jeszcze pokazac druga rzecz?
            // ok pokaz

            if (_vacations == null)
                Task.Run(async () =>
                {
                    await InitVacations();
                }).Wait();

            _vacations.Add(vacation);

            await Task.CompletedTask;
        }

        internal async Task Update(Vacation vacation)
        {
            int vacationIndex = _vacations.FindIndex(v => v.Id == vacation.Id);
            _vacations[vacationIndex] = vacation;

            await Task.CompletedTask;
        }

        internal async Task Delete(Vacation vacation)
        {
            _vacations.Remove(vacation);

            await Task.CompletedTask;
        }

    }
}
