using nauka.V3.Models;
using nauka.V3.Resources;
using nauka.V3.Views.UserViews.VacationApplicationViews.Models;
using nauka.V3.Views.UserViews.VacationApplicationViews.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;

namespace nauka.V3.Views.UserViews.VacationApplicationViews.Controllers
{
    public class VacationApplicationController
    {
        private readonly VacationApplicationView _view;
        private VacationApplicationModel _model;

        public VacationApplicationController(VacationApplicationView view)
        {
            _view = view;

            Task.Run(async () =>
            {
                await InitViewModel();
                await InitView();              
            }).Wait();
        }

        private async Task InitView()
        {
            _view.buttonOk.Click += (object sender, EventArgs e) =>
            {
                if (Validate())
                {
                    Add();
                    _view.Close();
                }
                else
                {
                    MessageBox.Show("Proszę wypełnić wszystkie pola");
                }
            };

            _view.buttonCancel.Click += (object sender, EventArgs e) =>
            {
                if (_view.DialogResult == DialogResult.Cancel) 
                {
                    _view.Close();
                }
            };

            await Task.CompletedTask;
        }

        private async Task InitViewModel()
        {
            await DisplayDescriptions();
            if (_model == null)
                _model = new VacationApplicationModel();
            else
                await Task.FromResult(_model);
        }

        private async Task RefreshView()
        {
            _view.dateTimePickerStart.Text = _model.Vacation.Start.ToString();
            _view.dateTimePickerEnd.Text = _model.Vacation.End.ToString();
            await DisplayDescriptions();
            _view.comboBoxDescription.Items.Contains(_model.Vacation.Description);

            await Task.CompletedTask;
        }


        private bool Validate()
        {
            var result = true;
            if((_view.dateTimePickerStart.Value < DateTime.Now) || (_view.dateTimePickerEnd.Value < _view.dateTimePickerStart.Value) ||
                (_view.comboBoxDescription == null))
                result = false;
            return result;
        }

        private void Add()
        {
            var vacation = new Vacation
            {
                VacationId = Guid.NewGuid(),
                Start = _view.dateTimePickerStart.Value,
                End = _view.dateTimePickerEnd.Value,
                Description = _view.comboBoxDescription.SelectedItem.ToString(),
                Approve = false
            };
            _model.Employee.Vacation.Add(vacation);
        }

        private async Task DisplayDescriptions()
        {
            _view.comboBoxDescription.Items.Clear();
            var descriptions = VacationDescriptionList.employeeDescriptions;
            foreach (var item in descriptions)
            {
                _view.comboBoxDescription.Items.Add(item);
            }
            await Task.CompletedTask;
        }

        public Employee SetEmployee
        {
            get
            {
                return _model.Employee;
            }
            set
            {
                _model.Employee = value;
            }
        }
    }
}
