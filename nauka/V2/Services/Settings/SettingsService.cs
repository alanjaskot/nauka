using nauka.V2.Base;
using nauka.V2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nauka.V2.Services.Settings
{
    public class SettingsService : BaseService
    {
        private AppSettings _appSettings;

        public async Task<AppSettings> GetAppSettings()
        {
            if (_appSettings == null)
                await InitAppSettings();

            return await Task.FromResult(_appSettings);
        }

        private async Task InitAppSettings()
        {
            Thread.Sleep(1000);

            var appSettings = new AppSettings
            {
                VacationDaysCount = 10,
            };

            _appSettings = appSettings;

            await Task.CompletedTask;
        }

    }
}
