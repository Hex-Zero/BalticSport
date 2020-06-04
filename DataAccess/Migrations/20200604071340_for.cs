using Microsoft.EntityFrameworkCore.Migrations;

namespace BalticSportAPI.Migrations
{
    public partial class @for : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_PhoneNumbers_PhoneID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_PhoneID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneID",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "PhoneID",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber1",
                table: "PhoneNumbers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber2",
                table: "PhoneNumbers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberOne",
                table: "PhoneNumbers");

            migrationBuilder.DropColumn(
                name: "PhoneID",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "SupplierName",
                table: "Suppliers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SellerName",
                table: "Sellers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierID",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ProductDescription",
                table: "Products",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "PhoneNumbers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "PhoneNumbers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SellerID",
                table: "PhoneNumbers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierID",
                table: "PhoneNumbers",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SellerID",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "OrderLines",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderID",
                table: "OrderLines",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Customers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerAddress",
                table: "Customers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierID",
                table: "Products",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_CustomerID",
                table: "PhoneNumbers",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_SellerID",
                table: "PhoneNumbers",
                column: "SellerID");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_SupplierID",
                table: "PhoneNumbers",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SellerID",
                table: "Orders",
                column: "SellerID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderID",
                table: "OrderLines",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_ProductID",
                table: "OrderLines",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Orders_OrderID",
                table: "OrderLines",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Products_ProductID",
                table: "OrderLines",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Sellers_SellerID",
                table: "Orders",
                column: "SellerID",
                principalTable: "Sellers",
                principalColumn: "SellerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Customers_CustomerID",
                table: "PhoneNumbers",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Sellers_SellerID",
                table: "PhoneNumbers",
                column: "SellerID",
                principalTable: "Sellers",
                principalColumn: "SellerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Suppliers_SupplierID",
                table: "PhoneNumbers",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierID",
                table: "Products",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Orders_OrderID",
                table: "OrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Products_ProductID",
                table: "OrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Sellers_SellerID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Customers_CustomerID",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Sellers_SellerID",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Suppliers_SupplierID",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SupplierID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumbers_CustomerID",
                table: "PhoneNumbers");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumbers_SellerID",
                table: "PhoneNumbers");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumbers_SupplierID",
                table: "PhoneNumbers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_SellerID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderLines_OrderID",
                table: "OrderLines");

            migrationBuilder.DropIndex(
                name: "IX_OrderLines_ProductID",
                table: "OrderLines");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "PhoneNumbers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "PhoneNumbers");

            migrationBuilder.DropColumn(
                name: "SellerID",
                table: "PhoneNumbers");

            migrationBuilder.DropColumn(
                name: "SupplierID",
                table: "PhoneNumbers");

            migrationBuilder.AlterColumn<string>(
                name: "SupplierName",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "PhoneID",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "SellerName",
                table: "Sellers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "PhoneID",
                table: "Sellers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierID",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber1",
                table: "PhoneNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber2",
                table: "PhoneNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumberOne",
                table: "PhoneNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SellerID",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "OrderLines",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderID",
                table: "OrderLines",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "PhoneID",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PhoneID",
                table: "Customers",
                column: "PhoneID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_PhoneNumbers_PhoneID",
                table: "Customers",
                column: "PhoneID",
                principalTable: "PhoneNumbers",
                principalColumn: "PhoneID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
