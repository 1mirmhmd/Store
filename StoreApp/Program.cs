using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;


var builder = WebApplication.CreateBuilder(args);
// Servis kaydı gerçekleştirildi. Middleware yapıları ile kullanılabilir
builder.Services.AddControllersWithViews();
//Requestleri çözerken ihtiyaç olması durumunda veritabanı da kullanılması gerektiği bildiriliyor
builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));
});
var app = builder.Build();
app.UseStaticFiles(); // projede wwwroot içerisindeki static dosyaların kullanılması için konfigurasyon
app.UseHttpsRedirection();
app.UseRouting();
app.MapControllerRoute( // bu şekilde de olabilir => ("default","{controller=Home}/{Action=Index}/{id?}");
    name: "default",
    pattern: "{controller=Home}/{Action=Index}/{id?}");

app.Run();
