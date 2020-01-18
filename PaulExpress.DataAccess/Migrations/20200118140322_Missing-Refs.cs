using Microsoft.EntityFrameworkCore.Migrations;

namespace PaulExpress.DataAccess.Migrations
{
    public partial class MissingRefs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "OrderStatus");

            migrationBuilder.DropColumn(
                name: "OrderLineSupplementId",
                table: "OrderLines");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PaymentMethods",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "OrderStatus",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Supplements_ShopId",
                table: "Supplements",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Sauces_ShopId",
                table: "Sauces",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sauces_Shop_ShopId",
                table: "Sauces",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "ShopId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Supplements_Shop_ShopId",
                table: "Supplements",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "ShopId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sauces_Shop_ShopId",
                table: "Sauces");

            migrationBuilder.DropForeignKey(
                name: "FK_Supplements_Shop_ShopId",
                table: "Supplements");

            migrationBuilder.DropIndex(
                name: "IX_Supplements_ShopId",
                table: "Supplements");

            migrationBuilder.DropIndex(
                name: "IX_Sauces_ShopId",
                table: "Sauces");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "OrderStatus");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "PaymentMethods",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "OrderStatus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderLineSupplementId",
                table: "OrderLines",
                type: "int",
                nullable: true);
        }
    }
}
