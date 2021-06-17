using nauka.V2.Models;
using nauka.V2.Views.VacationDays.Models;
using nauka.V2.Views.VacationDays.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V2.Views.VacationDays.Controllers
{
    class VacationDayController
    {
        private readonly VacationDaysView _view;
        private VacationDaysModel _model;

        public nauka.V2.Models.VacationDays SetVacationDays
        {
            get
            {
                return _model.VacationDays;
            }
            set
            {
                _model.VacationDays = value;
            }
        }

        public VacationDayController(VacationDaysView vacationDaysView)
        {
            _view = vacationDaysView;

            Task.Run(async () =>
            {
                await InitViewModel();
                await InitView();
            }).Wait();
        }

        private async Task InitView()
        {
            _view.buttonCancel.Click += (object sender, EventArgs e) =>
            {
                _view.DialogResult = DialogResult.Cancel;
            };
            _view.buttonOk.Click += (object sender, EventArgs e) =>
            {
                UpdateModel();
                
                AddVacationDays();
               
            };

            await Task.CompletedTask;
        }

        private async Task InitViewModel()
        {
            if(_model == null)
            { 
                _model = new VacationDaysModel(); 
            }
            else
            {
                await Task.CompletedTask;
            }
        }


        public void UpdateModel()
        {
            _model.VacationDays.Start = _view.dateTimePickerStartVacation.Value;
            _model.VacationDays.End = _view.dateTimePickerEndVacation.Value;
            _model.VacationDays.Description = (string)_view.textBoxDescription.Text;           
        }

        public void AddVacationDays()
        {
            _model.Save();
        }

        public int CountingDays()
        {
            return CountVacationDays(_view.dateTimePickerStartVacation.Value, _view.dateTimePickerEndVacation.Value);
        }

        private int CountVacationDays(DateTime from, DateTime to)
        {
            if (to < from)
                throw new ArgumentException("Wakacje nie mogą się kończyć przed.", nameof(to));

            if (to.Date == from.Date)
                return 0;

            int vacationDays = 0;
            DateTime nextDate = from;
            while (nextDate <= to.Date)
            {
                if (nextDate.DayOfWeek != DayOfWeek.Saturday && nextDate.DayOfWeek != DayOfWeek.Sunday)
                    vacationDays++;
                nextDate = nextDate.AddDays(1);
            }

            return vacationDays;
        }


    }
}
