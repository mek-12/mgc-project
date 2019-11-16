using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MGC.DAL.Migrations
{
    public partial class AddTableRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComputerProperty_Computer_ComputerId",
                table: "ComputerProperty");

            migrationBuilder.AddColumn<Guid>(
                name: "PhoneId",
                table: "PhoneProperty",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "PhoneProperty",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "CampaignCode",
                table: "DataStorage",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiscountRate",
                table: "DataStorage",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "InCampaign",
                table: "DataStorage",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "DataStorage",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductCode",
                table: "DataStorage",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PurchacePrice",
                table: "DataStorage",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "ComputerId",
                table: "ComputerProperty",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "ComputerProperty",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ProductRecord",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TableCode = table.Column<string>(nullable: false),
                    TableType = table.Column<string>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductRecord_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TablelessFilterProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TableType = table.Column<string>(nullable: false),
                    PropertyName = table.Column<string>(nullable: false),
                    DisplayName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablelessFilterProperty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilterRecord",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TableCode = table.Column<string>(nullable: false),
                    DisplayName = table.Column<string>(nullable: false),
                    TableType = table.Column<string>(nullable: false),
                    PropertyName = table.Column<string>(nullable: false),
                    IncludedTableType = table.Column<string>(nullable: false),
                    ProductRecordId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilterRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilterRecord_ProductRecord_ProductRecordId",
                        column: x => x.ProductRecordId,
                        principalTable: "ProductRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneProperty_PhoneId",
                table: "PhoneProperty",
                column: "PhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_FilterRecord_ProductRecordId",
                table: "FilterRecord",
                column: "ProductRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRecord_CategoryId",
                table: "ProductRecord",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerProperty_Computer_ComputerId",
                table: "ComputerProperty",
                column: "ComputerId",
                principalTable: "Computer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneProperty_Phone_PhoneId",
                table: "PhoneProperty",
                column: "PhoneId",
                principalTable: "Phone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComputerProperty_Computer_ComputerId",
                table: "ComputerProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneProperty_Phone_PhoneId",
                table: "PhoneProperty");

            migrationBuilder.DropTable(
                name: "FilterRecord");

            migrationBuilder.DropTable(
                name: "TablelessFilterProperty");

            migrationBuilder.DropTable(
                name: "ProductRecord");

            migrationBuilder.DropIndex(
                name: "IX_PhoneProperty_PhoneId",
                table: "PhoneProperty");

            migrationBuilder.DropColumn(
                name: "PhoneId",
                table: "PhoneProperty");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "PhoneProperty");

            migrationBuilder.DropColumn(
                name: "CampaignCode",
                table: "DataStorage");

            migrationBuilder.DropColumn(
                name: "DiscountRate",
                table: "DataStorage");

            migrationBuilder.DropColumn(
                name: "InCampaign",
                table: "DataStorage");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "DataStorage");

            migrationBuilder.DropColumn(
                name: "ProductCode",
                table: "DataStorage");

            migrationBuilder.DropColumn(
                name: "PurchacePrice",
                table: "DataStorage");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ComputerProperty");

            migrationBuilder.AlterColumn<Guid>(
                name: "ComputerId",
                table: "ComputerProperty",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerProperty_Computer_ComputerId",
                table: "ComputerProperty",
                column: "ComputerId",
                principalTable: "Computer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
