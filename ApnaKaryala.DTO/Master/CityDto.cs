using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.DTO.Master
{
    public class CityDto
    {
        public int CityId { get; set; }  //    
        public int? StateId { get; set; }  //   
        public string CityName { get; set; }  //       
        public bool? IsActive { get; set; }  //    
        public int? SiteId { get; set; }  // 
    }
}
