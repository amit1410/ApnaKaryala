using ApnaKaryala.Data.Infrastructure;
using ApnaKaryala.DTO.Master;
using ApnaKaryala.Model.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        bool saveemoloyeedata(EmployeeDto obj);
        List<EmployeeDto> GetAllEmployeeBYSiteId(EmployeeDto obj);
    }
}
