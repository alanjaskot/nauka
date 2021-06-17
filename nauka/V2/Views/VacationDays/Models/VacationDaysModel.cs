using nauka.V2.Services;
using nauka.V2.Services.VacationDays;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V2.Views.VacationDays.Models
{
    class VacationDaysModel
    {
        private VacationsDaysService _vacationsDaysService;

        public VacationDaysModel()
        {
            _vacationsDaysService = ServiceManager.VacationDays;
        }

        public V2.Models.VacationDays VacationDays { get; set; }

        internal List<V2.Models.VacationDays> GetVacationDays()
        {
            var result = default(List<V2.Models.VacationDays>);
            try
            {
                result = _vacationsDaysService.GetVacationDays(); //.Result;
            }
            catch
            {
                throw;
            }
            return result;
        }

        internal void Save()
        {
            _vacationsDaysService.Add(VacationDays);
        }

        internal void Delete()
        {
            _vacationsDaysService.Remove(VacationDays);
        }
    }
}
