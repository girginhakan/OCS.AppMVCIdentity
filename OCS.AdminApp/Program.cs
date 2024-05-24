
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OCS.DAL.Data;
using OCS.Entities.Concrete;

namespace OCS.AdminApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<OCSDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("OCSAppDbStr"));
            });

            builder.Services.AddIdentityCore<AppUser>()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<OCSDbContext>();

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