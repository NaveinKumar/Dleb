using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[] 
        { 
            new Product { Id = 1, Name = "Idly", Category = "Groceries", Price = 20.00M }, 
            new Product { Id = 2, Name = "Tea", Category = "Toys", Price = 10.00M }, 
            new Product { Id = 3, Name = "Cofee", Category = "Hardware", Price = 15.00M } 

        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
