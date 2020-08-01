using ApnaKaryala.Data.Infrastructure;
using ApnaKaryala.Data.Repositories.LeaveManagement;
using ApnaKaryala.DTO.LeaveManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Service.LeaveManagement
{
    public class LeaveService:ILeaveService
    {
        private readonly ILeaveRepository _leaveRepository;
        private readonly IUnitOfWork unitOfWork;

        public LeaveService(ILeaveRepository leaveRepository, IUnitOfWork unitOfWork)
        {
            this._leaveRepository = leaveRepository;
            this.unitOfWork = unitOfWork;
        }
        public List<LeaveTypeDto> GetAllLeaveType()
        {
            LeaveTypeDto req = new LeaveTypeDto();
            req.SiteId = 1;
            var result = _leaveRepository.GetAllLeaveType(req);
            return result;
        }

        public bool saveemoloyeedata(LeaveDetailsDto leavedto)
        {
            var save = _leaveRepository.savenewleavedata(leavedto);
            bool result = false;
            return result;
        }

        public List<LeaveDetailsDto> GetLeaveByEmployeeId(LeaveDetailsDto leavedto)
        {
            var save = _leaveRepository.GetLeaveByEmployeeId(leavedto);
            return save;
        }
    }
}
