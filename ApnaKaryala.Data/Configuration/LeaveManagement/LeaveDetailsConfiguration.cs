using ApnaKaryala.Model.Models.LeaveManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Configuration.LeaveManagement
{
    public class LeaveDetailsConfiguration : EntityTypeConfiguration<LeaveDetails>
    {
        public LeaveDetailsConfiguration()
        {
            ToTable("LeaveDetails");
            Property(g => g.LeaveId).IsRequired();

            Property(g => g.DateFrom);
            Property(g => g.DateTo);
            Property(g => g.EmpID);
            Property(g => g.LeaveCount);
            Property(g => g.LeaveTypeId);
            Property(g => g.SiteID);
            Property(g => g.ShiftId);
            Property(g => g.LeaveStatusID);

            Property(g => g.LeaveStatusCatagoryId);
            Property(g => g.SupervisorID);
            Property(g => g.Description);

        }
    }
}
