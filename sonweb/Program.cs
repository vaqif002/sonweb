using Microsoft.EntityFrameworkCore;
using sonweb.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    //options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
    options.UseSqlServer(builder.Configuration["ConnectionStrings:Default"]);

});
var app = builder.Build();
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("Home/Error");
//}
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

    endpoints.MapDefaultControllerRoute();
});

app.Run();