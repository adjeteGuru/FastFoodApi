using Microsoft.EntityFrameworkCore.Migrations;

namespace FastFoodWebApi.Migrations
{
    public partial class AddPropCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tel",
                table: "Customers",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tel",
                table: "Customers");
        }
    }
}
