using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Repository
{
    public class AppSettingsRepository: IAppSettingsRepository
    {
        private DataBaseContext _context;
        public AppSettingsRepository(DataBaseContext context)
        {
            _context = context;
        }

        public bool Add(AppSettings appSettings)
        {
            var result = false;
            if(appSettings != null)
            {
                _context.AppSettings.Add(appSettings);
                result = true;
            }

            return result;
        }

        public bool Update(Guid appSettingsId, AppSettings appSettings)
        {
            var appSettingsTemp = _context.AppSettings.Where(ap => ap.Id == appSettingsId).FirstOrDefault();
            var result = false;
            if(appSettingsTemp == null)
            {
                _context.AppSettings.Add(appSettings);
                result = true;
            }
            if(appSettingsTemp != null)
            {
                _context.AppSettings.Update(appSettings);
                result = true;
            }

            return result;
        }

        public bool Delete(AppSettings appSettings)
        {
            var result = false;
            if (appSettings != null)
            {
                _context.AppSettings.Remove(appSettings);
                result = true;
            }

            return result;
        }

        public async Task<AppSettings> GetAppSetting(Guid appSettingsId)
        {
            return await Task.FromResult(_context.AppSettings.Where(ap => ap.Id == appSettingsId).FirstOrDefault());
        }

        public async Task<List<AppSettings>> GetAppSettings()
        {
            return await Task.FromResult(_context.AppSettings.ToList());
        }
    }
}
