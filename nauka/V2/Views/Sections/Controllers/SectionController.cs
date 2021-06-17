using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using nauka.V2.Views.Sections.Views;
using nauka.V2.Views.Sections.Models;
using nauka.V2.Services.Sections;
using nauka.V2.Models;
using System.Linq;

namespace nauka.V2.Views.Sections.Controllers
{
    class SectionController
    {
        private readonly SectionView _view;
        private SectionModel _model;

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

        public SectionController(SectionView sectionView)
        {
            _view = sectionView;
            
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

            _view.buttonNewSection.Click += (object sender, EventArgs e) =>
            {
                UpdateModel();

                if (Validate())
                {
                    _model.Save();

                    _view.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Podana sekcja już istnieje");
                }
            };

            _view.Load += (object sender, EventArgs e) =>
            {
                UpdateView();
            };

            await Task.CompletedTask;
        }

        private async Task InitViewModel()
        {
            if(_model == null)
            {
                _model = new SectionModel();
            }
            else
                await Task.CompletedTask;
        }

        private bool Validate()
        {
            var result = false;

            var sectionList = _model.GetSections();

            if (!sectionList.Any(p => p.Name == _model.Section.Name))
                return true;

            return result;
        }

        private void UpdateView()
        {
            if (_model.Section == null)
                return;

            _view.textBoxNewSectionName.Text = _model.Section.Name;
            
        }

        private void UpdateModel()
        {
            _model.Section.Name = _view.textBoxNewSectionName.Text;
        }

    }
}
