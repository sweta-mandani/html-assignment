using Product_Management.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;
using NLog;

namespace Product_Management.Controllers
{
    public class HomeController : Controller
    {
        UserEntities1 db = new UserEntities1();
        private static Logger logger = LogManager.GetCurrentClassLogger();

        //Login success
        public ActionResult Index()
        {

            if (Session["UserId"] == null)
            {
                TempData["Login"] = "<script>alert('Plz..Login account!!')</script>";
                return RedirectToAction("Login", "Account");

            }
            else
            {
                return View();
            }
        }


        //Add Product 
        public ActionResult AddProduct()
        {
            return View();

        }

        [HttpPost]
        public ActionResult AddProduct(string AddProduct, string cancle, Product p, HttpPostedFileBase img)
        {



            if (ModelState.IsValid == true)
            {
                string path = Uploadimage(img);
                if (path.Equals("-1"))
                {
                    path = "-1";

                }
                else
                {

                    p.Small_Image = path;
                    db.Products.Add(p);
                    int a = db.SaveChanges();
                    if (a > 0)
                    {

                        ModelState.Clear();
                        TempData["insertmess"] = "<script> alert('Add Product Succefully !')</script>";
                        logger.Info("add product Succefully" + Environment.NewLine + DateTime.Now);
                        return RedirectToAction("ListProduct", "Home");
                    }
                    else
                    {
                        logger.Info("not  add product Succefully" + Environment.NewLine + DateTime.Now);
                        TempData["insertmess"] = "<script>alert('not Add Poduct Succefully !!')</script>";
                    }
                }
            }

            return View();
        }


        // cancle Buttton 
        [HttpPost]
        public ActionResult CancelForm()
        {
            
            return RedirectToAction("AddProduct", "Home");
        }




        //List Of Product
        public ActionResult ListProduct(string SearchBy, string Search, int? i, String SortBy)
        {
            ViewBag.SortProductNameParameter = string.IsNullOrEmpty(SortBy) ? "ProductName desc" : "";
            ViewBag.SortCategoeryParameter = SortBy == "Categoery " ? "Categoery  desc" : "Categoery";

            var Products = db.Products.AsQueryable();


            if (SearchBy == "ProductName")
            {
                
                Products = Products.Where(model => model.ProductName.StartsWith(Search) || Search == null);
                ModelState.Clear();
                logger.Info("search by product name" + Environment.NewLine + DateTime.Now);
            }
            else
            {
               
                
                Products = Products.Where(model => model.Categoery.Contains(Search) || Search == null);
                ModelState.Clear();
                logger.Info("search by Cauegoery name" + Environment.NewLine + DateTime.Now);
            }
            switch (SortBy)
            {
                case "ProductName desc":
                    Products = Products.OrderByDescending(model => model.ProductName);
                    break;
                case "Categoery  desc":
                    Products = Products.OrderBy(model => model.Categoery);
                    break;
                case "Categoery":
                    Products = Products.OrderBy(model => model.Categoery);
                    break;
                default:
                    Products = Products.OrderBy(model => model.ProductName);
                    break;
            }
            return View(Products.ToPagedList(i ?? 1, 3));
        }


        //Delete Product
        public ActionResult Delete(int? id)
        {
            
            Product list = db.Products.Find(id);
            return View(list);

        }


        [HttpPost]
         public ActionResult Delete(IEnumerable<int> id)
        {
            if (id == null)
            {
                TempData["Delete"] = "<script>alert('Plz select Item')</script>";
                
                return RedirectToAction("ListProduct");
            }
            else
            {
                
                var list = db.Products.Where(model => id.Contains(model.ProductId)).ToList();
                foreach (Product c in list)
                {
                    db.Products.Remove(c);
                    db.SaveChanges();
                    
                }
                logger.Info("Delete product" + Environment.NewLine + DateTime.Now);
                return RedirectToAction("ListProduct");
            }
        }



        //Edit Product
        public ActionResult Edit(int Id)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            var std = db.Products.Where(model => model.ProductId == Id).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Product p, HttpPostedFileBase img1)
        {

            if (ModelState.IsValid == true)
            {
                string path = Uploadimage(img1);
                if (path.Equals("-1"))
                {
                    path = "-1";

                }
                else
                {
                    var Pro = db.Products.Where(model => model.ProductId == p.ProductId).FirstOrDefault();
                    p.Small_Image = path;
                    db.Products.Remove(Pro);
                    db.Products.Add(p);
                    db.SaveChanges();
                }

             }

            logger.Info("Modify product" + Environment.NewLine + DateTime.Now);
            return RedirectToAction("ListProduct");
        }



        //LogOut 
        public ActionResult Logout()
        {
            Session.Abandon();
            logger.Info("logout success" + Environment.NewLine + DateTime.Now);
            return RedirectToAction("Login", "Account");
        }



        //Image Upload 
        public String Uploadimage(HttpPostedFileBase file)
        {
            Random r = new Random();
            string path = "-1";
            int random = r.Next();
            if (file != null && file.ContentLength > 0)
            {
                string extension = System.IO.Path.GetExtension(file.FileName);
                if (extension.ToLower().Equals(".jpg") || extension.ToLower().Equals(".jpeg") || extension.ToLower().Equals(".png"))
                {
                    try
                    {
                        path = Path.Combine(Server.MapPath("~/Content/Upload"), random + Path.GetFileName(file.FileName));
                        file.SaveAs(path);
                        path = "~/Content/Upload/" + random + Path.GetFileName(file.FileName);

                    }
                    catch (Exception ex)
                    {
                        path = "-1";
                        logger.ErrorException("Exception To Upload Image", ex);

                    }
                }
                else
                {
                    Response.Write("<script>alert('only jpg,jpeg,and png formate are accepted');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('please select a file');</script>");
                path = "-1";

            }
            return path;
           }
       }
}