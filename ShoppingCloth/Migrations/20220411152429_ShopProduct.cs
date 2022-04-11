using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCloth.Migrations
{
    public partial class ShopProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopProductItems_Products_ItemProductId1",
                table: "ShopProductItems");

            migrationBuilder.DropIndex(
                name: "IX_ShopProductItems_ItemProductId1",
                table: "ShopProductItems");

            migrationBuilder.DropColumn(
                name: "ItemProductId1",
                table: "ShopProductItems");

            migrationBuilder.AlterColumn<int>(
                name: "ItemProductId",
                table: "ShopProductItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemShopProductId",
                table: "ShopProductItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShopProductItems_ItemProductId",
                table: "ShopProductItems",
                column: "ItemProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProductItems_Products_ItemProductId",
                table: "ShopProductItems",
                column: "ItemProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopProductItems_Products_ItemProductId",
                table: "ShopProductItems");

            migrationBuilder.DropIndex(
                name: "IX_ShopProductItems_ItemProductId",
                table: "ShopProductItems");

            migrationBuilder.DropColumn(
                name: "ItemShopProductId",
                table: "ShopProductItems");

            migrationBuilder.AlterColumn<string>(
                name: "ItemProductId",
                table: "ShopProductItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemProductId1",
                table: "ShopProductItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShopProductItems_ItemProductId1",
                table: "ShopProductItems",
                column: "ItemProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProductItems_Products_ItemProductId1",
                table: "ShopProductItems",
                column: "ItemProductId1",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
