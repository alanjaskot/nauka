using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using nauka.V3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace nauka.V3.Repository
{
    public class DataBaseContext: DbContext
    {
        private readonly string _databaseFileName = "AppForVacations.db";

        private IDbContextTransaction _dbContextTransaction;

        public String _dbPath { get; private set; }

        public DbSet<AppSettings> AppSettings { get; set; }
        public DbSet<VacationDays> VacationDays { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Vacation_Employee> VacationOfEmployees { get; set; }
        
        
        public DataBaseContext()
        {
        }

        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var appFolder = AppDomain.CurrentDomain.BaseDirectory;//  Environment.SpecialFolder.LocalApplicationData;
            var databasePath = Path.Combine(appFolder, _databaseFileName);
            _dbPath = databasePath;
      
            var connectionString = new SqlConnectionStringBuilder();
            connectionString.DataSource = "DESKTOP-VV2EGSU";
            connectionString.InitialCatalog = "nauka-urlopy";
            connectionString.Authentication = SqlAuthenticationMethod.SqlPassword;
            connectionString.UserID = "alan";
            connectionString.Password = "dupa";
            connectionString.TrustServerCertificate = false;

            //optionsBuilder.UseSqlServer(connectionString.ConnectionString);
            optionsBuilder.UseSqlite($"Data Source={_dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {

            #region Primary Keys
            model.Entity<AppSettings>()
                .HasKey(ap => ap.Id);

            model.Entity<Section>()
                .HasKey(s => s.Id);

            model.Entity<Employee>()
                .HasKey(e => e.Id);

            model.Entity<Vacation>()
                .HasKey(v => v.Id);

            model.Entity<VacationDays>()
                .HasKey(vd => vd.Id);

            model.Entity<Vacation_Employee>()
                .HasKey(voe => new { voe.EmployeeId, voe.VacationId });
            #endregion

            #region Properties

            model.Entity<AppSettings>()
                .Property(ap => ap.AvaibleVacationDays)
                .IsRequired();

            model.Entity<AppSettings>()
                .Property(ap => ap.EmployeeId)
                .IsRequired();

            model.Entity<Section>()
                .Property(s => s.Name)
                .IsRequired();

            #region Employee properties
            model.Entity<Employee>()
                .Property(e => e.Surname)
                .IsRequired();

            model.Entity<Employee>()
                .Property(e => e.Name)
                .IsRequired();

            model.Entity<Employee>()
                .Property(e => e.Username)
                .IsRequired();

            model.Entity<Employee>()
                .Property(e => e.Password)
                .IsRequired();

            model.Entity<Employee>()
                .Property(e => e.Email)
                .IsRequired();

            model.Entity<Employee>()
                .Property(e => e.Sex)
                .IsRequired();

            model.Entity<Employee>()
                .Property(e => e.VacationPermisson)
                .IsRequired();

            model.Entity<Employee>()
                .Property(e => e.EmployeePermisson)
                .IsRequired();
            #endregion

            #region Vacation properties
            model.Entity<Vacation>()
                .Property(v => v.Start)
                .IsRequired();

            model.Entity<Vacation>()
                .Property(v => v.End)
                .IsRequired();

            model.Entity<Vacation>()
                .Property(v => v.Description)
                .IsRequired();

            model.Entity<Vacation>()
                .Property(v => v.Approve)
                .IsRequired();
            #endregion

            model.Entity<VacationDays>()
                .Property(vd => vd.Days)
                .IsRequired();

            model.Entity<VacationDays>()
                .Property(vd => vd.Year)
                .IsRequired();

            #endregion

            #region Relations 1:1

            model.Entity<VacationDays>()
                .HasOne(vd => vd.Vacation)
                .WithOne(v => v.VacationDays)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            model.Entity<Employee>()
                .HasOne(e => e.AppSettings)
                .WithOne(ap => ap.Employee)
                .IsRequired();

            #endregion

            #region Relation 1:N and N:N

            model.Entity<Employee>()
                .HasOne(e => e.Section)
                .WithMany(s => s.Employees)
                .HasForeignKey(e => e.SectionId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            model.Entity<Vacation_Employee>()
                .HasOne(voe => voe.Employee)
                .WithMany(e => e.Vacation_Employees)
                .HasForeignKey(voe => voe.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            model.Entity<Vacation_Employee>()
                .HasOne(voe => voe.Vacation)
                .WithMany(v => v.Vacation_Employees)
                .HasForeignKey(voe => voe.VacationId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            #endregion
           
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
