using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Repository
{
    public interface IAppSettingsRepository
    {
        public bool Add(AppSettings appSettings);
        public bool Update(Guid appSettingsId, AppSettings appSettings);
        public bool Delete(AppSettings appSettings);
        public AppSettings GetAppSetting(Guid appSettingsId);
    }
}
