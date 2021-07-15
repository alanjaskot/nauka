﻿using nauka.V3.Models;
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
                if (Validate())
                {
                    
                    if (_model.Section.Name != null)
                    {
                        RefreshUpdateModel();
                        _view.DialogResult = DialogResult.OK;
                        _view.Close();
                    }
                        

                    if (_model.Section.Name == null)
                    {
                        RefreshModel();
                        _view.DialogResult = DialogResult.OK;
                        _view.Close();
                    }         
                }
                else
                {
                    MessageBox.Show("Proszę uzupełnić nazwę jednostki");
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
            if (_model == null)
                _model = new SectionModel();

            else
                await Task.CompletedTask;
        }

        private bool Validate()
        {
            var result = false;
            if (_view.textBoxSectionName != null)
                result = true;

            return result;
        }   

        private void RefreshModel()
        {
            if (_model.Section == null)
                _model.Section.Id = Guid.NewGuid();

            _model.Section.Name = _view.textBoxSectionName.Text;
        }

        private void RefreshUpdateModel()
        {
            _model.Section.Name = _view.textBoxSectionName.Text;
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
