using ApnaKaryala.Model.Models.Master;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Configuration.Master
{
    public class StateConfiguration : EntityTypeConfiguration<State>
    {
        public StateConfiguration()
        {
            ToTable("State");
            Property(g => g.StateId).IsRequired();

            Property(g => g.StateName);
            Property(g => g.IsActive);
            Property(g => g.SiteId);

        }
    }
}
