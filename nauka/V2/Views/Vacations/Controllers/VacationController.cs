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

            _view.buttonMenagerVacations.Click += (object sender, EventArgs e) =>
            {
                MenageVacationDays();
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

        private void MenageVacationDays()
        {
            var newVacationDays = new V2.Models.VacationDays();
            var view = new VacationDaysView();
            view.SetObjectToEdit = newVacationDays;

            if (view.ShowDialog() == DialogResult.OK)
            {
                //_model.Save();
            }
        }

        public void SetVacationDaysCount(long days)
        {
            _model.Vacation.VacationDaysCount = days;
            AddVacation();
        }

        public void AddVacation()
        {
            _model.Save();
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
