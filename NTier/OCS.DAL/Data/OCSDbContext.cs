using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OCS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OCS.DAL.Data
{
    public class OCSDbContext : IdentityDbContext<AppUser, IdentityRole<int>,int>
    {
        public OCSDbContext(DbContextOptions<OCSDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Product>().Property(p => p.Price).HasColumnType("decimal(18,2)");

            var hasher = new PasswordHasher<AppUser>();

            builder.Entity<AppUser>()
                .HasData(new AppUser
                {
                    Id = 1,
                    Name = "adminName",
                    Surname = "adminSurname",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@mail.com",
                    NormalizedEmail = "ADMIN@MAIL.COM",
                    BirthDate = new DateOnly(2024, 05, 25),
                    Gender = Common.Enums.Gender.None,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    PhoneNumber="-",
                    PasswordHash= hasher.HashPassword(null,"Az*123456"),
                    SecurityStamp=Guid.NewGuid().ToString()
                }) ;


            builder.Entity<IdentityRole<int>>()
                .HasData(new IdentityRole<int>
                {
                    Id=1,  
                    Name="Admin",
                    NormalizedName = "ADMIN",
                });

            builder.Entity<IdentityUserRole<int>>()
                .HasData(new IdentityUserRole<int>
                {
                    UserId = 1,
                    RoleId = 1
                });
        }


       
    }
}
