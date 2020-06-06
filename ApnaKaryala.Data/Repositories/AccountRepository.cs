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
    public class AccountRepository : RepositoryBase<Login>, IAccountRepository
    {
        public AccountRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public bool loginService(LoginDto obj)
        {
            bool result = false;
            try
            {
                var login = this.MasterContext.Login.Where(c => c.UserName == obj.UserName && c.Password == obj.Password).FirstOrDefault();
                //lddto = Mapper.Convert<LoginDto, Login>(login);
                if(login!=null)
                {
                    result = true;
                }
            }
            catch(Exception ex)
            {

            }
          
            return result;
        }
    }
}
