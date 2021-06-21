using nauka.V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V2.Services.VacationDays
{
    public class VacationsDaysService
    {
        private List<Models.VacationDays> _vacationDays;
        public VacationsDaysService() { }

        public async Task<List<Models.VacationDays>> GetVacationDays()
        {
            
            if (_vacationDays == null)
               await InitVacationDays();

            return await Task.FromResult(_vacationDays);
        }

        private async Task<List<Models.VacationDays>> InitVacationDays()
        {
            _vacationDays = new List<Models.VacationDays>
            {
                new Models.VacationDays
                {
                    Start = DateTime.Parse("20.06.2021"),
                    End = DateTime.Parse("25.06.2021"),
                    Description = "Wyjazd na basen"
                }
            };

            return await Task.FromResult(_vacationDays);
        }

        public void Add(Models.VacationDays vacationDays)
        {
            _vacationDays.Add(vacationDays);
        }

        public void Remove(Models.VacationDays vacationDays)
        {
            // tu pewnie masz inny obiekt
            // jak uzywasz listy to wpier musisz znalesc obiekt z listy zeby go osunac 
            // to na dole ze zapytanie w technologi linq 
            //mozesz sobie poczytac o tym 
            // jeszcze cos ?? 
            //edycje tez tak zrobic, prawda?
            //tak dokladnie tak same wszysto robisz tak samo, jak robie jednym sposobme to potem robisz tak caly czaas 
            // musi byc spojne podejscie 
            //ok, wielkie dzieki, to robie dalej :)
            var itemToRemove = _vacationDays
                .Where(p =>
                    p.Description == vacationDays.Description &&
                    p.End == vacationDays.End &&
                    p.Start == vacationDays.Start)
                .FirstOrDefault();

            if(itemToRemove == null)
            {
                MessageBox.Show("Nieznaleziono");
                return;
            }
            
            _vacationDays.Remove(itemToRemove);
        }
                        
    }
}
