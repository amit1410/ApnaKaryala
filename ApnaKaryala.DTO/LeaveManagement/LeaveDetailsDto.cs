using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.DTO.LeaveManagement
{
    public class LeaveDetailsDto
    {
        public int LeaveId { get; set; }  //    
        public int? EmpID { get; set; }  //  
        public int? LeaveTypeId { get; set; }  //  

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateFrom { get; set; }  // 

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateTo { get; set; }  //      
        public int? SiteID { get; set; }  //        
        public int? ShiftId { get; set; }  //         
        public int? LeaveStatusID { get; set; }  //   
        public int? LeaveStatusCatagoryId { get; set; }  //  
        public int? LeaveCount { get; set; }  //        
        public int? SupervisorID { get; set; }  //  
        public string Description { get; set; }  //  
        public string RemainingLeave { get; set; }  //  
        public DateTime? LeaveDate { get; set; }  // 
    }
}
