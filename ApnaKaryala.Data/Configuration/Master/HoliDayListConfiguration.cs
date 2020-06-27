using ApnaKaryala.Model.Models.Master;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Configuration.Master
{
    public class HoliDayListConfiguration : EntityTypeConfiguration<HoliDayList>
    {
        public HoliDayListConfiguration()
        {
            ToTable("HoliDayList");
            Property(g => g.HoliDayId).IsRequired();

            Property(g => g.HoliDayName);
            Property(g => g.Year);
            Property(g => g.NoOfDay);
            Property(g => g.HoliDay_Day);
            Property(g => g.HoliDayName);
            Property(g => g.State);
            Property(g => g.IsActive);
            Property(g => g.SiteId);

        }
    }
}
