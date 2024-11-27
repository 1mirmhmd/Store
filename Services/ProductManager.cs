using Entities.Models;
using Microsoft.EntityFrameworkCore.Storage;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository _manager;

        public ProductManager(IProductRepository manager)
        {
            _manager = manager;
        }

        public IEnumerable<Product> GetAllProducts(bool trackChanges)
        {
            return _manager.GetAllProducts(trackChanges);
        }

        public Product? GetOneProduct(int id, bool trackChanges)
        {
            var product =_manager.GetOneProduct(id, trackChanges);
            if (product is null) throw new Exception("Not found!");
            else return product;
            
        }
    }
}