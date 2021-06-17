using nauka.V2.Models;
using nauka.V2.Views.VacationDays.Controllers;
using nauka.V2.Views.VacationDays.Views;
using nauka.V2.Views.Vacations.Models;
using nauka.V2.Views.Vacations.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V2.Views.Vacations.Controllers
{
    class VacationController
    {
        private readonly VacationView _view;
        private VacationModel _model;
        private VacationDayController _vacationDayController;

        public Vacation SetVacation
        {
            get
            {
                return _model.Vacation;
            }
            set
            {
                _model.Vacation = value;
            }
        }
        public VacationController(VacationView vacationView)
        {
            _view = vacationView;

            Task.Run(async () =>
            {
                await InitViewModel();
                await InitView();
            }).Wait();
        }

        private async Task InitView()
        {
            RefreshView();

            _view.buttonCancel.Click += (object sender, EventArgs e) =>
            {
                _view.DialogResult = DialogResult.Cancel;
            };

            _view.buttonOk.Click += (object sender, EventArgs e) =>
            {
                _view.DialogResult = DialogResult.OK;
            };

            _view.buttonNew.Click += (object sender, EventArgs e) =>
            {
                AddVacationDays();
            };

            await Task.CompletedTask;
        }

        private async Task InitViewModel()
        {
            if (_model == null)
                _model = new VacationModel();
            
            else
                await Task.CompletedTask;

            RefreshView();
        }

        private void AddVacationDays()
        {
            var newVacationDays = new V2.Models.VacationDays();
            var view = new VacationDaysView();
            view.SetObjectToEdit = newVacationDays;

            if (view.ShowDialog() == DialogResult.OK)
            {
                long newDays = _vacationDayController.CountingDays();
                _model.Vacation.VacationDaysCount += newDays; ;
            }
        }

        public void RefreshView()
        {
            long usedDays = 0;
            var vacationCountDays = _model.GetVacations();
            foreach (var item in vacationCountDays)
            {
                usedDays = item.VacationDaysCount;
                usedDays += usedDays;
            }
            long restOfDays = 26 - usedDays;
            _view.labelShowDays.Text = restOfDays.ToString();
        }

        /*public void RefreshView()
        {
            var vacationList = _model.GetVacations();

            foreach (var item in vacationList)
            {
                _view.listViewVacations.Items.Add(item.VacationDaysCount.ToString());
            }

        }*/
    }

    
}
