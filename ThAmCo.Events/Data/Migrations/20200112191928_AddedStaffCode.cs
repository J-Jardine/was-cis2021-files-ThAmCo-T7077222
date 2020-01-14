using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Events.Data.Migrations
{
    public partial class AddedStaffCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StaffCode",
                schema: "thamco.events",
                table: "Staff",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Venue",
                schema: "thamco.events",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "VenueCost",
                schema: "thamco.events",
                table: "Events",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                column: "StaffCode",
                value: "FBFB");

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                column: "StaffCode",
                value: "JJJJ");

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3,
                column: "StaffCode",
                value: "ALAL");

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Staff",
                keyColumn: "Id",
                keyValue: 4,
                column: "StaffCode",
                value: "EAEA");

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Staff",
                keyColumn: "Id",
                keyValue: 5,
                column: "StaffCode",
                value: "ECEC");

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Staff",
                keyColumn: "Id",
                keyValue: 6,
                column: "StaffCode",
                value: "MFMF");

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Staff",
                keyColumn: "Id",
                keyValue: 7,
                column: "StaffCode",
                value: "IBIB");

            migrationBuilder.UpdateData(
                schema: "thamco.events",
                table: "Staff",
                keyColumn: "Id",
                keyValue: 8,
                column: "StaffCode",
                value: "FWFW");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StaffCode",
                schema: "thamco.events",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Venue",
                schema: "thamco.events",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "VenueCost",
                schema: "thamco.events",
                table: "Events");
        }
    }
}
