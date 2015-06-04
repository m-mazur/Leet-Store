using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Leet_Store.Models;

namespace Leet_Store.Controllers
{
    public class StoreController : ApiController
    {
        public List<Product> GetSingleProduct()
        {
            var product = new Product();
            product.ProductId = 1;
            product.ProductName = "tretton37";
            product.ProductPrice = 1337;
            product.ProductDescription = "Simply leet";

            var products = new List<Product>();

            products.Add(product);

            return products;
        }
    }
}
