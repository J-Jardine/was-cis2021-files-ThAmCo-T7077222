using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Events.Data.Migrations
{
    public partial class TookOutSomeInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Title", "TypeId" },
                values: new object[] { "Wine & Steak Tasting", "WST" });

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Staffing",
                columns: new[] { "StaffId", "EventId" },
                values: new object[] { 3, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Staffing",
                keyColumns: new[] { "StaffId", "EventId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Title", "TypeId" },
                values: new object[] { "Wine Tasting", "WTE" });

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Events",
                columns: new[] { "Id", "Date", "Duration", "Title", "TypeId" },
                values: new object[,]
                {
                    { 4, new DateTime(2016, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0), "Cheese Tasting", "CTE" },
                    { 5, new DateTime(2016, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0), "Steak & Wine Tasting", "SWT" },
                    { 6, new DateTime(2016, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0), "Beer Festival", "BFF" },
                    { 7, new DateTime(2016, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0), "Middlesbrough Film Festival", "MFF" },
                    { 8, new DateTime(2016, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0), "Chili Cook-Off", "CCO" },
                    { 9, new DateTime(2016, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0), "International Food Festival", "IFF" },
                    { 10, new DateTime(2016, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0), "Creative Film Festival", "CFF" }
                });
        }
    }
}
