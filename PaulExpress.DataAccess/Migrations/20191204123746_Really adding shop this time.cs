using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PaulExpress.DataAccess.Migrations
{
    public partial class Reallyaddingshopthistime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    ShopId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.ShopId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sandwiches_ShopId",
                table: "Sandwiches",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sandwiches_Shop_ShopId",
                table: "Sandwiches",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "ShopId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sandwiches_Shop_ShopId",
                table: "Sandwiches");

            migrationBuilder.DropTable(
                name: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_Sandwiches_ShopId",
                table: "Sandwiches");
        }
    }
}
