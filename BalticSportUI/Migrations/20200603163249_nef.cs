using Microsoft.EntityFrameworkCore.Migrations;

namespace BalticSportAPI.Migrations
{
    public partial class nef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_PhoneNumbers_PhoneID",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_PhoneID",
                table: "Suppliers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_PhoneID",
                table: "Suppliers",
                column: "PhoneID");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_PhoneNumbers_PhoneID",
                table: "Suppliers",
                column: "PhoneID",
                principalTable: "PhoneNumbers",
                principalColumn: "PhoneID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
