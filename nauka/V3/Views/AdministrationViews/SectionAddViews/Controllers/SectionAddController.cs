using nauka.V3.Views.SectionViews.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nauka.V3.Views.SectionViews.Controllers
{
    class SectionAddController
    {

        private readonly SectionAddView _view;

        SectionAddController(SectionAddView sectionView)
        {
            _view = sectionView;

            Task.Run(async () =>
            {
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
                _view.DialogResult = DialogResult.OK;
            };

            await Task.CompletedTask;
        }
    
    }
}
