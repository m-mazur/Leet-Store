using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Leet_Store.Models;
using Leet_Store.Repositories;

namespace Leet_Store.Controllers
{
    public class StoreController : ApiController
    {
        public IEnumerable<Product> GetSingleProduct()
        {
            var productRepo = new ProductRepository();
            return productRepo.GetAllProducts();
        }
    }
}
