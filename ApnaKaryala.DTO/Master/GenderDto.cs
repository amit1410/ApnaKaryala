using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.DTO.Master
{
    public class GenderDto
    {
        public int GenderId { get; set; }  //   
        public string GenderName { get; set; }  //     
        public bool? IsActive { get; set; }  //        
        public int? SiteId { get; set; }  // 
    }
}
