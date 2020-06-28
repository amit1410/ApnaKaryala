﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.DTO.Master
{
    public class EmployeeDto
    {
        public int? EmployeeId { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? Pincode { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public String FatherName { get; set; }
        public String MotherName { get; set; }
        public int? GenderId { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime? DOJ { get; set; }
        public DateTime? DateofResign { get; set; }
        public DateTime? DOL { get; set; }
        public bool IsActive { get; set; }
        public string EmployeeCode { get; set; }
        public int? SiteId { get; set; }
        public string PersonalMailId { get; set; }
        public string Email { get; set; }
        public string AdhaarNo { get; set; }
        public string PANCardNo { get; set; }
        public string HighestQualification { get; set; }
        public bool ISSupervisor { get; set; }
    }
}
