using ApnaKaryala.Data.Infrastructure;
using ApnaKaryala.Data.Repositories;
using ApnaKaryala.DTO;
using ApnaKaryala.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Service
{
    public class AccountService:IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IUnitOfWork unitOfWork;

        public AccountService(IAccountRepository accountRepository, IUnitOfWork unitOfWork)
        {
            this._accountRepository = accountRepository;
            this.unitOfWork = unitOfWork;
        }

        public bool loginService(LoginDto Obj)
        {
            bool result = _accountRepository.loginService(Obj);
            return result;
        }
        public bool loginService1(LoginDto Obj,string a)
        {
            bool result = _accountRepository.loginService(Obj);
            return result;
        }
        public bool loginService2(LoginDto Obj,int a)
        {
            bool result = _accountRepository.loginService(Obj);
            return result;
        }
        public bool loginService3(LoginDto Obj,bool t)
        {
            bool result = _accountRepository.loginService(Obj);
            return result;
        }
    }
}
