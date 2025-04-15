using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        // Dependency Injection Pattern'i
        /* Servis devreye girdiği anda bağlantı dizesini otomatik oluşturacak RepContext'i new'leyecek
           ve kullanabilecek context ifadesi verecek */
        private readonly RepositoryContext _context;
        public ProductController(RepositoryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.Products.ToList();
            return View(model);
        }
        public IActionResult Get(int id)

        {
            Product product = _context.Products.First(p => p.ProductId.Equals(id));
            return View(product);
        }
    }
}