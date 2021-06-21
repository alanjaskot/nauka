using nauka.V2.Views.VacationDays.Models;
using nauka.V2.Views.VacationDays.Views;
using nauka.V2.Views.Vacations.Controllers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V2.Views.VacationDays.Controllers
{
    class VacationDayController
    {
        private readonly VacationDaysView _view;
        private VacationDaysModel _model;
        private VacationController _vacationController;

        public V2.Models.VacationDays SetVacationDays
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
            DataGridList();
            RefreshList();

            _view.buttonCancel.Click += (object sender, EventArgs e) =>
            {
                _view.DialogResult = DialogResult.Cancel;
            };
            _view.buttonOk.Click += (object sender, EventArgs e) =>
            {
                if (!ValidateDays())
                {
                    UpdateModel();
                    RefreshList();
                    Add();
                    _vacationController.SetVacationDaysCount
                    (CountVacationDays(_view.dateTimePickerStartVacation.Value, _view.dateTimePickerEndVacation.Value));
                    _view.DialogResult = DialogResult.OK;
                }              
            };

            _view.buttonDelete.Click += (object sender, EventArgs e) =>
            {
                Delete(_view.dataGridViewVacationDays.CurrentRow.Index);
            };

            _view.buttonEdit.Click += (object sender, EventArgs e) =>
            {
                Edit(_view.dataGridViewVacationDays.CurrentRow.Index);
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

        public void Delete(int selectedVacationDays)
        {
            DataGridViewRow row = _view.dataGridViewVacationDays.Rows[selectedVacationDays];
            _model.VacationDays.Description = row.Cells[0].Value.ToString();
            _model.VacationDays.Start = DateTime.Parse(row.Cells[1].Value.ToString());
            _model.VacationDays.End = DateTime.Parse(row.Cells[2].Value.ToString());
            _model.Delete();

            RefreshList();
        }

        public void Add()
        {
            _model.Save();
        }

        public void Edit(int selectedVacationDays)
        {
            const string message = "Czy na pewno chcesz zmienić termin urlopu?";
            const string caption = "Edycja urlopu";

            MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            DataGridViewRow row = _view.dataGridViewVacationDays.Rows[selectedVacationDays];

            Delete(selectedVacationDays);

            _model.VacationDays.Description = _view.textBoxDescription.Text;
            _model.VacationDays.Start = _view.dateTimePickerEndVacation.Value;
            _model.VacationDays.End = _view.dateTimePickerEndVacation.Value;
            Add();

            RefreshList();
        }

        private bool ValidateDays()
        {
            var result = false;
            var start = _view.dateTimePickerStartVacation.Value;
            var end = _view.dateTimePickerEndVacation.Value;
            if (end < start)
            {
                MessageBox.Show($"Wakacje nie mogą się kończyć przed {start}.");
                result = false;
            }

            var VacationDaysList = _model.GetVacationDays();

            if (!result)
            {
                foreach (var item in VacationDaysList)
                {
                    if ((start >= item.Start) && (start <= item.End))
                    {
                        result = true;
                        MessageBox.Show("Urlop pokrywa się z innym urlopem");
                        break;
                    }

                    if ((end >= item.Start) && (end <= item.End))
                    {
                        result = true;
                        MessageBox.Show("Urlop pokrywa się z innym urlopem");
                        break;
                    }
                }             
            }
            
            return result;
        }

        private long CountVacationDays(DateTime from, DateTime to)
        {
            if (to < from)
                throw new ArgumentException("Wakacje nie mogą się kończyć przed.", nameof(to));

            if (to.Date == from.Date)
                return 1;

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

        public async Task DataGridList()
        {
            var detailDGV = _view.dataGridViewVacationDays;
            
            var dgvTextColumn = default(DataGridViewColumn);
           
            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "opis";
            dgvTextColumn.Name = "Description";
            dgvTextColumn.DataPropertyName = "Description";
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);
            
            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "od";
            dgvTextColumn.Name = "Start";
            dgvTextColumn.DataPropertyName = "Start";
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);
            
            dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.HeaderText = "do";
            dgvTextColumn.Name = "End";
            dgvTextColumn.DataPropertyName = "End";
            dgvTextColumn.Visible = true;
            detailDGV.Columns.Add(dgvTextColumn);

            await Task.CompletedTask;
        }

        private void RefreshList()
        {
            _view.dataGridViewVacationDays.Rows.Clear();
            var vacationDaysList = _model.GetVacationDays();
            foreach (var item in vacationDaysList)
            {
                string[] vacationDaysInsert =
                {
                    item.Description.ToString(),
                    item.Start.ToString("dd.MM.yyyy"),
                    item.End.ToString("dd.MM.yyyy"),
                    
                };
                _view.dataGridViewVacationDays.Rows.Add(vacationDaysInsert);
            }
        }

    }
}
