using nauka.V3.Models;
using nauka.V3.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Services
{
    public class AppSettingsService
    {
        private AppSettingsRepository _repository;
        private DataBaseContext _context;

        public AppSettingsService(){ }

        public AppSettingsService(DataBaseContext context, AppSettingsRepository repository)
        {
            _context = context;
            _repository = repository;
        }
        public async Task GetAppSetting(Guid appSettingsId)
        {
            await Task.FromResult(_repository.GetAppSetting(appSettingsId)); 
        }

        public async Task Add(AppSettings appSettings)
        {
            if (_repository.Add(appSettings))
                _context.SaveChanges();
            await Task.CompletedTask;
        }

        public async Task Update(Guid appSettingsId, AppSettings appSettings)
        {
            if (_repository.Update(appSettingsId, appSettings))
                _context.SaveChanges();
            await Task.CompletedTask;
        }

        public async Task Delete(AppSettings appSettings)
        {
            if (_repository.Delete(appSettings))
                _context.SaveChanges();
            await Task.CompletedTask;
        }
    }
}
