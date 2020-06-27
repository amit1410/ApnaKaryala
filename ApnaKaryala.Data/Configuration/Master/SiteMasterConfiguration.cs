using ApnaKaryala.Model.Models.Master;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Configuration.Master
{
    public class SiteMasterConfiguration : EntityTypeConfiguration<SiteMaster>
    {
        public SiteMasterConfiguration()
        {
            ToTable("SiteMaster");
            Property(g => g.SiteId).IsRequired();
            Property(g => g.SiteName);
            Property(g => g.Address);
            Property(g => g.Phone);
            Property(g => g.CityId);
            Property(g => g.Mobile);
            Property(g => g.CityId);
            Property(g => g.Stateid);
            Property(g => g.CountryId);
            Property(g => g.PinCode);
            Property(g => g.IsActive);
            Property(g => g.CreatedBy);
            Property(g => g.CreatedDate);
            Property(g => g.UpdatedBy);
            Property(g => g.UpdatedDate);
            Property(g => g.Comments);
            Property(g => g.Logo);
            Property(g => g.EmployeeCodePrefix);
            Property(g => g.EmployeeCodePrefixSymbob);
        }
    }
}
