using ApnaKaryala.Model.Models.LeaveManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Configuration.LeaveManagement
{
    public class LeaveStatusConfiguration : EntityTypeConfiguration<LeaveStatus>
    {
        public LeaveStatusConfiguration()
        {
            ToTable("LeaveStatus");
            Property(g => g.LeaveStatusId).IsRequired();

            Property(g => g.LeaveCategoryId);
            Property(g => g.LeaveStatusName);
            Property(g => g.SiteId);
            Property(g => g.IsActive);
        }
       
    }
}
