using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Catering.Migrations
{
    public partial class addingMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "thamco.catering");

            migrationBuilder.CreateTable(
                name: "Menu",
                schema: "thamco.catering",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Starter = table.Column<string>(nullable: true),
                    Main = table.Column<string>(nullable: true),
                    Desert = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodBooking",
                schema: "thamco.catering",
                columns: table => new
                {
                    MenuId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodBooking", x => new { x.MenuId, x.EventId });
                    table.ForeignKey(
                        name: "FK_FoodBooking_Menu_MenuId",
                        column: x => x.MenuId,
                        principalSchema: "thamco.catering",
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "thamco.catering",
                table: "Menu",
                columns: new[] { "Id", "Cost", "Desert", "Main", "Starter" },
                values: new object[,]
                {
                    { 1, 10.0m, "Chocolate Pudding", "Spaghetti Carbonara", "Tomato Soup" },
                    { 2, 20.3m, "Mixed Berry Mousse", "Chicken Parmasan", "Cheese Balls" },
                    { 3, 10.7m, "Mango & Coconut Souffle", "Double Cheese Burger", "Part Bake Bread & Butter" },
                    { 4, 7.5m, "Homemade Carrot Cake", "Chicken Shawarma Skewers", "Cheese Balls" },
                    { 5, 14.4m, "Matcha Cake", "Chicken Katsu", "Grilled Scallops" },
                    { 6, 15.3m, "Pancakes", "Pepperoni Pizza", "Duck Pancakes" },
                    { 7, 9.7m, "Lemon Meringue Pie", "Thai Green Curry", "Nachos" },
                    { 8, 11.2m, "Chocolate Pot x3", "Sword Fish", "Salt & Pepper Squid" },
                    { 9, 15.1m, "Cheese Board", "Salt & Pepper Chicken", "Hummus Board" },
                    { 10, 20.0m, "Tea & Coffee", "Fillet Steak", "Garlic Bread" }
                });

            migrationBuilder.InsertData(
                schema: "thamco.catering",
                table: "FoodBooking",
                columns: new[] { "MenuId", "EventId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 2 },
                    { 5, 6 },
                    { 7, 3 },
                    { 8, 4 },
                    { 10, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodBooking",
                schema: "thamco.catering");

            migrationBuilder.DropTable(
                name: "Menu",
                schema: "thamco.catering");
        }
    }
}
