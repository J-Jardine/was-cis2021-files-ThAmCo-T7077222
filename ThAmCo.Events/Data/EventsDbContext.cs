using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Data
{
    public class EventsDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<GuestBooking> Guests { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Staffing> Staffing { get; set; }


        private IHostingEnvironment HostEnv { get; }

        public EventsDbContext(DbContextOptions<EventsDbContext> options,
                               IHostingEnvironment env) : base(options)
        {
            HostEnv = env;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("thamco.events");

            builder.Entity<GuestBooking>()
                   .HasKey(b => new { b.CustomerId, b.EventId });

            builder.Entity<Customer>()
                   .HasMany(c => c.Bookings)
                   .WithOne(b => b.Customer)
                   .HasForeignKey(b => b.CustomerId);

            builder.Entity<Event>()
                   .HasMany(e => e.Bookings)
                   .WithOne(b => b.Event)
                   .HasForeignKey(b => b.EventId);

            builder.Entity<Event>()
                   .Property(e => e.TypeId)
                   .IsFixedLength();

            builder.Entity<Staff>()
                .HasMany(c => c.Staffings)
                .WithOne(b => b.Staff)
                .HasForeignKey(b => b.StaffId);

            builder.Entity<Staffing>()
                .HasKey(s => new { s.StaffId, s.EventId });

            // seed data for debug / development testing
            if (HostEnv != null && HostEnv.IsDevelopment())
            {
                builder.Entity<Customer>().HasData(
                    new Customer { Id = 1, Surname = "Smith", FirstName = "Liam", Email = "LiamSmith@aol.com" },
                    new Customer { Id = 2, Surname = "Clark", FirstName = "Emma", Email = "EmmaClark@icloud.com" },
                    new Customer { Id = 3, Surname = "Roberts", FirstName = "Noah", Email = "NoahRoberts@gmail.com" },
                    new Customer { Id = 4, Surname = "Wilson", FirstName = "Ava", Email = "AvaWilson@yahoo.com" },
                    new Customer { Id = 5, Surname = "Williams", FirstName = "James", Email = "JamesWilliams@aol.com" },
                    new Customer { Id = 6, Surname = "Jones", FirstName = "Isabella", Email = "IsabellaJones@yahoo.com" },
                    new Customer { Id = 7, Surname = "Cook", FirstName = "Elijah", Email = "ElijahCook@icloud.com" },
                    new Customer { Id = 8, Surname = "Davies", FirstName = "Sofia", Email = "SofiaDavies@outlook.com" },
                    new Customer { Id = 9, Surname = "Thomas", FirstName = "Logan", Email = "LoganThomas@gmail.com" },
                    new Customer { Id = 10, Surname = "Johnson", FirstName = "Mia", Email = "MiaJohnson@outlook.com" },
                    new Customer { Id = 11, Surname = "Allen", FirstName = "Mason", Email = "MasonAllen@aol.com" },
                    new Customer { Id = 12, Surname = "Baker", FirstName = "Camila", Email = "CamilaBaker@outlook.com" },
                    new Customer { Id = 13, Surname = "Atkinson", FirstName = "Henry", Email = "HenryAtkinson@gmail.com" },
                    new Customer { Id = 14, Surname = "Cole", FirstName = "Abigail", Email = "AbigailCole@icloud.com" },
                    new Customer { Id = 15, Surname = "Evans", FirstName = "Aiden", Email = "AidenEvans@aol.com" },
                    new Customer { Id = 16, Surname = "Fletcher", FirstName = "Grace", Email = "GraceFletcher@outlook.com" },
                    new Customer { Id = 17, Surname = "Gibson", FirstName = "Dylan", Email = "DylanGibson@gmail.com" },
                    new Customer { Id = 18, Surname = "Hall", FirstName = "Harper", Email = "HarperHall@yahoo.com" },
                    new Customer { Id = 19, Surname = "Anderson", FirstName = "Levi", Email = "LeviAnderson@gmail.com" },
                    new Customer { Id = 20, Surname = "Hughes", FirstName = "Hannah", Email = "HannahHughes@icloud.com" }
                );

                builder.Entity<Event>().HasData(
                    new Event { Id = 1, Title = "Beer, Bourbon & BBQ", Date = new DateTime(2020, 1, 10), Duration = new TimeSpan(12, 0, 0), TypeId = "BBB" },
                    new Event { Id = 2, Title = "Chocolate, Wine & Whiskey", Date = new DateTime(2020, 1, 25), Duration = new TimeSpan(12, 0, 0), TypeId = "CWW" },
                    new Event { Id = 3, Title = "Wine & Steak Tasting", Date = new DateTime(2016, 2, 12), Duration = new TimeSpan(6, 0, 0), TypeId = "WST" }
                );

                builder.Entity<GuestBooking>().HasData(
                    new GuestBooking { CustomerId = 1, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 2, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 3, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 4, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 5, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 6, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 7, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 8, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 9, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 10, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 11, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 12, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 13, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 14, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 15, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 16, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 17, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 18, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 19, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 20, EventId = 1, Attended = false },
                    new GuestBooking { CustomerId = 1, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 2, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 3, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 4, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 5, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 6, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 7, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 8, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 9, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 10, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 11, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 12, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 13, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 14, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 15, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 16, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 17, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 18, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 19, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 20, EventId = 2, Attended = false },
                    new GuestBooking { CustomerId = 1, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 2, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 3, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 4, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 5, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 6, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 7, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 8, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 9, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 10, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 11, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 12, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 13, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 14, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 15, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 16, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 17, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 18, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 19, EventId = 3, Attended = false },
                    new GuestBooking { CustomerId = 20, EventId = 3, Attended = false }
                );

                builder.Entity<Staff>().HasData(
                    new Staff { Id = 1, Surname = "Bush", FirstName = "Florence", Email = "FlorenceBush@ThAmCo.co.uk"},
                    new Staff { Id = 2, Surname = "Jardine", FirstName = "Jacob", Email = "JacobJardine@ThAmCo.co.uk" },
                    new Staff { Id = 3, Surname = "Lawrence", FirstName = "Anastasia", Email = "AnastasiaLawrence@ThAmCo.co.uk" },
                    new Staff { Id = 4, Surname = "Adams", FirstName = "Ewan", Email = "EwanAdams@ThAmCo.co.uk" },
                    new Staff { Id = 5, Surname = "Chapman", FirstName = "Esmay", Email = "EsmayChapman@ThAmCo.co.uk" },
                    new Staff { Id = 6, Surname = "Ferguson", FirstName = "Max", Email = "MaxFerguson@ThAmCo.co.uk" },
                    new Staff { Id = 7, Surname = "Banks", FirstName = "Isla", Email = "IslaBanks@ThAmCo.co.uk" },
                    new Staff { Id = 8, Surname = "Watson", FirstName = "Felix", Email = "FelixWatson@ThAmCo.co.uk" }
                );

                builder.Entity<Staffing>().HasData(
                    new Staffing { StaffId = 1, EventId = 1 },
                    new Staffing { StaffId = 2, EventId = 2 },
                    new Staffing { StaffId = 3, EventId = 1 },
                    new Staffing { StaffId = 4, EventId = 2 },
                    new Staffing { StaffId = 5, EventId = 1 },
                    new Staffing { StaffId = 6, EventId = 2 },
                    new Staffing { StaffId = 7, EventId = 1 },
                    new Staffing { StaffId = 8, EventId = 2 },
                    new Staffing { StaffId = 3, EventId = 3 }

                );
            }
        }
    }
}
