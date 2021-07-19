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
            await DisplayDescriptions();

            _view.buttonOk.Click += (object sender, EventArgs e) =>
            {
                if (Validate())
                {
                    RefreshModel();
                    _model.Employee.VacationId.Add(_model.Vacation.Id);
                    _model.Add(_model.Vacation, _model.Employee);
                    _view.Close();
                }
                else
                {
                    MessageBox.Show("Proszę wypełnić wszystkie pola");
                }
            };

            _view.buttonCancel.Click += (object sender, EventArgs e) =>
            {
                _view.Close();
            };

            await Task.CompletedTask;
        }

        private async Task InitViewModel()
        {    
            _model = new VacationApplicationModel();
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

        private void RefreshModel()
        {
            _model.Vacation.Id = Guid.NewGuid();
            _model.Vacation.Start = _view.dateTimePickerStart.Value;
            _model.Vacation.End = _view.dateTimePickerEnd.Value;
            _model.Vacation.Description = _view.comboBoxDescription.SelectedItem.ToString();
            _model.Vacation.Approve = false;            
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
