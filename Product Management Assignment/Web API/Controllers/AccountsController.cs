using Web_API.Models;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;


namespace WebApiInMVC.Controllers
{
    public class AccountsController : ApiController
    {
        private UserEntities1 db = new UserEntities1();
        // GET: api/Products
        public IHttpActionResult GetAccounts()
        {
            var res = db.Accounts.ToList();
            return Ok(res);
        }

        // GET: api/Products/5
        [ResponseType(typeof(Account))]
        public IHttpActionResult GetAccount(int id)
        {
            Account a = db.Accounts.Find(id);

            if (a == null)
            {
                return NotFound();
            }

            return Ok(a);
        }

        // PUT: api/Products/5
        [ResponseType(typeof(void))]
        [HttpPost]
        public IHttpActionResult PostRegister(Account a)
        {
            db.Accounts.Add(a);
            db.SaveChanges();

            return Ok();
        }

           
        
protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductExists(int id)
        {
            return db.Products.Count(e => e.ProductId == id) > 0;
        }
    }
}