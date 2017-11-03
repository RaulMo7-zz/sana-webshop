using Persistence.Models;
using System.Data.Entity;

namespace Persistence
{
    public class ProductContext: DbContext
    {
        public ProductContext() : base ("WebShopDB")
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
