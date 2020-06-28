using ApnaKaryala.DTO.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Service
{
    public interface IEmployeeService
    {
        bool saveemoloyeedata(EmployeeDto empdro);
        List<EmployeeDto> GetAllEmployeeBYSiteId(EmployeeDto empdro);
    }
}
