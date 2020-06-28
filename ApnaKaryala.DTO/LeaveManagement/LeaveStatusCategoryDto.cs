using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.DTO.LeaveManagement
{
    public class LeaveStatusCategoryDto
    {
        public int LeaveCategoryID { get; set; }  //     
        public string LeaveCategoryName { get; set; }  //  
        public bool? IsActive { get; set; }  //   
    }
}
