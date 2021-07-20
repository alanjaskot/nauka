using nauka.V3.Models;
using nauka.V3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Services
{
    public class VacationService
    {
        //private List<Vacation> _vacations;
        private DataBaseContext _context;
        private VacationRepository _repository;

        public VacationService(){ }

        public VacationService(DataBaseContext context, VacationRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        public async Task<List<Vacation>> GetVacations()
        {
            if (_repository.GetVacations() == null)
                await InitVacations();

            return await Task.FromResult(_repository.GetVacations());
        }
        
        internal async Task InitVacations()
        {
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now;
            end = end.AddDays(2);
            var vacation = new Vacation
            {
                Id = Guid.NewGuid(),
                Start = start,
                End = end,
                Approve = true,
                Description = "wypoczynkowy"
            };
            if (_repository.Add(vacation))
                _context.SaveChanges();


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

            /* if (_vacations == null)
                 Task.Run(async () =>
                 {
                     await InitVacations();
                 }).Wait();

             _vacations.Add(vacation);*/

            if (_repository.Add(vacation))
                _context.SaveChanges();

            await Task.CompletedTask;
        }

        internal async Task Update(Guid vacationId, Vacation vacation)
        {
            if (_repository.Update(vacationId, vacation))
                _context.SaveChanges();

            await Task.CompletedTask;
        }

        internal async Task Delete(Vacation vacation)
        {
            if (_repository.Delete(vacation))
                _context.SaveChanges();

            await Task.CompletedTask;
        }

        internal async Task<Vacation> GetVacation(Guid vacationId)
        {
            return await Task.FromResult(_repository.GetVacation(vacationId));
        }

    }
}
