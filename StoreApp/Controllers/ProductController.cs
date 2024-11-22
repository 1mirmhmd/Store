using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        public IEnumerable<Product> Index()
        {
            var context = new RepositoryContext(
                new DbContextOptionsBuilder<RepositoryContext>().UseSqlite("Data Source = C:\\Users\\miruz\\OneDrive\\Belgeler\\MVC\\ProductDb.db").Options
            );
            return context.Products;
            // yukarıda dbcontext bağlantısı olmadan veriyi gösterir 
            // return new List<Product>(){
            //     new Product(){ProductId=1, ProductName="Computer",Price=500000}};
        }
    }
}