using ApnaKaryala.Data.Configuration;
using ApnaKaryala.Data.Configuration.LeaveManagement;
using ApnaKaryala.Data.Configuration.Master;
using ApnaKaryala.Model;
using ApnaKaryala.Model.Models.Employee;
using ApnaKaryala.Model.Models.LeaveManagement;
using ApnaKaryala.Model.Models.Master;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data
{
    public class MasterEntities : DbContext
    {
        public MasterEntities() : base("MasterEntities") { }

        public DbSet<Login> Login { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<HoliDayList> HoliDayList { get; set; }
        #region Leave Management
        public DbSet<LeaveType> LeaveType { get; set; }
        public DbSet<LeaveDetails> LeaveDetails { get; set; }
        public DbSet<LeaveStatus> LeaveStatus { get; set; }
        public DbSet<LeaveStatusCategory> LeaveStatusCategory { get; set; }
        #endregion Leave Management

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LoginConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new GenderConfiguration());
            modelBuilder.Configurations.Add(new StateConfiguration());
            modelBuilder.Configurations.Add(new CityConfiguration());
            modelBuilder.Configurations.Add(new HoliDayListConfiguration());
            #region Leave Management
            modelBuilder.Configurations.Add(new LeaveDetailsConfiguration());
            modelBuilder.Configurations.Add(new LeaveStatusCategoryConfiguration());
            modelBuilder.Configurations.Add(new LeaveStatusConfiguration());
            modelBuilder.Configurations.Add(new LeaveTypeConfiguration());
            #endregion Leave Management

        }
    }
}
