using ApnaKaryala.DTO;
using ApnaKaryala.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Service
{
    public interface IAccountService
    {
        bool loginService(LoginDto Obj);
    }
}
