using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Repository
{
    public interface IAppSettingsRepository
    {
        public bool Add(AppSettings appSettings);
        public bool Update(Guid appSettingsId, AppSettings appSettings);
        public bool Delete(AppSettings appSettings);
       // public async Task<AppSettings> GetAppSetting(Guid appSettingsId);
       // public async Task<List<AppSettings>> GetAppSettings();

    }
}
