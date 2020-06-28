using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Model.Models.LeaveManagement
{
    public class LeaveStatus
    {
        [Key]
        public int LeaveStatusId { get; set; }  //    
        public int? LeaveCategoryId { get; set; }  //    
        public string LeaveStatusName { get; set; }  //   
        public int? SiteId { get; set; }  // 
        public bool? IsActive { get; set; }  // 
    }
}
