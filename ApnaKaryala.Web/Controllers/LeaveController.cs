using ApnaKaryala.DTO.LeaveManagement;
using ApnaKaryala.Service.LeaveManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApnaKaryala.Web.Controllers
{
    public class LeaveController : Controller
    {
        private readonly ILeaveService _leaveService;

        public LeaveController(ILeaveService leaveService)
        {
            this._leaveService = leaveService;
        }
        public ActionResult Index()
        {
            LeaveDetailsDto req = new LeaveDetailsDto();
            var leavetype = _leaveService.GetAllLeaveType();
            if (leavetype != null)
            {
                ViewBag.leavetype = leavetype;
            }
            req.EmpID = 1;
            req.SiteID = 1;
            req.LeaveStatusID = 3;//need to get from database as per site
            req.LeaveStatusCatagoryId = 3;
            var saveemp = _leaveService.GetLeaveByEmployeeId(req);
            req.leavedetails = saveemp;
            return View(req);
        }

        public ActionResult Submit(LeaveDetailsDto leavedetailsdto, string save)
        {
            leavedetailsdto.EmpID = 1;
            leavedetailsdto.SiteID = 1;
            leavedetailsdto.LeaveStatusID =3;//need to get from database as per site
            leavedetailsdto.LeaveStatusCatagoryId = 3;
            var saveemp = _leaveService.saveemoloyeedata(leavedetailsdto);
            return RedirectToAction("Index", new { message = "Added" });
        }

        public ActionResult ApplyLeave()
        {
            LeaveDetailsDto req = new LeaveDetailsDto();
            var leavetype = _leaveService.GetAllLeaveType();
            if (leavetype != null)
            {
                ViewBag.leavetype = leavetype;
            }
            return View(req);
        }

        public JsonResult GetRemaningLeave(int leavetypeid) // its a GET, not a POST
        {
            int leave = 2;
            return Json(leave, JsonRequestBehavior.AllowGet);
        }

    }
}