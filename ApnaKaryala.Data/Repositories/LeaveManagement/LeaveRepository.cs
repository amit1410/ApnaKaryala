using ApnaKaryala.Data.Infrastructure;
using ApnaKaryala.DTO.LeaveManagement;
using ApnaKaryala.Model.Models.LeaveManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Repositories.LeaveManagement
{
    public class LeaveRepository: RepositoryBase<LeaveDetails>, ILeaveRepository
    {
        public LeaveRepository(IDbFactory dbFactory)
        : base(dbFactory) { }
        public List<LeaveTypeDto> GetAllLeaveType(LeaveTypeDto req)
        {
            List<LeaveTypeDto> lstleavetype = new List<LeaveTypeDto>();
            try
            {

                var leavetype = MasterContext.LeaveType.Where(i => i.SiteId == req.SiteId).ToList();
                lstleavetype = Mapper.Convert<LeaveTypeDto, LeaveType>(leavetype);

            }
            catch (Exception ex)
            {

            }
            return lstleavetype;
        }

        public bool savenewleavedata(LeaveDetailsDto obj)
        {
            bool result = false;
            try
            {
                var leaveentry = Mapper.Convert<LeaveDetails, LeaveDetailsDto>(obj);
                if(obj.LeaveCount>1)
                {
                    for(int i=0;i< obj.LeaveCount;i++)
                    {
                        leaveentry.LeaveDate = Convert.ToDateTime(obj.DateFrom).AddDays(i);
                        leaveentry.LeaveCount = 1;
                        leaveentry.LeaveTypeId = obj.LeaveTypeId;
                        MasterContext.Entry(leaveentry).State = EntityState.Added;
                        MasterContext.LeaveDetails.Add(leaveentry);
                        MasterContext.SaveChanges();
                    }
                }
                else
                {
                    MasterContext.Entry(leaveentry).State = EntityState.Added;
                    MasterContext.LeaveDetails.Add(leaveentry);
                    MasterContext.SaveChanges();
                }
              
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }
    }
}
