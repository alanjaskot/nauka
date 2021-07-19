using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Repository
{
    public class DataBaseContext: DbContext
    {
        private IDbContextTransaction _dbContextTransaction;

        public DbSet<AppSettings> AppSettings { get; set; }
        public DbSet<VacationDays> VacationDays { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<VacationOfEmployee> VacationOfEmployees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = new SqlConnectionStringBuilder();
            connectionString.DataSource = "DESKTOP-VV2EGSU";
            connectionString.InitialCatalog = "nauka-urlopy";
            connectionString.Authentication = SqlAuthenticationMethod.SqlPassword;
            connectionString.UserID = "alan";
            connectionString.Password = "dupa";
            connectionString.TrustServerCertificate = false;

            optionsBuilder.UseSqlServer(connectionString.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<VacationOfEmployee>()
                .HasKey(voe => new { voe.EmployeeId, voe.VacationId });

        }

        public async Task InitTransaction()
        {
            if (_dbContextTransaction == null)
                _dbContextTransaction = Database.BeginTransaction();

            await Task.CompletedTask;
        }

        public async Task RollbackTransaction()
        {
            if (_dbContextTransaction != null)
            {
                _dbContextTransaction.Rollback();
                _dbContextTransaction.Dispose();
                _dbContextTransaction = null;
            }

            await Task.CompletedTask;
        }

        public async Task CommitTransaction()
        {
            if(_dbContextTransaction != null)
            {
                _dbContextTransaction.Commit();
                _dbContextTransaction.Dispose();
                _dbContextTransaction = null;
            }

            await Task.CompletedTask;
        }


    }
}
