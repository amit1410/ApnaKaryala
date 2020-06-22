using ApnaKaryala.DTO.Master;
using ApnaKaryala.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApnaKaryala.Web.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        private readonly IEmployeeService _employeeService;
        private readonly IMasterDataService _masterDataService;


        public EmployeeController(IEmployeeService employeeService, IMasterDataService masterDataService)
        {
            this._employeeService = employeeService;
            this._masterDataService = masterDataService;
        }
        public ActionResult Index()
        {
            List<EmployeeDto> lst = new List<EmployeeDto>();
            EmployeeDto emp = new EmployeeDto();
            emp.SiteId = 1;
            var emplist = _employeeService.GetAllEmployeeBYSiteId(emp);
            return View(emplist);
        }

        public ActionResult Index1(string message)
        {

            if (!string.IsNullOrEmpty(message))
            {
                ViewBag.message = message;
            }
            return View("Index");
        }

        public ActionResult AddEmployee()
        {
            // List<Emp_Information> model = db.Emp_Information.ToList();
            return RedirectToAction("AddNewEmployee");
        }

        public ActionResult AddNewEmployee()
        {
            var gender = _masterDataService.GetAllGender();
            if (gender != null)
            {
                ViewBag.gender = gender;
            }
            var state = _masterDataService.GetAllState();
            if (state != null)
            {
                ViewBag.state = state;
            }
            return View();
        }

        public ActionResult Submit(EmployeeDto empdto, string save)
        {
            var saveemp = _employeeService.saveemoloyeedata(empdto);
            return RedirectToAction("Index1", new { message = "Added" });
        }

        public JsonResult City_Bind(string state_id)
        {
            CityDto emp = new CityDto();
            emp.StateId = Convert.ToInt32(state_id);
            var city = _masterDataService.GetAllCityByStateid(emp);
            List<SelectListItem> citylist = new List<SelectListItem>();
            foreach (var item in city)
            {
                citylist.Add(new SelectListItem { Text =item.CityName, Value = item.CityId.ToString() });
            }
            return Json(citylist, JsonRequestBehavior.AllowGet);
        }
    }
}