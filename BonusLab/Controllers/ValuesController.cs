using BonusLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace BonusLab.Controllers
{
    public class ValuesController : ApiController
    {      

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        //Returns a list of all the products
        public JsonResult<List<DisplayProduct>> GetProducts()
        {
            NorthwindEntities db = new NorthwindEntities();
            List<Product> list = db.Products.ToList();
            List<DisplayProduct> productList = new List<DisplayProduct>();
            foreach (Product p in list)
            {
                productList.Add(new DisplayProduct(p.ProductID, p.ProductName));
            }
            return Json(productList);
        }

        //Returns a list of all the products by product id
        public JsonResult<Product> GetProducts(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            Product product = (from p in db.Products
                               where p.ProductID == id
                               select p).Single();            
            return Json(product);
        }
    }
}
