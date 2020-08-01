using ApnaKaryala.DTO.LeaveManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Repositories.LeaveManagement
{
    public interface ILeaveRepository
    {
        List<LeaveTypeDto> GetAllLeaveType(LeaveTypeDto req);
        bool savenewleavedata(LeaveDetailsDto obj);
        List<LeaveDetailsDto> GetLeaveByEmployeeId(LeaveDetailsDto req);
    }
}
