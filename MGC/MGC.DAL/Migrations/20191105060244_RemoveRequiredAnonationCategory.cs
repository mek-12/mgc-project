using Microsoft.EntityFrameworkCore.Migrations;

namespace MGC.DAL.Migrations
{
    public partial class RemoveRequiredAnonationCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MiddleCategory_CategoryCode",
                table: "MiddleCategory");

            migrationBuilder.DropIndex(
                name: "IX_MainCategory_CategoryCode",
                table: "MainCategory");

            migrationBuilder.DropIndex(
                name: "IX_Category_CategoryCode",
                table: "Category");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryCode",
                table: "MiddleCategory",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryCode",
                table: "MainCategory",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryCode",
                table: "Category",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_MiddleCategory_CategoryCode",
                table: "MiddleCategory",
                column: "CategoryCode",
                unique: true,
                filter: "[CategoryCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MainCategory_CategoryCode",
                table: "MainCategory",
                column: "CategoryCode",
                unique: true,
                filter: "[CategoryCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryCode",
                table: "Category",
                column: "CategoryCode",
                unique: true,
                filter: "[CategoryCode] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MiddleCategory_CategoryCode",
                table: "MiddleCategory");

            migrationBuilder.DropIndex(
                name: "IX_MainCategory_CategoryCode",
                table: "MainCategory");

            migrationBuilder.DropIndex(
                name: "IX_Category_CategoryCode",
                table: "Category");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryCode",
                table: "MiddleCategory",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryCode",
                table: "MainCategory",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryCode",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MiddleCategory_CategoryCode",
                table: "MiddleCategory",
                column: "CategoryCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MainCategory_CategoryCode",
                table: "MainCategory",
                column: "CategoryCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryCode",
                table: "Category",
                column: "CategoryCode",
                unique: true);
        }
    }
}
