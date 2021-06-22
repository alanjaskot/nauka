using nauka.V2.Models;
using nauka.V2.Services;
using nauka.V2.Services.Vacations;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V2.Views.Vacations.Models
{
    class VacationModel
    {
        private VacationService _vacationService;


        /// <summary>
        /// tu masz konstruktor z parametrem
        /// </summary>
        /// <param name="vacationService"></param>
        public VacationModel()
        {
            _vacationService = ServiceManager.Vacations;
        }

        /// <summary>
        /// tu masz domyslny wiec pewnie robisz new bez parametru
        /// zakyc co chcesz osiagnac 
        /// lapiej brac domyslny 
        /// 
        /// </summary>
        //public VacationModel() { }

        public Vacation Vacation { get; set; }

        public List<Vacation> GetVacations()
        {
            var result = default(List<Vacation>);
            try
            {
                result = _vacationService.GetVacations().Result;
            }
            catch
            {
                throw;
            }
            return result;
        }

        internal void Save()
        {
            _vacationService.AddVacation(Vacation);
        }

        internal void Delete()
        {
            _vacationService.RemoveVacation(Vacation);
        }
    }
}
