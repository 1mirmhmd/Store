using Repositories.Contracts;

namespace Repositories
{
    public class RepositoryManger : IRepositoryManager
    {
        private readonly RepositoryContext _context;

        private readonly IProductRepository _productRepository;

        public RepositoryManger(IProductRepository productRepository, RepositoryContext context = null)
        {
            _productRepository = productRepository;
            _context = context;
        }

        public IProductRepository Product => _productRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}