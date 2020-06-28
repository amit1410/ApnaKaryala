using ApnaKaryala.Data.Infrastructure;
using ApnaKaryala.Data.Repositories;
using ApnaKaryala.DTO.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Service
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository _empRepository;
        private readonly IUnitOfWork unitOfWork;

        public EmployeeService(IEmployeeRepository empRepository, IUnitOfWork unitOfWork)
        {
            this._empRepository = empRepository;
            this.unitOfWork = unitOfWork;
        }
        public bool saveemoloyeedata(EmployeeDto empdro)
        {
            var save = _empRepository.saveemoloyeedata(empdro);
            bool result = false;
                return result;
        }
        public List<EmployeeDto> GetAllEmployeeBYSiteId(EmployeeDto empdro)
        {
            var emplist = _empRepository.GetAllEmployeeBYSiteId(empdro);
            return emplist;
        }
    }
}
