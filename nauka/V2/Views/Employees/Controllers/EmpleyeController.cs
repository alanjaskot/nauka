using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using nauka.V2.Models;
using nauka.V2.Services.Sections;
using nauka.V2.Views.Employees.Models;
using nauka.V2.Views.Employees.Views;
using nauka.V2.Views.Sections.Views;

namespace nauka.V2.Views.Employees.Controllers
{
    public class EmpleyeController
    {
        private readonly EmployeeView _view;
        private EmployeModel _model;
        
        public EmpleyeController(EmployeeView employeeView)
        {
            _view= employeeView;
            
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
                if (!ValidateModel())
                    return;

                _view.DialogResult = DialogResult.OK;
            };

            _view.buttonAddSection.Click += (object sender, EventArgs e) =>
            {
                AddNewSection();
            };

            _view.Load += (object sender, EventArgs e) =>
            {
                RefreshView();

                RefresSection();
            };

            await Task.CompletedTask;
        }

        private async Task InitViewModel()
        {

            //to ma byc zawsze inicjacja 
            // dbez if 
            //if (_model == null)
           // {
                _model = new EmployeModel();
            //} 

            await Task.CompletedTask;
        }

        public Employee SetEployee
        {
            get
            {
                UpdateModel();

                return _model.Employee;
            }
            set
            {
                if (value == null)
                    return;

                _model.Employee = value;

                RefreshView();
            }
        }

        private bool ValidateModel()
        {
            var result = true;

            if (result)
            {
                if (_view.comboBoxSection.SelectedIndex == 0)
                {
                    MessageBox.Show("Wybierz sekcje");
                    result = false;
                }
            }

            if (result)
            {
                var sectionList = _model.GetSections();

                var sectionText = (string)_view.comboBoxSection.SelectedItem;

                var section = sectionList.Where(p => p.Name == sectionText).FirstOrDefault();

                if (section == null)
                {
                    MessageBox.Show("Błąd sekcji");
                    result = false;
                }
            }

            return result;
        }

        private void UpdateModel()
        {
            _model.Employee.Name = _view.textBoxName.Text;
            _model.Employee.Surname = _view.textBoxSurname.Text;
            _model.Employee.LoginName = _view.textBoxLogin.Text;
            _model.Employee.Password = _view.textBoxPassword.Text;

            var sectionList = _model.GetSections();

            var section = sectionList.Where(p => p.Name == (string)_view.comboBoxSection.SelectedItem).FirstOrDefault();

            if (section != null)
                _model.Employee.Section = section;
        }

        private void RefreshView()
        {
            RefresSection();

            _view.textBoxName.Text = _model.Employee.Name;
            _view.textBoxSurname.Text = _model.Employee.Surname;
            _view.textBoxLogin.Text = _model.Employee.LoginName;
            _view.textBoxPassword.Text = _model.Employee.Password;
            if(_model.Employee.Section != null)
                _view.comboBoxSection.SelectedText = _model.Employee.Section.Name;
        }

        private void RefresSection()
        {
            _view.comboBoxSection.Items.Clear();
            _view.comboBoxSection.Items.Add("-- wybierz --");

            var sectionList = _model.GetSections();

            foreach (var item in sectionList)
            {
                _view.comboBoxSection.Items.Add(item.Name);
            }

            _view.comboBoxSection.SelectedIndex = 0;
        }

        private void AddNewSection()
        {
            UpdateModel(); 
         
            var newSection = new Section();
            var view = new SectionView();
            view.SetObjectToEdit = newSection;

            if (view.ShowDialog() == DialogResult.OK)
            {
                RefreshView();
                _view.comboBoxSection.SelectedIndex = _view.comboBoxSection.Items.IndexOf(newSection.Name); 
            }
        }

        
    }
}
