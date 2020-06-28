using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.DTO.LeaveManagement
{
    public class LeaveTypeDto
    {
        public int LeaveTypeId { get; set; }  //    
        public string LeaveTypeName { get; set; }  //        
        public string ShotName { get; set; }  //     
        public int? TotalLeaveCount { get; set; }  // 
        public bool? IsActive { get; set; }  //         
        public int? SiteId { get; set; }  //   
    }
}
