using Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.Models;

namespace Persistence.Repositories
{
    public class ProductMemoryRepository : IProductRepository
    {
        static List<Product> memoryProductList;

        public ProductMemoryRepository()
        {
            if (memoryProductList == null)
            {
                memoryProductList = new List<Product>();
            }
        }

        public void Create(Product product)
        {
            memoryProductList.Add(product);
        }

        public List<Product> GetAll()
        {
            return memoryProductList;
        }
    }
}
