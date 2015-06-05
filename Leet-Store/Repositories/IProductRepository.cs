using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leet_Store.Models;

namespace Leet_Store.Repositories
{
    interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        void AddNewProduct(Product product);
    }
}
