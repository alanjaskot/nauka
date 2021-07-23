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
        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

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
            _view.buttonOk.Click += (object sender, EventArgs e) =>
            {
                UpdateModel();
                if (Validate())
                {
                    _view.DialogResult = DialogResult.OK;
                    _view.Close();
                }
            };

            _view.buttonCancel.Click += (object sender, EventArgs e) =>
            {
                _view.Close();
            };

            _view.Load += (object sender, EventArgs e) =>
            {
                RefreshView();
            };

            await Task.CompletedTask;
        }


        private async Task InitViewModel()
        {
            if (_model == null)
                _model = new SectionModel();

            await Task.CompletedTask;
        }

        private bool Validate()
        {
            var result = false;
            try
            {
                if (_view.textBoxSectionName != null)
                    result = true;
            }
            catch (Exception er)
            {
                _logger.Error("Validate " + er);
            } 
            

            return result;
        }   

        private void RefreshView()
        {
            if ((_model.Section != null) && (_model.Section.Name != null))
                    _view.textBoxSectionName.Text = _model.Section.Name;
        }

        private void UpdateModel()
        {
            if (_model.Section.Id == Guid.Empty)
                _model.Section.Id = Guid.NewGuid();
            try
            {
                _model.Section.Name = _view.textBoxSectionName.Text;
            }
            catch (Exception er)
            {
                _logger.Error("UpdateModel" + er);
            }           
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
