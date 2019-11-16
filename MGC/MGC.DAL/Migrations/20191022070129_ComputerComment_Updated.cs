using Microsoft.EntityFrameworkCore.Migrations;

namespace MGC.DAL.Migrations
{
    public partial class ComputerComment_Updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ComputerComment_UserId",
                table: "ComputerComment",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerComment_ApplicationUser_UserId",
                table: "ComputerComment",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComputerComment_ApplicationUser_UserId",
                table: "ComputerComment");

            migrationBuilder.DropIndex(
                name: "IX_ComputerComment_UserId",
                table: "ComputerComment");
        }
    }
}
