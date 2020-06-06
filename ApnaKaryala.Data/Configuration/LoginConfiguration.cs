using ApnaKaryala.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Configuration
{
    public class LoginConfiguration : EntityTypeConfiguration<Login>
    {
        public LoginConfiguration()
        {
            ToTable("Login");
            Property(g => g.EmployeeId);
            Property(g => g.Id).IsRequired();
            Property(g => g.IsSeesionActive);
            Property(g => g.LoginEndTime);
            Property(g => g.LoginStartTime);
            Property(g => g.UserName);
            Property(g => g.Password);
            
        }
    }
}
