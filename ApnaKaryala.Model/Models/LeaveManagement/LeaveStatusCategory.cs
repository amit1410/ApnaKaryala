using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Model.Models.LeaveManagement
{
    public class LeaveStatusCategory
    {
        [Key]
        public int LeaveCategoryID { get; set; }  //     
        public string LeaveCategoryName { get; set; }  //  
        public bool? IsActive { get; set; }  //    
    }
}

