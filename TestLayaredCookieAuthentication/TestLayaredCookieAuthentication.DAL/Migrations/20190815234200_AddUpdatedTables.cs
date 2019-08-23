using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestLayaredCookieAuthentication.DAL.Migrations
{
    public partial class AddUpdatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    EmailConfirmed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DistrictName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictId);
                });

            migrationBuilder.CreateTable(
                name: "MainCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TradeCompanies",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    FullAddress = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    TradeRegistrationNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_ApplicationRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ApplicationRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_ApplicationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProvinceName = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    DistrictId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceId);
                    table.ForeignKey(
                        name: "FK_Provinces_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Provinces_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaxDepartments",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    DepartmentName = table.Column<string>(nullable: true),
                    DistrictId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxDepartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxDepartments_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MiddleCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MainCategoryId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiddleCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MiddleCategories_MainCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "MainCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TCompanyPartners",
                columns: table => new
                {
                    TradeCompanyId = table.Column<string>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: false),
                    Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCompanyPartners", x => new { x.TradeCompanyId, x.ApplicationUserId });
                    table.ForeignKey(
                        name: "FK_TCompanyPartners_ApplicationUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TCompanyPartners_TradeCompanies_TradeCompanyId",
                        column: x => x.TradeCompanyId,
                        principalTable: "TradeCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    TradeCompanyId = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    WarehouseName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StatusId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warehouses_TradeCompanies_TradeCompanyId",
                        column: x => x.TradeCompanyId,
                        principalTable: "TradeCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CompanyTitle = table.Column<string>(nullable: false),
                    CompanyTitleNext = table.Column<string>(nullable: true),
                    TaxDepartmentId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    WorkPhoneNumber = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    CurrencyType = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: true),
                    DistrictId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MiddleCategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_MiddleCategories_MiddleCategoryId",
                        column: x => x.MiddleCategoryId,
                        principalTable: "MiddleCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDeliveryAddresses",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    AddressTitle = table.Column<string>(nullable: true),
                    ShipCountry = table.Column<string>(nullable: true),
                    ShipProvince = table.Column<string>(nullable: true),
                    ShipDistrict = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDeliveryAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerDeliveryAddresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerInvoiceAddresses",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    AddressTitle = table.Column<string>(nullable: true),
                    ShipCountry = table.Column<string>(nullable: true),
                    ShipProvince = table.Column<string>(nullable: true),
                    ShipDistrict = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    isInstitutional = table.Column<bool>(nullable: false),
                    TaxNo = table.Column<string>(nullable: true),
                    TaxDepartmentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInvoiceAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerInvoiceAddresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerInvoiceAddresses_TaxDepartments_TaxDepartmentId",
                        column: x => x.TaxDepartmentId,
                        principalTable: "TaxDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    TradeCompanyId = table.Column<string>(nullable: true),
                    OrderCode = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    ShippedDate = table.Column<DateTime>(nullable: false),
                    RequiredDate = table.Column<DateTime>(nullable: false),
                    ShipName = table.Column<string>(nullable: true),
                    ShipAddress = table.Column<string>(nullable: true),
                    ShipCountry = table.Column<string>(nullable: true),
                    ShipProvince = table.Column<string>(nullable: true),
                    ShipDistrict = table.Column<string>(nullable: true),
                    ShipPostalCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_TradeCompanies_TradeCompanyId",
                        column: x => x.TradeCompanyId,
                        principalTable: "TradeCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    TradeCompanyId = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ImageBase64 = table.Column<string>(nullable: true),
                    StCode = table.Column<string>(nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    WholesalePrice = table.Column<double>(nullable: false),
                    UnitPrice = table.Column<double>(nullable: false),
                    ProductCount = table.Column<int>(nullable: false),
                    KDVRate = table.Column<int>(nullable: false),
                    Explain = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ApplicationUsers_CreateUserId",
                        column: x => x.CreateUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_TradeCompanies_TradeCompanyId",
                        column: x => x.TradeCompanyId,
                        principalTable: "TradeCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ApplicationUsers_UpdateUserId",
                        column: x => x.UpdateUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    TradeCompanyId = table.Column<string>(nullable: true),
                    InvoiceCode = table.Column<string>(nullable: true),
                    InvoiceNo = table.Column<string>(nullable: true),
                    VoucherNo = table.Column<string>(nullable: true),
                    SerialNo = table.Column<string>(nullable: true),
                    CustomerTaxDepartmentNo = table.Column<string>(nullable: true),
                    CustomerId = table.Column<string>(nullable: true),
                    OrderId = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DateTimeofShipment = table.Column<DateTime>(nullable: false),
                    DateTimeofWaybill = table.Column<DateTime>(nullable: false),
                    NetAmount = table.Column<string>(nullable: true),
                    GrandTotal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_TradeCompanies_TradeCompanyId",
                        column: x => x.TradeCompanyId,
                        principalTable: "TradeCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Waybills",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    TradeCompanyId = table.Column<string>(nullable: true),
                    InvoiceCode = table.Column<string>(nullable: true),
                    WaybillCode = table.Column<string>(nullable: true),
                    WaybillNo = table.Column<string>(nullable: true),
                    VoucherNo = table.Column<string>(nullable: true),
                    SerialNo = table.Column<string>(nullable: true),
                    CustomerTaxDepartmentNo = table.Column<string>(nullable: true),
                    CustomerId = table.Column<string>(nullable: true),
                    OrderId = table.Column<string>(nullable: true),
                    WaybillDate = table.Column<DateTime>(nullable: false),
                    DateofShipment = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waybills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Waybills_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Waybills_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Waybills_TradeCompanies_TradeCompanyId",
                        column: x => x.TradeCompanyId,
                        principalTable: "TradeCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<string>(nullable: false),
                    ProductId = table.Column<string>(nullable: false),
                    UnitPrice = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Discount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockInputs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    StcokInputCode = table.Column<string>(nullable: false),
                    StatusId = table.Column<string>(nullable: true),
                    WarehouseId = table.Column<string>(nullable: true),
                    ProductId = table.Column<string>(nullable: true),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    TradeCompanyId = table.Column<string>(nullable: true),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    ProductCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockInputs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockInputs_ApplicationUsers_CreateUserId",
                        column: x => x.CreateUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockInputs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockInputs_TradeCompanies_TradeCompanyId",
                        column: x => x.TradeCompanyId,
                        principalTable: "TradeCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockInputs_ApplicationUsers_UpdateUserId",
                        column: x => x.UpdateUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockInputs_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockOuts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    StockOutCode = table.Column<string>(nullable: false),
                    StatusId = table.Column<string>(nullable: true),
                    WarehouseId = table.Column<string>(nullable: true),
                    ProductId = table.Column<string>(nullable: true),
                    OutDate = table.Column<DateTime>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    TradeCompanyId = table.Column<string>(nullable: true),
                    OutUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    ProductCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockOuts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockOuts_ApplicationUsers_OutUserId",
                        column: x => x.OutUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockOuts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockOuts_TradeCompanies_TradeCompanyId",
                        column: x => x.TradeCompanyId,
                        principalTable: "TradeCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockOuts_ApplicationUsers_UpdateUserId",
                        column: x => x.UpdateUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockOuts_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_UserName",
                table: "ApplicationUsers",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_MiddleCategoryId",
                table: "Categories",
                column: "MiddleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDeliveryAddresses_CustomerId",
                table: "CustomerDeliveryAddresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInvoiceAddresses_CustomerId",
                table: "CustomerInvoiceAddresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInvoiceAddresses_TaxDepartmentId",
                table: "CustomerInvoiceAddresses",
                column: "TaxDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DistrictId",
                table: "Customers",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ProvinceId",
                table: "Customers",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerId",
                table: "Invoices",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_OrderId",
                table: "Invoices",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_TradeCompanyId",
                table: "Invoices",
                column: "TradeCompanyId")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_MiddleCategories_MainCategoryId",
                table: "MiddleCategories",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TradeCompanyId",
                table: "Orders",
                column: "TradeCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CreateUserId",
                table: "Products",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StCode",
                table: "Products",
                column: "StCode",
                unique: true,
                filter: "[StCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TradeCompanyId",
                table: "Products",
                column: "TradeCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UpdateUserId",
                table: "Products",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_CountryId",
                table: "Provinces",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_DistrictId",
                table: "Provinces",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_StockInputs_CreateUserId",
                table: "StockInputs",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_StockInputs_ProductId",
                table: "StockInputs",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockInputs_TradeCompanyId",
                table: "StockInputs",
                column: "TradeCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StockInputs_UpdateUserId",
                table: "StockInputs",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_StockInputs_WarehouseId",
                table: "StockInputs",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_StockOuts_OutUserId",
                table: "StockOuts",
                column: "OutUserId");

            migrationBuilder.CreateIndex(
                name: "IX_StockOuts_ProductId",
                table: "StockOuts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockOuts_TradeCompanyId",
                table: "StockOuts",
                column: "TradeCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StockOuts_UpdateUserId",
                table: "StockOuts",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_StockOuts_WarehouseId",
                table: "StockOuts",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxDepartments_DistrictId",
                table: "TaxDepartments",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_TCompanyPartners_ApplicationUserId",
                table: "TCompanyPartners",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_TradeCompanyId",
                table: "Warehouses",
                column: "TradeCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Waybills_CustomerId",
                table: "Waybills",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Waybills_OrderId",
                table: "Waybills",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Waybills_TradeCompanyId",
                table: "Waybills",
                column: "TradeCompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerDeliveryAddresses");

            migrationBuilder.DropTable(
                name: "CustomerInvoiceAddresses");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "StockInputs");

            migrationBuilder.DropTable(
                name: "StockOuts");

            migrationBuilder.DropTable(
                name: "TCompanyPartners");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Waybills");

            migrationBuilder.DropTable(
                name: "TaxDepartments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "ApplicationRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "TradeCompanies");

            migrationBuilder.DropTable(
                name: "MiddleCategories");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "MainCategories");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Districts");
        }
    }
}
