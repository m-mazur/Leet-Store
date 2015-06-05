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
        private ProductRepository productRepo;

        public StoreController()
        {
            productRepo = new ProductRepository();
        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepo.GetAllProducts();
        }

        public void AddNewProduct(Product product)
        {
            productRepo.AddNewProduct(product);
        }
    }
}
