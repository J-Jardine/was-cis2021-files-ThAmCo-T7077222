using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Events.Data.Migrations
{
    public partial class AdditionalFillerInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "thamco.events",
                table: "Staff",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "Surname" },
                values: new object[] { "LiamSmith@aol.com", "Liam", "Smith" });

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "Surname" },
                values: new object[] { "EmmaClark@icloud.com", "Emma", "Clark" });

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "Surname" },
                values: new object[] { "NoahRoberts@gmail.com", "Noah", "Roberts" });

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "Surname" },
                values: new object[,]
                {
                    { 20, "HannahHughes@icloud.com", "Hannah", "Hughes" },
                    { 19, "LeviAnderson@gmail.com", "Levi", "Anderson" },
                    { 18, "HarperHall@yahoo.com", "Harper", "Hall" },
                    { 16, "GraceFletcher@outlook.com", "Grace", "Fletcher" },
                    { 15, "AidenEvans@aol.com", "Aiden", "Evans" },
                    { 14, "AbigailCole@icloud.com", "Abigail", "Cole" },
                    { 13, "HenryAtkinson@gmail.com", "Henry", "Atkinson" },
                    { 12, "CamilaBaker@outlook.com", "Camila", "Baker" },
                    { 17, "DylanGibson@gmail.com", "Dylan", "Gibson" },
                    { 10, "MiaJohnson@outlook.com", "Mia", "Johnson" },
                    { 9, "LoganThomas@gmail.com", "Logan", "Thomas" },
                    { 8, "SofiaDavies@outlook.com", "Sofia", "Davies" },
                    { 7, "ElijahCook@icloud.com", "Elijah", "Cook" },
                    { 11, "MasonAllen@aol.com", "Mason", "Allen" },
                    { 6, "IsabellaJones@yahoo.com", "Isabella", "Jones" },
                    { 5, "JamesWilliams@aol.com", "James", "Williams" },
                    { 4, "AvaWilson@yahoo.com", "Ava", "Wilson" }
                });

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Title", "TypeId" },
                values: new object[] { "Beer, Bourbon & BBQ", "BBB" });

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Title", "TypeId" },
                values: new object[] { "Chocolate, Wine & Whiskey", "CWW" });

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 1, 1 },
                column: "Attended",
                value: false);

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Guests",
                columns: new[] { "CustomerId", "EventId", "Attended" },
                values: new object[,]
                {
                    { 3, 1, false },
                    { 2, 2, false }
                });

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "FlorenceBush@ThAmCo.co.uk");

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "JacobJardine@ThAmCo.co.uk");

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3,
                column: "Email",
                value: "AnastasiaLawrence@ThAmCo.co.uk");

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Staff",
                keyColumn: "Id",
                keyValue: 4,
                column: "Email",
                value: "EwanAdams@ThAmCo.co.uk");

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Staff",
                keyColumn: "Id",
                keyValue: 5,
                column: "Email",
                value: "EsmayChapman@ThAmCo.co.uk");

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Staff",
                keyColumn: "Id",
                keyValue: 6,
                column: "Email",
                value: "MaxFerguson@ThAmCo.co.uk");

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Staff",
                keyColumn: "Id",
                keyValue: 7,
                column: "Email",
                value: "IslaBanks@ThAmCo.co.uk");

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Staff",
                keyColumn: "Id",
                keyValue: 8,
                column: "Email",
                value: "FelixWatson@ThAmCo.co.uk");

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Guests",
                columns: new[] { "CustomerId", "EventId", "Attended" },
                values: new object[,]
                {
                    { 4, 1, false },
                    { 19, 2, false },
                    { 19, 1, false },
                    { 18, 2, false },
                    { 18, 1, false },
                    { 17, 2, false },
                    { 17, 1, false },
                    { 16, 2, false },
                    { 16, 1, false },
                    { 15, 2, false },
                    { 15, 1, false },
                    { 14, 2, false },
                    { 14, 1, false },
                    { 13, 2, false },
                    { 13, 1, false },
                    { 12, 2, false },
                    { 12, 1, false },
                    { 11, 2, false },
                    { 4, 2, false },
                    { 5, 1, false },
                    { 5, 2, false },
                    { 6, 1, false },
                    { 6, 2, false },
                    { 7, 1, false },
                    { 20, 1, false },
                    { 7, 2, false },
                    { 8, 2, false },
                    { 9, 1, false },
                    { 9, 2, false },
                    { 10, 1, false },
                    { 10, 2, false },
                    { 11, 1, false },
                    { 8, 1, false },
                    { 20, 2, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "Email",
                schema: "thamco.events",
                table: "Staff");

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "Surname" },
                values: new object[] { "bob@example.com", "Robert", "Robertson" });

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "Surname" },
                values: new object[] { "betty@example.com", "Betty", "Thornton" });

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "Surname" },
                values: new object[] { "jin@example.com", "Jin", "Jellybeans" });

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Title", "TypeId" },
                values: new object[] { "Bob's Big 50", "PTY" });

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Title", "TypeId" },
                values: new object[] { "Best Wedding Yet", "WED" });

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Guests",
                keyColumns: new[] { "CustomerId", "EventId" },
                keyValues: new object[] { 1, 1 },
                column: "Attended",
                value: true);
        }
    }
}
