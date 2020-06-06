﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Model
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? IsSeesionActive { get; set; }
        public DateTime? LoginStartTime { get; set; }
        public DateTime LoginEndTime { get; set; }
    }
}
