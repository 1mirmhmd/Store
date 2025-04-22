using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace StoreApp.Components
{
    public class ProductSummary : ViewComponent
    {
        // Önerilmeyen kullanım!
        private readonly RepositoryContext _context;

        public ProductSummary(RepositoryContext context)
        {
            _context = context;
        }
        public string Invoke()
        {
            return _context.Products.Count().ToString();
        }
    }
}