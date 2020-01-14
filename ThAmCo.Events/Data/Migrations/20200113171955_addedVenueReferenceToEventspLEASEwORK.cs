using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Events.Data.Migrations
{
    public partial class addedVenueReferenceToEventspLEASEwORK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                schema: "thamco.events",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "thamco.events",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "WhenMade",
                schema: "thamco.events",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                schema: "thamco.events",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "thamco.events",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "WhenMade",
                schema: "thamco.events",
                table: "Events");
        }
    }
}
