using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Leet_Store.Models;
using Dapper;
using System.Data;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Leet_Store.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["StrykDb"].ConnectionString);

        public IEnumerable<Product> GetAllProducts()
        {
            var sqlCmd = "SELECT * FROM Products";
            
            try
            {
                return this.db.Query<Product>(sqlCmd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AddNewProduct(Product product)
        {
            var sqlCmd = "INSERT INTO dbo.Products (ProductName, ProductPrice, ProductDescription) VALUES(@productName, @productPrice, @productDescription)";

            try
            {
                this.db.Query<Product>(sqlCmd,
                new
                {
                    productName = product.ProductName,
                    productPrice = product.ProductPrice,
                    productDescription = product.ProductDescription
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}