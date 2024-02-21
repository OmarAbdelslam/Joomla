using Microsoft.EntityFrameworkCore;
using Mobil_Market.Models.IRepositry;
using Mobile_Market.Models;
using Mobile_Market.Models.DBwork;

namespace Suq_com
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<dbcontext>(Option =>
            {
                Option.UseSqlServer("Data Source=DESKTOP-ORM81DG;Initial Catalog=Suq_Com;Integrated Security=True;TrustServerCertificate=True");
            });
            builder.Services.AddMvc();
            builder.Services.AddScoped<IRepositryDBcontext<Member>, MemebrRepositry>();

            var app = builder.Build();
            
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}