using Microsoft.EntityFrameworkCore.Migrations;

namespace MGC.DAL.Migrations
{
    public partial class Seller_Table_Updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SellerCode",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Seller_SellerCode",
                table: "Seller",
                column: "SellerCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Seller_SellerCode",
                table: "Seller");

            migrationBuilder.AlterColumn<string>(
                name: "SellerCode",
                table: "Seller",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
