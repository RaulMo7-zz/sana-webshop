using System.Collections.Generic;
using Persistence.Interfaces;
using Persistence.Models;
using System.Linq;

namespace Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void Create(Product product)
        {
            using (var db = new ProductContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (var db = new ProductContext())
            {
                return db.Products.ToList();
            }
        }

    }
}
