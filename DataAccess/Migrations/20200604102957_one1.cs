using Microsoft.EntityFrameworkCore.Migrations;

namespace BalticSportAPI.Migrations
{
    public partial class one1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Orders_OrderId",
                table: "OrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Products_ProductId",
                table: "OrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerIDId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Sellers_SellerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SupplierId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_SellerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderLines_OrderId",
                table: "OrderLines");

            migrationBuilder.DropIndex(
                name: "IX_OrderLines_ProductId",
                table: "OrderLines");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrderLines");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderLines");

            migrationBuilder.RenameColumn(
                name: "CustomerIDId",
                table: "Orders",
                newName: "CustomerIdId");

            migrationBuilder.AddColumn<int>(
                name: "SupplierIdId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SellerIdId",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderIdId",
                table: "OrderLines",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductIdId",
                table: "OrderLines",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierIdId",
                table: "Products",
                column: "SupplierIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SellerIdId",
                table: "Orders",
                column: "SellerIdId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderIdId",
                table: "OrderLines",
                column: "OrderIdId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_ProductIdId",
                table: "OrderLines",
                column: "ProductIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Orders_OrderIdId",
                table: "OrderLines",
                column: "OrderIdId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Products_ProductIdId",
                table: "OrderLines",
                column: "ProductIdId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerIdId",
                table: "Orders",
                column: "CustomerIdId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Sellers_SellerIdId",
                table: "Orders",
                column: "SellerIdId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierIdId",
                table: "Products",
                column: "SupplierIdId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Orders_OrderIdId",
                table: "OrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Products_ProductIdId",
                table: "OrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerIdId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Sellers_SellerIdId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierIdId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SupplierIdId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_SellerIdId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderLines_OrderIdId",
                table: "OrderLines");

            migrationBuilder.DropIndex(
                name: "IX_OrderLines_ProductIdId",
                table: "OrderLines");

            migrationBuilder.DropColumn(
                name: "SupplierIdId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SellerIdId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderIdId",
                table: "OrderLines");

            migrationBuilder.DropColumn(
                name: "ProductIdId",
                table: "OrderLines");

            migrationBuilder.RenameColumn(
                name: "CustomerIdId",
                table: "Orders",
                newName: "CustomerIDId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerIdId",
                table: "Orders",
                newName: "IX_Orders_CustomerIDId");

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "OrderLines",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "OrderLines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SellerId",
                table: "Orders",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderId",
                table: "OrderLines",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_ProductId",
                table: "OrderLines",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Orders_OrderId",
                table: "OrderLines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Products_ProductId",
                table: "OrderLines",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerIDId",
                table: "Orders",
                column: "CustomerIDId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Sellers_SellerId",
                table: "Orders",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                table: "Products",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
