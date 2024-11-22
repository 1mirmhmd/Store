using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        //Dependency Injection pattern'i
        private readonly RepositoryContext _context;
        public ProductController(RepositoryContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> Index()

        {   // Dependency Injection ile buna gerek kalmadı
            // var context = new RepositoryContext(
            //     new DbContextOptionsBuilder<RepositoryContext>().UseSqlite("Data Source = İC:\\Users\\miruz\\OneDrive\\Belgeler\\MVC\\ProductDb.db").Options
            // );
            return _context.Products;
            // yukarıda dbcontext bağlantısı olmadan veriyi gösterir 
            // return new List<Product>(){
            //     new Product(){ProductId=1, ProductName="Computer",Price=500000}};
        }
    }
}