using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Events.Data.Migrations
{
    public partial class MoreFillerInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Duration" },
                values: new object[] { new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Events",
                columns: new[] { "Id", "Date", "Duration", "Title", "TypeId" },
                values: new object[,]
                {
                    { 3, new DateTime(2016, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0), "Wine Tasting", "WTE" },
                    { 4, new DateTime(2016, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0), "Cheese Tasting", "CTE" },
                    { 5, new DateTime(2016, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0), "Steak & Wine Tasting", "SWT" },
                    { 6, new DateTime(2016, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0), "Beer Festival", "BFF" },
                    { 7, new DateTime(2016, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0), "Middlesbrough Film Festival", "MFF" },
                    { 8, new DateTime(2016, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0), "Chili Cook-Off", "CCO" },
                    { 9, new DateTime(2016, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0), "International Food Festival", "IFF" },
                    { 10, new DateTime(2016, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0), "Creative Film Festival", "CFF" }
                });

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Guests",
                columns: new[] { "CustomerId", "EventId", "Attended" },
                values: new object[,]
                {
                    { 1, 3, false },
                    { 18, 3, false },
                    { 17, 3, false },
                    { 16, 3, false },
                    { 15, 3, false },
                    { 14, 3, false },
                    { 13, 3, false },
                    { 12, 3, false },
                    { 11, 3, false },
                    { 10, 3, false },
                    { 9, 3, false },
                    { 8, 3, false },
                    { 7, 3, false },
                    { 6, 3, false },
                    { 5, 3, false },
                    { 4, 3, false },
                    { 3, 3, false },
                    { 2, 3, false },
                    { 19, 3, false },
                    { 20, 3, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 19, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Duration" },
                values: new object[] { new DateTime(2016, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0) });

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
