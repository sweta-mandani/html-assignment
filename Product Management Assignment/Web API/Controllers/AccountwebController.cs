using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Web_API.Models;

namespace Web_API.Controllers
{
    public class AccountwebController : Controller
    {
        UserEntities1 db = new UserEntities1();
        

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Account p)
        {
            if (ModelState.IsValid==true)
            {

                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("https://localhost:44301//api/Products");
                var insertrec = hc.PostAsJsonAsync<Account>("Accounts", p);
                insertrec.Wait();
                var Saverec = insertrec.Result;
                if (Saverec.IsSuccessStatusCode)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    ViewBag.InsertMeassage = "<script>alert('not register succefully !!')</script>";
                }
            }
            
            return View(p);
        }
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
                
                return RedirectToAction("Index", "Home");

            }
            else
            {
                
                ViewBag.ErrorMeassage = "<script>alert('email and password does not match !!')</script>";
            }
            return View();
        }

    }

}