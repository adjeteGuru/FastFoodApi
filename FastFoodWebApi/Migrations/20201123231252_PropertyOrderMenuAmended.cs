using Microsoft.EntityFrameworkCore.Migrations;

namespace FastFoodWebApi.Migrations
{
    public partial class PropertyOrderMenuAmended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderMenus",
                table: "OrderMenus");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "OrderMenus",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderMenus",
                table: "OrderMenus",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderMenus_OrderId",
                table: "OrderMenus",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderMenus",
                table: "OrderMenus");

            migrationBuilder.DropIndex(
                name: "IX_OrderMenus_OrderId",
                table: "OrderMenus");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OrderMenus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderMenus",
                table: "OrderMenus",
                columns: new[] { "OrderId", "MenuId" });
        }
    }
}
