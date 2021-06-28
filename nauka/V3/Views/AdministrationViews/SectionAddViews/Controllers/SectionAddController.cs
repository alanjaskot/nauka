using nauka.V3.Models;
using nauka.V3.Views.AdministrationViews.SectionAddViews.Models;
using nauka.V3.Views.SectionViews.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V3.Views.SectionViews.Controllers
{
    class SectionAddController
    {
        private readonly SectionAddView _view;
        private SectionAddModel _model;

        SectionAddController(SectionAddView sectionView)
        {
            _view = sectionView;

            Task.Run(async () =>
            {
                await InitView();
                await InitViewModel();
            }).Wait();
        }

        public Section SetSection
        {
            get
            {
                return _model.Section;
            }
            set
            {
                _model.Section = value;
            }
        }

        private async Task InitView()
        {
            _view.buttonCancel.Click += (object sender, EventArgs e) =>
            {
                _view.DialogResult = DialogResult.Cancel;
            };

            _view.buttonOk.Click += (object sender, EventArgs e) =>
            {
                if (Validate())
                {
                    AddSection();
                    _view.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Coś poszło nie tak");
                }
            };



            await Task.CompletedTask;
        }

        private async Task InitViewModel()
        {
            if (_model == null)
                _model = new SectionAddModel();

            else
                await Task.CompletedTask;
        }

       private void AddSection()
        {
            _model.Save();
        }

       private void Update()
        {
            _model.Section.Name = _view.textBoxSectionName.Text;
        }

       private bool Validate()
        {
            var result = false;

            var sectionList = _model.GetSections();

            if (!sectionList.Any(s => s.Name == _model.Section.Name))
                return true;

            return result;
        }




    }
}
