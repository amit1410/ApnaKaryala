using ApnaKaryala.Data.Configuration;
using ApnaKaryala.Model;
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
       

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LoginConfiguration());
           
        }
    }
}
