using FluentValidation;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OCS.BLL.Managers.Concrete;
using OCS.DAL.Data;
using OCS.DAL.Repositories.Abstract;
using OCS.DAL.Repositories.Concrete;
using OCS.DAL.Services.Abstract;
using OCS.DAL.Services.Concrete;
using OCS.DTO;
using OCS.Entities.Concrete;
using System.Reflection;

namespace OCS.AdminApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();

            builder.Services.AddDbContext<OCSDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("OCSAppDbStr"));
            }, ServiceLifetime.Scoped);


            builder.Services.AddIdentity<AppUser, IdentityRole<int>>(
                opt =>
                {
                    opt.SignIn.RequireConfirmedEmail = true;

                    opt.User.RequireUniqueEmail = true;

                    opt.Password.RequireDigit = true;
                    opt.Password.RequireLowercase = true;
                    opt.Password.RequireUppercase = true;
                    opt.Password.RequireNonAlphanumeric = true;
                    opt.Password.RequiredUniqueChars = 1;
                    opt.Password.RequiredLength = 8;
                }
                        )
                        .AddDefaultTokenProviders()
                        .AddEntityFrameworkStores<OCSDbContext>();

            builder.Services.AddScoped<CategoryRepo>();
            builder.Services.AddScoped<CategoryService>();
            builder.Services.AddScoped<CategoryManager>();
            //----------------------------------------------
            builder.Services.AddScoped<ProductRepo>();
            builder.Services.AddScoped<ProductService>();
            builder.Services.AddScoped<ProductManager>();
            //----------------------------------------------
            builder.Services.AddScoped<OrderRepo>();
            builder.Services.AddScoped<OrderService>();
            builder.Services.AddScoped<OrderManager>();
            //----------------------------------------------
            builder.Services.AddScoped<OrderItemRepo>();
            builder.Services.AddScoped<OrderItemService>();
            builder.Services.AddScoped<OrderItemManager>();
            //----------------------------------------------
            builder.Services.AddScoped<PaymentRepo>();
            builder.Services.AddScoped<PaymentService>();
            builder.Services.AddScoped<PaymentManager>();
            //----------------------------------------------
            builder.Services.AddScoped<ReviewRepo>();
            builder.Services.AddScoped<ReviewService>();
            builder.Services.AddScoped<ReviewManager>();


            builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());


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
