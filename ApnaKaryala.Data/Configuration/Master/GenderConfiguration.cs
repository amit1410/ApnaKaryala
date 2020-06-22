using ApnaKaryala.Model.Models.Master;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Configuration.Master
{
    public class GenderConfiguration : EntityTypeConfiguration<Gender>
    {
        public GenderConfiguration()
        {
            ToTable("Gender");
            Property(g => g.GenderId).IsRequired();

            Property(g => g.GenderName);
            Property(g => g.IsActive);
            Property(g => g.SiteId);
           
        }
    }
}
