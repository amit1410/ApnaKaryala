using ApnaKaryala.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApnaKaryala.Web.Controllers
{
    public class MasterController : Controller
    {
        private readonly IMasterDataService _masterDataService;
        public MasterController(IMasterDataService masterDataService)
        {
            
            this._masterDataService = masterDataService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HoliDayList()
        {
            var holidaylist = _masterDataService.GetAllHoliDay();
            return View(holidaylist);
        }
    }
}