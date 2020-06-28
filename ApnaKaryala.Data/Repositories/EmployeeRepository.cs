using ApnaKaryala.Data.Infrastructure;
using ApnaKaryala.DTO.Master;
using ApnaKaryala.Model.Models.Employee;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IDbFactory dbFactory)
           : base(dbFactory) { }

        public bool saveemoloyeedata(EmployeeDto obj)
        {
            bool result = false;
            try
            {
                var emp = Mapper.Convert<Employee, EmployeeDto>(obj);
                  MasterContext.Entry(emp).State = EntityState.Added;
                MasterContext.Employee.Add(emp);
                MasterContext.SaveChanges();

                result = true;
            
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }

        public List<EmployeeDto> GetAllEmployeeBYSiteId(EmployeeDto obj)
        {
            List<EmployeeDto> lstemp = new List<EmployeeDto>();
            try
            {

                var emplist = MasterContext.Employee.Where(x => x.SiteId == obj.SiteId).ToList();
                lstemp = Mapper.Convert<EmployeeDto, Employee>(emplist);

            }
            catch (Exception ex)
            {
                string ss = ex.InnerException.Message;
            }

            return lstemp;
        }

    }
}
