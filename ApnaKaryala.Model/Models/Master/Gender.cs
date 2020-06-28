using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Model.Models.Master
{
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }  //   
        public string GenderName { get; set; }  //     
        public bool? IsActive { get; set; }  //        
        public int? SiteId { get; set; }  // 
    }
}
