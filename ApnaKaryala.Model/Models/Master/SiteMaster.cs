using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Model.Models.Master
{
    public class SiteMaster
    {
        [Key]
        public int? SiteId { get; set; }  //    
        public String SiteName { get; set; }  //  
        public String Address { get; set; }  //      
        public string Phone { get; set; }  //       
        public string Mobile { get; set; }  //       
        public int? CityId { get; set; }  //       
        public int? Stateid { get; set; }  //        
        public int? CountryId { get; set; }  //       
        public decimal? PinCode { get; set; }  //      
        public bool? IsActive { get; set; }  //         
        public int? CreatedBy { get; set; }  //         
        public DateTime? CreatedDate { get; set; }  //  
        public int? UpdatedBy { get; set; }  //     
        public DateTime? UpdatedDate { get; set; }  //  
        public byte[] Logo { get; set; }  //        
        public String Comments { get; set; }  //     
        public string EmployeeCodePrefix { get; set; }  //   
        public string EmployeeCodePrefixSymbob { get; set; }  //  
    }
}
