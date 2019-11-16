using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MGC.DAL.Migrations
{
    public partial class CreatedMGCDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    EmailConfirmed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComputerBrand",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerBrand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComputerCPU",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerCPU", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComputerCPUType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerCPUType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComputerHDDCapacity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerHDDCapacity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComputerRamSpeed",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerRamSpeed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComputerScreenCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerScreenCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComputerScreenCardRam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerScreenCardRam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComputerScreenCardType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerScreenCardType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComputerScreenSize",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerScreenSize", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComputerSSDCapacity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerSSDCapacity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CategoryCode = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsVisible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneBatteryCapacity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneBatteryCapacity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneBrand",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneBrand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneCpuCapacity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneCpuCapacity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneInternalMemory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneInternalMemory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneOS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneOSType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneOSType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneRamCapacity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneRamCapacity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneScreenDimension",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneScreenDimension", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneWifi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneWifi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SellerComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellerComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellerComment_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRole_ApplicationRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ApplicationRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Province_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MiddleCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CategoryCode = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    MiddleCategoryId = table.Column<Guid>(nullable: true),
                    MainCategoryId = table.Column<Guid>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsVisible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiddleCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MiddleCategory_MainCategory_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "MainCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MiddleCategory_MiddleCategory_MiddleCategoryId",
                        column: x => x.MiddleCategoryId,
                        principalTable: "MiddleCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhoneProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Weight = table.Column<string>(nullable: true),
                    ConnectionSpeed = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    MainCamera = table.Column<string>(nullable: true),
                    FrontCamera = table.Column<string>(nullable: true),
                    ChargingInput = table.Column<string>(nullable: true),
                    BatteryType = table.Column<int>(nullable: false),
                    CellularSpeed = table.Column<string>(nullable: true),
                    TotalTalkTime = table.Column<string>(nullable: true),
                    WarrantyTime = table.Column<int>(nullable: false),
                    ScreenType = table.Column<string>(nullable: true),
                    PhoneBatteryCapacityId = table.Column<int>(nullable: false),
                    PhoneInternalMemoryId = table.Column<int>(nullable: false),
                    PhoneScreenDimensionId = table.Column<int>(nullable: false),
                    PhoneWifiId = table.Column<int>(nullable: false),
                    PhoneCpuCapacityId = table.Column<int>(nullable: false),
                    PhoneOSId = table.Column<int>(nullable: false),
                    PhoneOSTypeId = table.Column<int>(nullable: false),
                    PhoneRamCapasityId = table.Column<int>(nullable: false),
                    DualSIM = table.Column<bool>(nullable: false),
                    TouchScreen = table.Column<bool>(nullable: false),
                    ExpandableMemory = table.Column<bool>(nullable: false),
                    IntegratedCamera = table.Column<bool>(nullable: false),
                    IntegratedFlash = table.Column<bool>(nullable: false),
                    EyeScan = table.Column<bool>(nullable: false),
                    GPS = table.Column<bool>(nullable: false),
                    WirelessCharging = table.Column<bool>(nullable: false),
                    NFC = table.Column<bool>(nullable: false),
                    FaceRecognition = table.Column<bool>(nullable: false),
                    AbroadSales = table.Column<bool>(nullable: false),
                    Fingerprint = table.Column<bool>(nullable: false),
                    CpuCapacityId = table.Column<int>(nullable: true),
                    WifiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneProperty_PhoneCpuCapacity_CpuCapacityId",
                        column: x => x.CpuCapacityId,
                        principalTable: "PhoneCpuCapacity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhoneProperty_PhoneBatteryCapacity_PhoneBatteryCapacityId",
                        column: x => x.PhoneBatteryCapacityId,
                        principalTable: "PhoneBatteryCapacity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneProperty_PhoneInternalMemory_PhoneInternalMemoryId",
                        column: x => x.PhoneInternalMemoryId,
                        principalTable: "PhoneInternalMemory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneProperty_PhoneOS_PhoneOSId",
                        column: x => x.PhoneOSId,
                        principalTable: "PhoneOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneProperty_PhoneOSType_PhoneOSTypeId",
                        column: x => x.PhoneOSTypeId,
                        principalTable: "PhoneOSType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneProperty_PhoneRamCapacity_PhoneRamCapasityId",
                        column: x => x.PhoneRamCapasityId,
                        principalTable: "PhoneRamCapacity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneProperty_PhoneScreenDimension_PhoneScreenDimensionId",
                        column: x => x.PhoneScreenDimensionId,
                        principalTable: "PhoneScreenDimension",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneProperty_PhoneWifi_WifiId",
                        column: x => x.WifiId,
                        principalTable: "PhoneWifi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ProvinceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                    table.ForeignKey(
                        name: "FK_District_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CategoryCode = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    MiddleCategoryId = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsVisible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_MiddleCategory_MiddleCategoryId",
                        column: x => x.MiddleCategoryId,
                        principalTable: "MiddleCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seller",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SellerCode = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    DistrictId = table.Column<int>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: false),
                    AvarageRating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seller_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seller_ApplicationUser_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Computer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    ProductCode = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    PurchacePrice = table.Column<int>(nullable: false),
                    DiscountRate = table.Column<int>(nullable: false),
                    CampaignCode = table.Column<string>(nullable: true),
                    InCampaign = table.Column<bool>(nullable: false),
                    ComputerBrandId = table.Column<int>(nullable: false),
                    SellerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Computer_ComputerBrand_ComputerBrandId",
                        column: x => x.ComputerBrandId,
                        principalTable: "ComputerBrand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computer_Seller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Seller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataStorage",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    SellerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataStorage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataStorage_Seller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Seller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    ProductCode = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    PurchacePrice = table.Column<int>(nullable: false),
                    DiscountRate = table.Column<int>(nullable: false),
                    CampaignCode = table.Column<string>(nullable: true),
                    InCampaign = table.Column<bool>(nullable: false),
                    PhoneBrandId = table.Column<int>(nullable: false),
                    SellerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phone_PhoneBrand_PhoneBrandId",
                        column: x => x.PhoneBrandId,
                        principalTable: "PhoneBrand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phone_Seller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Seller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComputerComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ComputerId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComputerComment_Computer_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComputerImage",
                columns: table => new
                {
                    ComputerId = table.Column<Guid>(nullable: false),
                    QueueNumber = table.Column<int>(nullable: false),
                    Image = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerImage", x => new { x.ComputerId, x.QueueNumber });
                    table.ForeignKey(
                        name: "FK_ComputerImage_Computer_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComputerProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ComputerId = table.Column<Guid>(nullable: false),
                    MemorySlot = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    ComputerCache = table.Column<int>(nullable: false),
                    ComputerRamSpeedId = table.Column<int>(nullable: false),
                    ComputerScreenSizeId = table.Column<int>(nullable: false),
                    ComputerScreenCardTypeId = table.Column<int>(nullable: false),
                    ComputerScreenCardRamId = table.Column<int>(nullable: false),
                    ComputerScreenCardId = table.Column<int>(nullable: false),
                    ComputerHDDCapacityId = table.Column<int>(nullable: false),
                    ComputerSSDCapacityId = table.Column<int>(nullable: false),
                    ComputerCPUTypeId = table.Column<int>(nullable: false),
                    ComputerCPUId = table.Column<int>(nullable: false),
                    HaveEthernet = table.Column<bool>(nullable: false),
                    HaveBluetooth = table.Column<bool>(nullable: false),
                    HaveTouchScreen = table.Column<bool>(nullable: false),
                    HaveHDMI = table.Column<bool>(nullable: false),
                    HaveCardReader = table.Column<bool>(nullable: false),
                    HaveUSB3 = table.Column<bool>(nullable: false),
                    HaveUSB31 = table.Column<bool>(nullable: false),
                    HaveWebCam = table.Column<bool>(nullable: false),
                    HaveOpticalDriver = table.Column<bool>(nullable: false),
                    HaveOS = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComputerProperty_ComputerCPU_ComputerCPUId",
                        column: x => x.ComputerCPUId,
                        principalTable: "ComputerCPU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerProperty_ComputerCPUType_ComputerCPUTypeId",
                        column: x => x.ComputerCPUTypeId,
                        principalTable: "ComputerCPUType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerProperty_ComputerHDDCapacity_ComputerHDDCapacityId",
                        column: x => x.ComputerHDDCapacityId,
                        principalTable: "ComputerHDDCapacity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerProperty_Computer_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerProperty_ComputerRamSpeed_ComputerRamSpeedId",
                        column: x => x.ComputerRamSpeedId,
                        principalTable: "ComputerRamSpeed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerProperty_ComputerSSDCapacity_ComputerSSDCapacityId",
                        column: x => x.ComputerSSDCapacityId,
                        principalTable: "ComputerSSDCapacity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerProperty_ComputerScreenCard_ComputerScreenCardId",
                        column: x => x.ComputerScreenCardId,
                        principalTable: "ComputerScreenCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerProperty_ComputerScreenCardRam_ComputerScreenCardRamId",
                        column: x => x.ComputerScreenCardRamId,
                        principalTable: "ComputerScreenCardRam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerProperty_ComputerScreenCardType_ComputerScreenCardTypeId",
                        column: x => x.ComputerScreenCardTypeId,
                        principalTable: "ComputerScreenCardType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerProperty_ComputerScreenSize_ComputerScreenSizeId",
                        column: x => x.ComputerScreenSizeId,
                        principalTable: "ComputerScreenSize",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneColor",
                columns: table => new
                {
                    PhoneId = table.Column<Guid>(nullable: false),
                    ColorCode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneColor", x => new { x.PhoneId, x.ColorCode });
                    table.ForeignKey(
                        name: "FK_PhoneColor_Phone_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PhoneId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneComment_Phone_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneImage",
                columns: table => new
                {
                    PhoneId = table.Column<Guid>(nullable: false),
                    QueueNumber = table.Column<int>(nullable: false),
                    Image = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneImage", x => new { x.PhoneId, x.QueueNumber });
                    table.ForeignKey(
                        name: "FK_PhoneImage_Phone_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_UserName",
                table: "ApplicationUser",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryCode",
                table: "Category",
                column: "CategoryCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_MiddleCategoryId",
                table: "Category",
                column: "MiddleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Computer_ComputerBrandId",
                table: "Computer",
                column: "ComputerBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Computer_SellerId",
                table: "Computer",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerBrand_Name",
                table: "ComputerBrand",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComputerComment_ComputerId",
                table: "ComputerComment",
                column: "ComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerProperty_ComputerCPUId",
                table: "ComputerProperty",
                column: "ComputerCPUId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerProperty_ComputerCPUTypeId",
                table: "ComputerProperty",
                column: "ComputerCPUTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerProperty_ComputerHDDCapacityId",
                table: "ComputerProperty",
                column: "ComputerHDDCapacityId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerProperty_ComputerId",
                table: "ComputerProperty",
                column: "ComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerProperty_ComputerRamSpeedId",
                table: "ComputerProperty",
                column: "ComputerRamSpeedId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerProperty_ComputerSSDCapacityId",
                table: "ComputerProperty",
                column: "ComputerSSDCapacityId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerProperty_ComputerScreenCardId",
                table: "ComputerProperty",
                column: "ComputerScreenCardId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerProperty_ComputerScreenCardRamId",
                table: "ComputerProperty",
                column: "ComputerScreenCardRamId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerProperty_ComputerScreenCardTypeId",
                table: "ComputerProperty",
                column: "ComputerScreenCardTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerProperty_ComputerScreenSizeId",
                table: "ComputerProperty",
                column: "ComputerScreenSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_DataStorage_SellerId",
                table: "DataStorage",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_District_ProvinceId",
                table: "District",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_MainCategory_CategoryCode",
                table: "MainCategory",
                column: "CategoryCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MiddleCategory_CategoryCode",
                table: "MiddleCategory",
                column: "CategoryCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MiddleCategory_MainCategoryId",
                table: "MiddleCategory",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MiddleCategory_MiddleCategoryId",
                table: "MiddleCategory",
                column: "MiddleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_PhoneBrandId",
                table: "Phone",
                column: "PhoneBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_SellerId",
                table: "Phone",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneComment_PhoneId",
                table: "PhoneComment",
                column: "PhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneProperty_CpuCapacityId",
                table: "PhoneProperty",
                column: "CpuCapacityId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneProperty_PhoneBatteryCapacityId",
                table: "PhoneProperty",
                column: "PhoneBatteryCapacityId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneProperty_PhoneInternalMemoryId",
                table: "PhoneProperty",
                column: "PhoneInternalMemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneProperty_PhoneOSId",
                table: "PhoneProperty",
                column: "PhoneOSId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneProperty_PhoneOSTypeId",
                table: "PhoneProperty",
                column: "PhoneOSTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneProperty_PhoneRamCapasityId",
                table: "PhoneProperty",
                column: "PhoneRamCapasityId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneProperty_PhoneScreenDimensionId",
                table: "PhoneProperty",
                column: "PhoneScreenDimensionId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneProperty_WifiId",
                table: "PhoneProperty",
                column: "WifiId");

            migrationBuilder.CreateIndex(
                name: "IX_Province_CountryId",
                table: "Province",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Seller_DistrictId",
                table: "Seller",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Seller_OwnerId",
                table: "Seller",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_SellerComment_UserId",
                table: "SellerComment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "ComputerComment");

            migrationBuilder.DropTable(
                name: "ComputerImage");

            migrationBuilder.DropTable(
                name: "ComputerProperty");

            migrationBuilder.DropTable(
                name: "DataStorage");

            migrationBuilder.DropTable(
                name: "PhoneColor");

            migrationBuilder.DropTable(
                name: "PhoneComment");

            migrationBuilder.DropTable(
                name: "PhoneImage");

            migrationBuilder.DropTable(
                name: "PhoneProperty");

            migrationBuilder.DropTable(
                name: "SellerComment");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "MiddleCategory");

            migrationBuilder.DropTable(
                name: "ComputerCPU");

            migrationBuilder.DropTable(
                name: "ComputerCPUType");

            migrationBuilder.DropTable(
                name: "ComputerHDDCapacity");

            migrationBuilder.DropTable(
                name: "Computer");

            migrationBuilder.DropTable(
                name: "ComputerRamSpeed");

            migrationBuilder.DropTable(
                name: "ComputerSSDCapacity");

            migrationBuilder.DropTable(
                name: "ComputerScreenCard");

            migrationBuilder.DropTable(
                name: "ComputerScreenCardRam");

            migrationBuilder.DropTable(
                name: "ComputerScreenCardType");

            migrationBuilder.DropTable(
                name: "ComputerScreenSize");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "PhoneCpuCapacity");

            migrationBuilder.DropTable(
                name: "PhoneBatteryCapacity");

            migrationBuilder.DropTable(
                name: "PhoneInternalMemory");

            migrationBuilder.DropTable(
                name: "PhoneOS");

            migrationBuilder.DropTable(
                name: "PhoneOSType");

            migrationBuilder.DropTable(
                name: "PhoneRamCapacity");

            migrationBuilder.DropTable(
                name: "PhoneScreenDimension");

            migrationBuilder.DropTable(
                name: "PhoneWifi");

            migrationBuilder.DropTable(
                name: "ApplicationRole");

            migrationBuilder.DropTable(
                name: "MainCategory");

            migrationBuilder.DropTable(
                name: "ComputerBrand");

            migrationBuilder.DropTable(
                name: "PhoneBrand");

            migrationBuilder.DropTable(
                name: "Seller");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
