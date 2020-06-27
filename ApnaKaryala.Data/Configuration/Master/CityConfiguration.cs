using ApnaKaryala.Model.Models.Master;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Configuration.Master
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            ToTable("City");
            Property(g => g.CityId).IsRequired();

            Property(g => g.StateId);
            Property(g => g.CityName);
            Property(g => g.IsActive);
            Property(g => g.SiteId);

        }
    }
}
