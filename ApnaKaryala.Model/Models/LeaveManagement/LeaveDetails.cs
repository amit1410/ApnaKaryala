using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Model.Models.LeaveManagement
{
    public class LeaveDetails
    {
        [Key]
        public int LeaveId { get; set; }  //    
        public int? EmpID { get; set; }  //  
        public int? LeaveTypeId { get; set; }  //  
        public DateTime? LeaveDate { get; set; }  // 
        public int? SiteID { get; set; }  //        
        public int? ShiftId { get; set; }  //         
        public int? LeaveStatusID { get; set; }  //   
        public int? LeaveStatusCatagoryId { get; set; }  //  
        public int? LeaveCount { get; set; }  //        
        public int? SupervisorID { get; set; }  //  
        public string Description { get; set; }  //  
    }
}
