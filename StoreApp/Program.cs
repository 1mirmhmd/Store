var builder = WebApplication.CreateBuilder(args);
// Servis kaydı gerçekleştirildi. Middleware yapıları ile kullanılabilir
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/btk", () => "Btk Akademi");

app.Run();
