using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        public IEnumerable<Product> Index()
        {
            // Db'teki veriyi alma
            var context = new RepositoryContext(
                new DbContextOptionsBuilder<RepositoryContext>().UseSqlite("Data Source=C:\\Users\\miruz\\Documents\\MVC\\ProductDb.db").Options
            );

            return context.Products;
        }
    }
}