using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.DTO.Master
{
    public class StateDto
    {
        public int StateId { get; set; }  //    
        public string StateName { get; set; }  //   
        public bool? IsActive { get; set; }  // 

        public int? SiteId { get; set; }  // 
    }
}
