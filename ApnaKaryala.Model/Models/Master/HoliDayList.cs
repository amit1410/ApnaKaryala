using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Model.Models.Master
{
    public class HoliDayList
    {
        [Key]
        public int HoliDayId { get; set; }  //    
        public string HoliDayName { get; set; }  //       
        public int? Year { get; set; }  //    
        public int? SiteId { get; set; }  //       
        public int? NoOfDay { get; set; }  //      
        public string HoliDay_Day { get; set; }  //
        public DateTime? HoliDayDate { get; set; }  //   
        public string State { get; set; }  //         
        public bool IsActive { get; set; }  //    
    }
}
