using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using NLog;
using Product_Management.Models;

namespace Product_Management.Controllers
{

    public class AccountController : Controller
    {
        UserEntities1 db = new UserEntities1();
        private static Logger logger = LogManager.GetCurrentClassLogger();


        // GET: User
        public ActionResult Login()
        {
            return View();

         }


        [HttpPost]
        public ActionResult Login(Account s)
        {
            var User = db.Accounts.Where(model => model.Email == s.Email && model.Password == s.Password).FirstOrDefault();
            if (User != null)
            {

                Session["UserId"] = s.Id.ToString();
                Session["Username"] = s.Email.ToString();


                TempData["loginstatus"] = "<script>alert('login succefully !!')</script>";
                logger.Info("login complate" + Environment.NewLine + DateTime.Now);
                return RedirectToAction("Index", "Home");

            }
            else
            {
                logger.Info("not Login" + Environment.NewLine + DateTime.Now);
                ViewBag.ErrorMeassage = "<script>alert('email and password does not match !!')</script>";
            }
            return View();
        }


        // Get Register
        public ActionResult register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult register(Account s)
        {


            if (ModelState.IsValid == true)
            {

                db.Accounts.Add(s);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    ViewBag.InsertMeassage = "<script>alert('register succefully !!')</script>";
                    ModelState.Clear();
                    logger.Info("Register Succefully" + Environment.NewLine + DateTime.Now);
                    return RedirectToAction("Login");
                }
                else
                {
                    logger.Info("Register not Succefully" + Environment.NewLine + DateTime.Now);
                    ViewBag.InsertMeassage = "<script>alert('not register succefully !!')</script>";
                }
                
            }
                return View();
         }
    }
}

