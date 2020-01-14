using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Events.Data.Migrations
{
    public partial class AddingEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Events",
                columns: new[] { "Id", "Date", "Duration", "Title", "TypeId", "Venue", "VenueCost" },
                values: new object[] { 4, new DateTime(2016, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0), "Bob's Big 50", "PTY", null, 0m });

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Events",
                columns: new[] { "Id", "Date", "Duration", "Title", "TypeId", "Venue", "VenueCost" },
                values: new object[] { 5, new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0), "Best Wedding Yet", "WED", null, 0m });

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Events",
                columns: new[] { "Id", "Date", "Duration", "Title", "TypeId", "Venue", "VenueCost" },
                values: new object[] { 6, new DateTime(2018, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0), "Best-er Wedding Yet", "WED", null, 0m });

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Staffing",
                columns: new[] { "StaffId", "EventId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Staffing",
                columns: new[] { "StaffId", "EventId" },
                values: new object[] { 2, 5 });

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Staffing",
                columns: new[] { "StaffId", "EventId" },
                values: new object[] { 2, 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Staffing",
                keyColumns: new[] { "StaffId", "EventId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Staffing",
                keyColumns: new[] { "StaffId", "EventId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Staffing",
                keyColumns: new[] { "StaffId", "EventId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
