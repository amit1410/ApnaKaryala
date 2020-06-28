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
        bool loginService1(LoginDto Obj,string a);
        bool loginService2(LoginDto Obj,int a);
        bool loginService3(LoginDto Obj,bool t);
    }
}
