using ApnaKaryala.Model.Models.LeaveManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Configuration.LeaveManagement
{
    public class LeaveStatusCategoryConfiguration : EntityTypeConfiguration<LeaveStatusCategory>
    {
        public LeaveStatusCategoryConfiguration()
        {
            ToTable("LeaveStatusCategory");
            Property(g => g.LeaveCategoryID).IsRequired();

            Property(g => g.LeaveCategoryName);
            Property(g => g.IsActive);

        }
    }
}
