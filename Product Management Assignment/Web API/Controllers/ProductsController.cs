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
    public class ProductsController : ApiController
    {
        private UserEntities1 db = new UserEntities1();
        // GET: api/Products
        public IHttpActionResult GetProducts()
        {
            var res = db.Products.ToList();
            return Ok(res);
        }

        // GET: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(int id)
        {
            Product product = db.Products.Find(id);
    
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProduct( Product product)
        {
            var update = db.Products.Where(x => x.ProductId == product.ProductId).FirstOrDefault<Product>();

            if (update != null)
            {
                update.ProductId = product.ProductId;
                update.ProductName = product.ProductName;
                update.Categoery = product.Categoery;
                update.Quantity = product.Quantity;
                update.Small_Image = product.Small_Image;
                update.Short_Description = product.Short_Description;
                update.Price = product.Price;
                
              
                db.SaveChanges();
            }
            else
            {
                return NotFound();
            }

            return Ok();
        }

        // POST: api/Products
        [ResponseType(typeof(Product))]
        [HttpPost]
        public IHttpActionResult PostProduct(Product product)
        {


            db.Products.Add(product);
            db.SaveChanges();

            return Ok();
        }

        // DELETE: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult DeleteProduct(int id)
        {
            var update = db.Products.Where(x => x.ProductId == id).FirstOrDefault();
            db.Entry(update).State = System.Data.Entity.EntityState.Deleted;


           
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