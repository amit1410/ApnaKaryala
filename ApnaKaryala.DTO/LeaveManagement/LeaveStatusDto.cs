using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.DTO.LeaveManagement
{
    public class LeaveStatusDto
    {
        public int LeaveStatusId { get; set; }  //    
        public int? LeaveCategoryId { get; set; }  //    
        public string LeaveStatusName { get; set; }  //   
        public int? SiteId { get; set; }  // 
        public bool? IsActive { get; set; }  //
    }
}
