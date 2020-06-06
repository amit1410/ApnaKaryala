using ApnaKaryala.DTO;
using ApnaKaryala.Service;
using ApnaKaryala.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApnaKaryala.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAccountService _accountService;
      

        public LoginController(IAccountService accountService)
        {
            this._accountService = accountService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Save(LoginDto obj)
        {
            var result = _accountService.loginService(obj);
            if (result==true)
            {
                return View("Dashboard");
            }
            else
            {
                ModelState.AddModelError("LogOnError", "The user name or password provided is incorrect.");
                return View("Index", obj);
            }

        }

        public ActionResult Dashboard()
        {
            return View();
        }
    }
}