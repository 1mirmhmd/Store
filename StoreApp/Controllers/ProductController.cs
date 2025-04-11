using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        public IEnumerable<Product> Index()
        {
            // Bu şekilde veriye ulaşabiliriz
            return new List<Product>()
            {
                new Product(){
                    ProductId=1,
                    ProductName="USB connecter",
                    Price=123
                }
            };
        }
    }
}