using nauka.V3.Models;
using nauka.V3.Views.AdministrationViews.SectionViews.Models;
using nauka.V3.Views.AdministrationViews.SectionViews.SectionViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V3.Views.AdministrationViews.SectionViews.Controllers
{
    class SectionController
    {
        private readonly SectionView _view;
        private SectionModel _model;

        public SectionController(SectionView sectionView)
        {
            _view = sectionView;

            Task.Run(async () =>
            {
                await InitView();
                await InitViewModel();
            }).Wait();
        }

        private async Task InitView()
        {
            _view.buttonOk.Click += (object sender, EventArgs e) =>
            {
                //if (!Validate())
                Update();
                AddSection();
                _view.Close();

               // else
                //    MessageBox.Show("Podana sekcja już istnieje");
            };

            _view.buttonCancel.Click += (object sender, EventArgs e) =>
            {
                
            };

            await Task.CompletedTask;
        }

        private async Task InitViewModel()
        {
            if (_model == null)
                _model = new SectionModel();

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
            bool result = true;
            var sectionList = _model.GetSections();

            if (sectionList.Any(s => s.Name == _model.Section.Name))
            {
                result = false;
            }            

            return result;
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
    }
}
