﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Data.Migrations
{
    [DbContext(typeof(EventsDbContext))]
    partial class EventsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("thamco.events")
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ThAmCo.Events.Data.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new { Id = 1, Email = "LiamSmith@aol.com", FirstName = "Liam", Surname = "Smith" },
                        new { Id = 2, Email = "EmmaClark@icloud.com", FirstName = "Emma", Surname = "Clark" },
                        new { Id = 3, Email = "NoahRoberts@gmail.com", FirstName = "Noah", Surname = "Roberts" },
                        new { Id = 4, Email = "AvaWilson@yahoo.com", FirstName = "Ava", Surname = "Wilson" },
                        new { Id = 5, Email = "JamesWilliams@aol.com", FirstName = "James", Surname = "Williams" },
                        new { Id = 6, Email = "IsabellaJones@yahoo.com", FirstName = "Isabella", Surname = "Jones" },
                        new { Id = 7, Email = "ElijahCook@icloud.com", FirstName = "Elijah", Surname = "Cook" },
                        new { Id = 8, Email = "SofiaDavies@outlook.com", FirstName = "Sofia", Surname = "Davies" },
                        new { Id = 9, Email = "LoganThomas@gmail.com", FirstName = "Logan", Surname = "Thomas" },
                        new { Id = 10, Email = "MiaJohnson@outlook.com", FirstName = "Mia", Surname = "Johnson" },
                        new { Id = 11, Email = "MasonAllen@aol.com", FirstName = "Mason", Surname = "Allen" },
                        new { Id = 12, Email = "CamilaBaker@outlook.com", FirstName = "Camila", Surname = "Baker" },
                        new { Id = 13, Email = "HenryAtkinson@gmail.com", FirstName = "Henry", Surname = "Atkinson" },
                        new { Id = 14, Email = "AbigailCole@icloud.com", FirstName = "Abigail", Surname = "Cole" },
                        new { Id = 15, Email = "AidenEvans@aol.com", FirstName = "Aiden", Surname = "Evans" },
                        new { Id = 16, Email = "GraceFletcher@outlook.com", FirstName = "Grace", Surname = "Fletcher" },
                        new { Id = 17, Email = "DylanGibson@gmail.com", FirstName = "Dylan", Surname = "Gibson" },
                        new { Id = 18, Email = "HarperHall@yahoo.com", FirstName = "Harper", Surname = "Hall" },
                        new { Id = 19, Email = "LeviAnderson@gmail.com", FirstName = "Levi", Surname = "Anderson" },
                        new { Id = 20, Email = "HannahHughes@icloud.com", FirstName = "Hannah", Surname = "Hughes" }
                    );
                });

            modelBuilder.Entity("ThAmCo.Events.Data.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<TimeSpan?>("Duration");

                    b.Property<string>("Reference");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("TypeId")
                        .IsRequired()
                        .IsFixedLength(true)
                        .HasMaxLength(3);

                    b.Property<string>("Venue");

                    b.Property<decimal>("VenueCost");

                    b.Property<DateTime>("WhenMade");

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new { Id = 1, Capacity = 0, Date = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), Duration = new TimeSpan(0, 12, 0, 0, 0), Title = "Beer, Bourbon & BBQ", TypeId = "BBB", VenueCost = 0m, WhenMade = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), isDeleted = false },
                        new { Id = 2, Capacity = 0, Date = new DateTime(2020, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), Duration = new TimeSpan(0, 12, 0, 0, 0), Title = "Chocolate, Wine & Whiskey", TypeId = "CWW", VenueCost = 0m, WhenMade = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), isDeleted = false },
                        new { Id = 3, Capacity = 0, Date = new DateTime(2016, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), Duration = new TimeSpan(0, 6, 0, 0, 0), Title = "Wine & Steak Tasting", TypeId = "WST", VenueCost = 0m, WhenMade = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), isDeleted = false },
                        new { Id = 4, Capacity = 0, Date = new DateTime(2016, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), Duration = new TimeSpan(0, 6, 0, 0, 0), Title = "Bob's Big 50", TypeId = "PTY", VenueCost = 0m, WhenMade = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), isDeleted = false },
                        new { Id = 5, Capacity = 0, Date = new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Duration = new TimeSpan(0, 12, 0, 0, 0), Title = "Best Wedding Yet", TypeId = "WED", VenueCost = 0m, WhenMade = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), isDeleted = false },
                        new { Id = 6, Capacity = 0, Date = new DateTime(2018, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), Duration = new TimeSpan(0, 1, 0, 0, 0), Title = "Best-er Wedding Yet", TypeId = "WED", VenueCost = 0m, WhenMade = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), isDeleted = false }
                    );
                });

            modelBuilder.Entity("ThAmCo.Events.Data.GuestBooking", b =>
                {
                    b.Property<int>("CustomerId");

                    b.Property<int>("EventId");

                    b.Property<bool>("Attended");

                    b.HasKey("CustomerId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("Guests");

                    b.HasData(
                        new { CustomerId = 1, EventId = 1, Attended = false },
                        new { CustomerId = 2, EventId = 1, Attended = false },
                        new { CustomerId = 3, EventId = 1, Attended = false },
                        new { CustomerId = 4, EventId = 1, Attended = false },
                        new { CustomerId = 5, EventId = 1, Attended = false },
                        new { CustomerId = 6, EventId = 1, Attended = false },
                        new { CustomerId = 7, EventId = 1, Attended = false },
                        new { CustomerId = 8, EventId = 1, Attended = false },
                        new { CustomerId = 9, EventId = 1, Attended = false },
                        new { CustomerId = 10, EventId = 1, Attended = false },
                        new { CustomerId = 11, EventId = 1, Attended = false },
                        new { CustomerId = 12, EventId = 1, Attended = false },
                        new { CustomerId = 13, EventId = 1, Attended = false },
                        new { CustomerId = 14, EventId = 1, Attended = false },
                        new { CustomerId = 15, EventId = 1, Attended = false },
                        new { CustomerId = 16, EventId = 1, Attended = false },
                        new { CustomerId = 17, EventId = 1, Attended = false },
                        new { CustomerId = 18, EventId = 1, Attended = false },
                        new { CustomerId = 19, EventId = 1, Attended = false },
                        new { CustomerId = 20, EventId = 1, Attended = false },
                        new { CustomerId = 1, EventId = 2, Attended = false },
                        new { CustomerId = 2, EventId = 2, Attended = false },
                        new { CustomerId = 3, EventId = 2, Attended = false },
                        new { CustomerId = 4, EventId = 2, Attended = false },
                        new { CustomerId = 5, EventId = 2, Attended = false },
                        new { CustomerId = 6, EventId = 2, Attended = false },
                        new { CustomerId = 7, EventId = 2, Attended = false },
                        new { CustomerId = 8, EventId = 2, Attended = false },
                        new { CustomerId = 9, EventId = 2, Attended = false },
                        new { CustomerId = 10, EventId = 2, Attended = false },
                        new { CustomerId = 11, EventId = 2, Attended = false },
                        new { CustomerId = 12, EventId = 2, Attended = false },
                        new { CustomerId = 13, EventId = 2, Attended = false },
                        new { CustomerId = 14, EventId = 2, Attended = false },
                        new { CustomerId = 15, EventId = 2, Attended = false },
                        new { CustomerId = 16, EventId = 2, Attended = false },
                        new { CustomerId = 17, EventId = 2, Attended = false },
                        new { CustomerId = 18, EventId = 2, Attended = false },
                        new { CustomerId = 19, EventId = 2, Attended = false },
                        new { CustomerId = 20, EventId = 2, Attended = false },
                        new { CustomerId = 1, EventId = 3, Attended = false },
                        new { CustomerId = 2, EventId = 3, Attended = false },
                        new { CustomerId = 3, EventId = 3, Attended = false },
                        new { CustomerId = 4, EventId = 3, Attended = false },
                        new { CustomerId = 5, EventId = 3, Attended = false },
                        new { CustomerId = 6, EventId = 3, Attended = false },
                        new { CustomerId = 7, EventId = 3, Attended = false },
                        new { CustomerId = 8, EventId = 3, Attended = false },
                        new { CustomerId = 9, EventId = 3, Attended = false },
                        new { CustomerId = 10, EventId = 3, Attended = false },
                        new { CustomerId = 11, EventId = 3, Attended = false },
                        new { CustomerId = 12, EventId = 3, Attended = false },
                        new { CustomerId = 13, EventId = 3, Attended = false },
                        new { CustomerId = 14, EventId = 3, Attended = false },
                        new { CustomerId = 15, EventId = 3, Attended = false },
                        new { CustomerId = 16, EventId = 3, Attended = false },
                        new { CustomerId = 17, EventId = 3, Attended = false },
                        new { CustomerId = 18, EventId = 3, Attended = false },
                        new { CustomerId = 19, EventId = 3, Attended = false },
                        new { CustomerId = 20, EventId = 3, Attended = false }
                    );
                });

            modelBuilder.Entity("ThAmCo.Events.Data.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<bool>("FirstAider");

                    b.Property<string>("FirstName");

                    b.Property<string>("StaffCode");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Staff");

                    b.HasData(
                        new { Id = 1, Email = "FlorenceBush@ThAmCo.co.uk", FirstAider = false, FirstName = "Florence", StaffCode = "FBFB", Surname = "Bush" },
                        new { Id = 2, Email = "JacobJardine@ThAmCo.co.uk", FirstAider = false, FirstName = "Jacob", StaffCode = "JJJJ", Surname = "Jardine" },
                        new { Id = 3, Email = "AnastasiaLawrence@ThAmCo.co.uk", FirstAider = false, FirstName = "Anastasia", StaffCode = "ALAL", Surname = "Lawrence" },
                        new { Id = 4, Email = "EwanAdams@ThAmCo.co.uk", FirstAider = false, FirstName = "Ewan", StaffCode = "EAEA", Surname = "Adams" },
                        new { Id = 5, Email = "EsmayChapman@ThAmCo.co.uk", FirstAider = false, FirstName = "Esmay", StaffCode = "ECEC", Surname = "Chapman" },
                        new { Id = 6, Email = "MaxFerguson@ThAmCo.co.uk", FirstAider = false, FirstName = "Max", StaffCode = "MFMF", Surname = "Ferguson" },
                        new { Id = 7, Email = "IslaBanks@ThAmCo.co.uk", FirstAider = false, FirstName = "Isla", StaffCode = "IBIB", Surname = "Banks" },
                        new { Id = 8, Email = "FelixWatson@ThAmCo.co.uk", FirstAider = false, FirstName = "Felix", StaffCode = "FWFW", Surname = "Watson" }
                    );
                });

            modelBuilder.Entity("ThAmCo.Events.Data.Staffing", b =>
                {
                    b.Property<int>("StaffId");

                    b.Property<int>("EventId");

                    b.HasKey("StaffId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("Staffing");

                    b.HasData(
                        new { StaffId = 1, EventId = 1 },
                        new { StaffId = 2, EventId = 2 },
                        new { StaffId = 3, EventId = 1 },
                        new { StaffId = 4, EventId = 2 },
                        new { StaffId = 5, EventId = 1 },
                        new { StaffId = 6, EventId = 2 },
                        new { StaffId = 7, EventId = 1 },
                        new { StaffId = 8, EventId = 2 },
                        new { StaffId = 3, EventId = 3 },
                        new { StaffId = 1, EventId = 4 },
                        new { StaffId = 2, EventId = 5 },
                        new { StaffId = 2, EventId = 6 }
                    );
                });

            modelBuilder.Entity("ThAmCo.Events.Data.GuestBooking", b =>
                {
                    b.HasOne("ThAmCo.Events.Data.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ThAmCo.Events.Data.Event", "Event")
                        .WithMany("Bookings")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ThAmCo.Events.Data.Staffing", b =>
                {
                    b.HasOne("ThAmCo.Events.Data.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ThAmCo.Events.Data.Staff", "Staff")
                        .WithMany("Staffings")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
