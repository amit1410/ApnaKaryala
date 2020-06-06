using ApnaKaryala.Data.Infrastructure;
using ApnaKaryala.DTO;
using ApnaKaryala.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Repositories
{
    public interface IAccountRepository : IRepository<Login>
    {
        bool loginService(LoginDto obj);
    }
}
