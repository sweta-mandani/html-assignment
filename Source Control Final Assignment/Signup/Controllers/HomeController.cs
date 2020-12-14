using NLog;
using Signup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Signup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData()
        {
           using (LoginEntities db = new LoginEntities())
                {
                    List<Student> employeeList = db.Students.ToList<Student>();
                    return Json(new { data = employeeList }, JsonRequestBehavior.AllowGet);
                }

            }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "User");
        }
    }
}