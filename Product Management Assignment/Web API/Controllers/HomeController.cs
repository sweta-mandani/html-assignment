using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Web_API.Models;
using System.Configuration;
using System.Threading.Tasks;
using System.Net;

namespace Web_API.Controllers
{
    public class HomeController : Controller
    {



        // GET: Home
        public ActionResult Home()
        {

            if (Session["UserId"] == null)
            {
                TempData["Login"] = "<script>alert('Plz..Login account!!')</script>";
                return RedirectToAction("Login", "Accountweb");

            }
            else
            {
                return View();
            }
        }
        public ActionResult Index()
        {
            IEnumerable<Product> p = null;
                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("https://localhost:44301//api/Products");
                var insertrec = hc.GetAsync("Products");
                insertrec.Wait();
                var Saverec = insertrec.Result;
                if (Saverec.IsSuccessStatusCode)
                {
                var display = Saverec.Content.ReadAsAsync<IList<Product>>();
                display.Wait();
                p = display.Result;
                    
                }
            
            return View(p);

        }

        // GET: Product


        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {

                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("https://localhost:44301//api/Products");
                var insertrec = hc.PostAsJsonAsync<Product>("Products", p);
                insertrec.Wait();
                var Saverec = insertrec.Result;
                if (Saverec.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(p);
        }
        public ActionResult Edit(int id)
        {
           Product p = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44301//api/");
            var insertrec = hc.GetAsync("Products?id="+id.ToString());
            insertrec.Wait();
            var Saverec = insertrec.Result;
            if (Saverec.IsSuccessStatusCode)
            {
                var display = Saverec.Content.ReadAsAsync<Product>();
                display.Wait();
                p = display.Result;

            }

            return View(p);

            
        }

        [HttpPost]
            public ActionResult Edit(Product p)
        {
         
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44301//api/Products");
            var insertrec = hc.PutAsJsonAsync<Product>("Products",p);
            insertrec.Wait();
            var Saverec = insertrec.Result;
            if (Saverec.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            else
            {
                ViewBag.Messa = "Not Edit";
            }

            return View("Create");

        }
        public ActionResult Delete(int id)
        {
            
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44301//api/Products");
            var insertrec = hc.DeleteAsync("Products/" + id.ToString());
            insertrec.Wait();
            var Saverec = insertrec.Result;
            if (Saverec.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }

            return View("Index");

        }
        public ActionResult Logout()
        {
            Session.Abandon();
            
            return RedirectToAction("Login", "Accountweb");
        }




    }
    }


