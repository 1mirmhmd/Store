using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
// Servis kaydı gerçekleştirildi. Middleware yapıları ile kullanılabilir
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseHttpsRedirection();
app.UseRouting();
app.MapControllerRoute( // bu şekilde de olabilir => ("default","{controller=Home}/{Action=Index}/{id?}");
    name:"default",
    pattern:"{controller=Home}/{Action=Index}/{id?}");

app.Run();
