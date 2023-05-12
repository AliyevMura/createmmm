using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.PowerBI.Api.Models;
using WebTaskLayout.DAL;

namespace WebTaskLayout
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //builder.Services.AddControllersWithViews
            // var app = builder.Build();
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));


            });
            var app = builder.Build();
            //app.MapGet("/", () => "Hello World!");
            app.UseRouting();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
    name: "Areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            
                endpoints.MapDefaultControllerRoute();
        });

       
            app.Run();
        }
}
}