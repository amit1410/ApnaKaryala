using ApnaKaryala.DTO.LeaveManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Service.LeaveManagement
{
    public interface ILeaveService
    {
        List<LeaveTypeDto> GetAllLeaveType();
        bool saveemoloyeedata(LeaveDetailsDto leavedto);
    }
}
