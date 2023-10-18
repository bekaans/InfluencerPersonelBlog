using Blogger.Data.Context;
using Blogger.Data.Extensions;
using Blogger.Service.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.LoadDataLayerExtensions(builder.Configuration);
builder.Services.LoadServiceLayerExtensions();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern:"Admin/{controller=Home}/{action=Index}/{id?}"
        );
    endpoints.MapDefaultControllerRoute();
});
app.Run();
