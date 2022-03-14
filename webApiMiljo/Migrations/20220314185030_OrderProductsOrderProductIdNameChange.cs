using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webApiMiljo.Migrations
{
    public partial class OrderProductsOrderProductIdNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductOrders",
                newName: "ProductOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductOrderId",
                table: "ProductOrders",
                newName: "Id");
        }
    }
}
