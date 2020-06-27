using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Model.Models.Master
{
    public class City
    {
        [Key]
        public int CityId { get; set; }  //    
        public int? StateId { get; set; }  //   
        public string CityName { get; set; }  //       
        public bool? IsActive { get; set; }  //    
        public int? SiteId { get; set; }  // 
    }
}
