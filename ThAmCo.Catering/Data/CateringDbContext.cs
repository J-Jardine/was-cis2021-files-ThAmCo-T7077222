using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ThAmCo.Catering.Controllers
{
    /// <summary>
    /// Linking to the database for ThAmCo.Catering
    /// </summary>
    public class CateringDbContext : DbContext
    {
        /// <summary>
        /// Menu lists
        /// </summary>
        public DbSet<Menu> Menu { get; set; }

        /// <summary>
        /// list of food bookings
        /// </summary>
        public DbSet<FoodBooking> FoodBooking { get; set; }

        /// <summary>
        /// Host environment for database
        /// </summary>
        private IHostingEnvironment HostEnv { get; }

        /// <summary>
        /// New DbContext
        /// </summary>
        /// <param name="options"></param>
        /// <param name="env"></param>
        public CateringDbContext(DbContextOptions<CateringDbContext> options,
                               IHostingEnvironment env) : base(options)
        {
            HostEnv = env;
        }

        /// <summary>
        /// Setting up the databse configuration
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }

        /// <summary>
        /// Calling the database on create
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("thamco.catering");

            builder.Entity<Menu>()
                   .HasMany(b => b.Booking)
                   .WithOne(a => a.Menu)
                   .HasForeignKey(a => a.MenuId);

            builder.Entity<FoodBooking>()
                   .HasKey(c => new { c.MenuId, c.EventId });
            if (HostEnv != null && HostEnv.IsDevelopment())
            {
                builder.Entity<Menu>().HasData(
                        new Menu { Id = 1, Starter = "Tomato Soup", Main = "Spaghetti Carbonara", Desert = "Chocolate Pudding", Cost = 10.0m},
                        new Menu { Id = 2, Starter = "Cheese Balls", Main = "Chicken Parmasan", Desert = "Mixed Berry Mousse", Cost = 20.3m},
                        new Menu { Id = 3, Starter = "Part Bake Bread & Butter", Main = "Double Cheese Burger", Desert = "Mango & Coconut Souffle", Cost = 10.7m},
                        new Menu { Id = 4, Starter = "Cheese Balls", Main = "Chicken Shawarma Skewers", Desert = "Homemade Carrot Cake", Cost = 07.5m},
                        new Menu { Id = 5, Starter = "Grilled Scallops", Main = "Chicken Katsu", Desert = "Matcha Cake", Cost = 14.4m},
                        new Menu { Id = 6, Starter = "Duck Pancakes", Main = "Pepperoni Pizza", Desert = "Pancakes", Cost = 15.3m},
                        new Menu { Id = 7, Starter = "Nachos", Main = "Thai Green Curry", Desert = "Lemon Meringue Pie", Cost = 9.7m},
                        new Menu { Id = 8, Starter = "Salt & Pepper Squid", Main = "Sword Fish", Desert = "Chocolate Pot x3", Cost = 11.2m},
                        new Menu { Id = 9, Starter = "Hummus Board", Main = "Salt & Pepper Chicken", Desert = "Cheese Board", Cost = 15.1m},
                        new Menu { Id = 10, Starter = "Garlic Bread", Main = "Fillet Steak", Desert = "Tea & Coffee", Cost = 20.0m}
                    );

                builder.Entity<FoodBooking>().HasData(
                        new FoodBooking { MenuId = 1, EventId = 1},
                        new FoodBooking { MenuId = 4, EventId = 2},
                        new FoodBooking { MenuId = 7, EventId = 3},
                        new FoodBooking { MenuId = 8, EventId = 4},
                        new FoodBooking { MenuId = 10, EventId = 5},
                        new FoodBooking { MenuId = 5, EventId = 6}
                    );
            }

        }
    }
}
