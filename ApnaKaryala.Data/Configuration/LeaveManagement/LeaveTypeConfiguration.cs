using ApnaKaryala.Model.Models.LeaveManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Configuration.LeaveManagement
{
    public class LeaveTypeConfiguration : EntityTypeConfiguration<LeaveType>
    {
        public LeaveTypeConfiguration()
        {
            ToTable("LeaveType");
            Property(g => g.LeaveTypeId).IsRequired();

            Property(g => g.LeaveTypeName);
            Property(g => g.ShotName);
            Property(g => g.TotalLeaveCount);
            Property(g => g.IsActive);
            Property(g => g.SiteId);
        }
    }
}
