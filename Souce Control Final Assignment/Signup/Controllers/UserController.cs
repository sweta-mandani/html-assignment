using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;
using Signup.Models;

namespace RegistrationForm.Controllers
{
    public class UserController : Controller
    {
        LoginEntities db = new LoginEntities();
        private static Logger logger = LogManager.GetCurrentClassLogger();

        // GET: User
        public ActionResult Index()
        {
            return View();


        }
        [HttpPost]
        public ActionResult Index(Student s)
        {
            try
            {
                var User = db.Students.Where(model => model.Email == s.Email && model.PassWord == s.PassWord).FirstOrDefault();
                if (User != null)
                {
                    logger.Info("login success" + Environment.NewLine + DateTime.Now);
                    Session["UserId"] = s.Id.ToString();
                    Session["Username"] = s.Email.ToString();


                    TempData["loginstatus"] = "<script>alert('login succefully !!')</script>";
                    return RedirectToAction("Index", "Login");
                    
                }
                else
                {
                    logger.Info("email password does not match" + Environment.NewLine + DateTime.Now);
                    ViewBag.ErrorMeassage = "<script>alert('email and password does not match !!')</script>";
                }
             }

            catch(Exception ex)
            {
                logger.Error("Error occured in User controller Index Action", ex);
            }
                return View();
        }

        public ActionResult Registre()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registre(Student s, HttpPostedFileBase img)
        {
            try
            {

                if (ModelState.IsValid == true)
                {
                    string path = Uploadimage(img);
                    if (path.Equals("-1"))
                    {
                        logger.Error("image path not find");

                    }
                    else
                    {

                        s.User_Image = path;
                        db.Students.Add(s);
                        int a = db.SaveChanges();
                        if (a > 0)
                        {
                            ViewBag.InsertMeassage = "<script>alert('register succefully !!')</script>";
                            ModelState.Clear();
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ViewBag.InsertMeassage = "<script>alert('not register succefully !!')</script>";
                        }
                    }
                }
                logger.Info("register success" + Environment.NewLine + DateTime.Now);
            }


            catch (Exception ex)
            {
                logger.ErrorException("Error occured in User controller Register Action", ex);
            }
            return View();
           
        }
        public String Uploadimage(HttpPostedFileBase File)
        {
            Random r = new Random();
            string path = "-1";
            int random = r.Next();
            if (File != null && File.ContentLength > 0)
            {
                string extension = System.IO.Path.GetExtension(File.FileName);
                if (extension.ToLower().Equals(".jpg") || extension.ToLower().Equals(".jpeg") || extension.ToLower().Equals(".png"))
                {
                    try
                    {
                        path = Path.Combine(Server.MapPath("~/Content/Upload"), random + Path.GetFileName(File.FileName));
                        File.SaveAs(path);
                        path = "~/Content/Upload/" + random + Path.GetFileName(File.FileName);

                    }
                    catch (Exception ex)
                    {
                        path = "-1";
                        logger.ErrorException("not find image path ", ex);
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