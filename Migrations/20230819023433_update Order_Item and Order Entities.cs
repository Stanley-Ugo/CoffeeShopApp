using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeShopApp.Migrations
{
    public partial class updateOrder_ItemandOrderEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Items_ColdDrinks_ColdDrinkId",
                table: "Order_Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Items_Foods_FoodId",
                table: "Order_Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Items_HotDrinks_HotDrinkId",
                table: "Order_Items");

            migrationBuilder.AddColumn<int>(
                name: "OderId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "HotDrinkId",
                table: "Order_Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FoodId",
                table: "Order_Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ColdDrinkId",
                table: "Order_Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Items_ColdDrinks_ColdDrinkId",
                table: "Order_Items",
                column: "ColdDrinkId",
                principalTable: "ColdDrinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Items_Foods_FoodId",
                table: "Order_Items",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Items_HotDrinks_HotDrinkId",
                table: "Order_Items",
                column: "HotDrinkId",
                principalTable: "HotDrinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Items_ColdDrinks_ColdDrinkId",
                table: "Order_Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Items_Foods_FoodId",
                table: "Order_Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Items_HotDrinks_HotDrinkId",
                table: "Order_Items");

            migrationBuilder.DropColumn(
                name: "OderId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "HotDrinkId",
                table: "Order_Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FoodId",
                table: "Order_Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ColdDrinkId",
                table: "Order_Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Items_ColdDrinks_ColdDrinkId",
                table: "Order_Items",
                column: "ColdDrinkId",
                principalTable: "ColdDrinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Items_Foods_FoodId",
                table: "Order_Items",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Items_HotDrinks_HotDrinkId",
                table: "Order_Items",
                column: "HotDrinkId",
                principalTable: "HotDrinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
