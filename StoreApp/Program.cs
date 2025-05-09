using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services;
using Services.Contracts;


var builder = WebApplication.CreateBuilder(args);
// Servis kaydı gerçekleştirildi. Middleware yapıları ile kullanılabilir
builder.Services.AddControllersWithViews();
//Requestleri çözerken ihtiyaç olması durumunda veritabanı da kullanılması gerektiği bildiriliyor
builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"),
    b => b.MigrationsAssembly("StoreApp"));
});
// IoC kayıtları
builder.Services.AddScoped<IRepositoryManager, RepositoryManger>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

builder.Services.AddScoped<IServiceManager, ServiceManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
var app = builder.Build();
app.UseStaticFiles(); // projede wwwroot içerisindeki static dosyaların kullanılması için konfigurasyon
app.UseHttpsRedirection();
app.UseRouting();

// birden fazla endpoint kullanıldığı durumda aşağıdaki şekilde olduğu gibi olur 
app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
);
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
});
app.Run();
