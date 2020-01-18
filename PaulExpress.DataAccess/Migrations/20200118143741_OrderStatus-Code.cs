using Microsoft.EntityFrameworkCore.Migrations;

namespace PaulExpress.DataAccess.Migrations
{
    public partial class OrderStatusCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Supplements_Shop_ShopId",
                table: "Supplements");

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "Supplements",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "OrderStatus",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Supplements_Shop_ShopId",
                table: "Supplements",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "ShopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Supplements_Shop_ShopId",
                table: "Supplements");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "OrderStatus");

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "Supplements",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Supplements_Shop_ShopId",
                table: "Supplements",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "ShopId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
