using Microsoft.EntityFrameworkCore.Migrations;

namespace ComiWeb.Migrations
{
    public partial class columnsale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "FlashSaleProducts");

            migrationBuilder.DropColumn(
                name: "Sale",
                table: "FlashSaleProducts");

            migrationBuilder.AddColumn<int>(
                name: "Sale",
                table: "FlashSales",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sale",
                table: "FlashSales");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FlashSaleProducts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sale",
                table: "FlashSaleProducts",
                nullable: false,
                defaultValue: 0);
        }
    }
}
