using Persistence.Models;
using System.Collections.Generic;

namespace Persistence.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        void Create(Product product);
    }
}
