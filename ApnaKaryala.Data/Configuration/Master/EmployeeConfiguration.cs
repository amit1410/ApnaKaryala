using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApnaKaryala.Model;
using ApnaKaryala.Model.Models.Employee;

namespace ApnaKaryala.Data.Configuration.Master
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            ToTable("Employee");
            Property(g => g.EmployeeId).IsRequired();
           
            Property(g => g.Address1);
            Property(g => g.Address2);
            Property(g => g.Address3);
            Property(g => g.CityId);
            Property(g => g.StateId);
            Property(g => g.DateofResign);
            Property(g => g.DOB);
            Property(g => g.DOJ);
            Property(g => g.DOL);
            Property(g => g.Email);
            Property(g => g.EmployeeCode);
            Property(g => g.FatherName);
            Property(g => g.First_Name);
            Property(g => g.GenderId);
            Property(g => g.IsActive);
            Property(g => g.ISSupervisor);
            Property(g => g.Last_Name);
            Property(g => g.Middle_Name);
            Property(g => g.Mobile);
            Property(g => g.MotherName);
            Property(g => g.PersonalMailId);
            Property(g => g.Phone);
            Property(g => g.Pincode);
            Property(g => g.SiteId);
            Property(g => g.StateId);
            Property(g => g.HighestQualification);
            Property(g => g.AdhaarNo);
            Property(g => g.PANCardNo);
           


        }
    }
}
