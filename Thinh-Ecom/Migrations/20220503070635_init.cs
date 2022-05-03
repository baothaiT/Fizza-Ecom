using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thinh_Ecom.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    cg_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cg_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cg_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cg_Sale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.cg_Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUsers",
                columns: table => new
                {
                    cf_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cf_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cf_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cf_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cf_Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cf_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsers", x => x.cf_Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailGuest",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailGuest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceForSize",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SizeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceForSize", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    user_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    pd_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pd_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Price = table.Column<int>(type: "int", nullable: false),
                    pd_ReducePrice = table.Column<int>(type: "int", nullable: false),
                    pd_Img1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesFK = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.pd_Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoriesFK",
                        column: x => x.CategoriesFK,
                        principalTable: "Categories",
                        principalColumn: "cg_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    about_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    about_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_AppUserFK = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.about_id);
                    table.ForeignKey(
                        name: "FK_About_Users_about_AppUserFK",
                        column: x => x.about_AppUserFK,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    bill_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bill_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    bill_PaidTotal = table.Column<int>(type: "int", nullable: false),
                    bill_ProductIdlist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductNamelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductSizelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductPricelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Shipping = table.Column<int>(type: "int", nullable: false),
                    bill_Discount = table.Column<int>(type: "int", nullable: false),
                    bill_Confirmation = table.Column<bool>(type: "bit", nullable: false),
                    bill_DatetimeOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bill_PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_QuantityList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    bill_WaitForConfirmation = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.bill_Id);
                    table.ForeignKey(
                        name: "FK_Bills_Users_bill_UserId",
                        column: x => x.bill_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    cart_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cart_UserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.cart_Id);
                    table.ForeignKey(
                        name: "FK_Carts_Users_cart_UserID",
                        column: x => x.cart_UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactSystems",
                columns: table => new
                {
                    Contact_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_AppUserFK = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactSystems", x => x.Contact_Id);
                    table.ForeignKey(
                        name: "FK_ContactSystems_Users_Contact_AppUserFK",
                        column: x => x.Contact_AppUserFK,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    couponId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    couponCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    couponPrice = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    coupon_AppUserFK = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.couponId);
                    table.ForeignKey(
                        name: "FK_Coupons_Users_coupon_AppUserFK",
                        column: x => x.coupon_AppUserFK,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shipping",
                columns: table => new
                {
                    ship_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ship_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ship_Price = table.Column<int>(type: "int", nullable: false),
                    ship_AppUserFK = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping", x => x.ship_Id);
                    table.ForeignKey(
                        name: "FK_Shipping_Users_ship_AppUserFK",
                        column: x => x.ship_AppUserFK,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCart",
                columns: table => new
                {
                    pic_ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pic_CartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pic_amount = table.Column<int>(type: "int", nullable: false),
                    pic_size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pic_color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCart", x => new { x.pic_CartId, x.pic_ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCart_Carts_pic_CartId",
                        column: x => x.pic_CartId,
                        principalTable: "Carts",
                        principalColumn: "cart_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCart_Products_pic_ProductId",
                        column: x => x.pic_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "about_id", "about_AppUserFK", "about_Description", "about_Title", "about_Url" },
                values: new object[] { 1, null, "The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. \n \n When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove,the headline of Alphabet Village and the subline of her own road,the Line Lane.Pityful a rethoric question ran over her cheek,then she continued her way.", "Footwear the leading eCommerce Store around the Globe", "https://www.youtube.com/watch?v=F1vcruph8JA" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "IsDelete", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { "436314dc-6db0-4346-a250-d006c60afa6f", false, "Pizza", "", "" },
                    { "90be5462-391a-440d-a2fb-1fcbf21241d5", false, "Spaghetti", "", "" },
                    { "a1fc0dac-d13b-4190-a5cb-0105aecb79e6", false, "Sidedishes", "", "" },
                    { "c15b582d-12d4-4af3-9721-1123cc0c8af9", false, "Drink", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactSystems",
                columns: new[] { "Contact_Id", "Contact_Address", "Contact_AppUserFK", "Contact_Email", "Contact_Phone", "Contact_Website" },
                values: new object[] { 1, " 123, An Lac A Ward, Binh Tan District, HCM", null, "admin@gmail.com", "0123456789", "https://shoes.com" });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cf_Id", "cf_Description", "cf_Email", "cf_Name", "cf_Phone", "cf_Subject" },
                values: new object[] { "37c9e0c1-3c5f-4dc0-a77f-8c1c839c9cae", "Description", "Email", "Name", "0123456789", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "EndTime", "StartTime", "couponCode", "couponPrice", "coupon_AppUserFK" },
                values: new object[,]
                {
                    { "1d13e11a-91a0-4440-8c29-d5d8dc26b50a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code10", 10, null },
                    { "0f960b89-10d1-4407-9f35-61f111bbc1eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code50", 50, null }
                });

            migrationBuilder.InsertData(
                table: "PriceForSize",
                columns: new[] { "Id", "Price", "SizeName" },
                values: new object[,]
                {
                    { "cd95219f-a86e-4fce-aff8-4ee9bf8751ef", 10, "M" },
                    { "7765018b-4750-42e8-a1ef-f0f711bd8192", 15, "L" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "IsDelete", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "0e690c2e-2a85-4afe-8c55-9534ab4e16d0", "Staff", "AppRole", false, "Staff", "Staff" },
                    { "360E601E-92F2-4F08-832B-604A21293258", "d5a51024-3c72-4ee3-9012-c0b2387f152b", "admin", "AppRole", false, "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Shipping",
                columns: new[] { "ship_Id", "ship_AppUserFK", "ship_Name", "ship_Price" },
                values: new object[] { "7CF94A7D-9239-446E-A404-086518F84652", null, "Ship", 5 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_Address1", "user_Address2", "user_City", "user_CompanyName", "user_Country", "user_PhoneNumber", "user_PostalCode", "user_State" },
                values: new object[,]
                {
                    { "DE544998-A3CC-4E12-ABB4-0642E57BD222", 0, "61bcda2c-1df9-4576-be4b-a90f8a66024b", "AppUser", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "admin", false, "admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBaVTeh2D6Pae5uD4RY/k67irVlsQf+K6aTtSqz5KIydfr5KMBbaMYWru6JTR5R8CA==", null, false, "42672b33-d6c7-4feb-8b71-44245c8ea935", false, "Admin", null, null, null, null, null, null, null, null },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", 0, "4b3d9c93-b236-4a3d-97f7-c4d336ccaa07", "AppUser", new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@gmail.com", true, "staff", false, "staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEKDXcx0saiPfm1IC+PeLB7h/3LmIYU6RgE23pFl3lhsoJdej1RfnF7VGqdw0z+vbCA==", null, false, "cf00503a-4d9f-4b80-931d-8aeb7d79713e", false, "Staff", null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "IsDelete", "bill_Confirmation", "bill_DatetimeOrder", "bill_Discount", "bill_HideStatus", "bill_Note", "bill_PaidTotal", "bill_PaymentMethod", "bill_ProductIdlist", "bill_ProductNamelist", "bill_ProductPricelist", "bill_ProductSizelist", "bill_QuantityList", "bill_Shipping", "bill_UserId", "bill_WaitForConfirmation" },
                values: new object[] { "D269BF93-A5E2-4C4A-8146-9967DDE80D30", false, true, new DateTime(2022, 5, 3, 14, 6, 35, 172, DateTimeKind.Local).AddTicks(265), 0, false, "", 2000, "Check Payment", "0181432f-e266-477b-9d90-b4afa69f92fb|aca589f8-5f3d-4bf5-b8e0-b49a23a42c40|322d37c2-be82-4c9b-9e6b-af65ef324a87|2ed56cce-1aa7-4f45-9a34-5836de62920c|", "product 1|product 2| product 3| product 4|", "550|450|350|640|", "7|8|9|14|", "1|1|2|1|", 10, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", false });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "cart_Id", "cart_UserID" },
                values: new object[,]
                {
                    { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "72309286-ECBB-4D20-AD95-2819D31E3400", "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "CategoriesFK", "IsDelete", "pd_Description", "pd_Img1", "pd_Name", "pd_Price", "pd_ReducePrice", "pd_ShortDescription", "pd_Size" },
                values: new object[,]
                {
                    { "6be27934-bf99-4093-a231-700a7c5bc6db", "c15b582d-12d4-4af3-9721-1123cc0c8af9", false, "Sprite-15L", "/img/pizza-300x300/Sprite-15L.png", "Sprite-15L", 10, 5, "short 1", "" },
                    { "2ed56cce-1aa7-4f45-9a34-5836de62920c", "c15b582d-12d4-4af3-9721-1123cc0c8af9", false, "pfanta-15", "/img/pizza-300x300/fanta-15.png", "fanta-1.5L", 10, 5, "short 3", "" },
                    { "aca589f8-5f3d-4bf5-b8e0-b49a23a42c40", "c15b582d-12d4-4af3-9721-1123cc0c8af9", false, "coca-zero", "/img/pizza-300x300/coca-zero.png", "Cocacola Zero", 10, 5, "short 2", "" },
                    { "2d737d36-b5ac-4269-badf-dcfdb452e654", "a1fc0dac-d13b-4190-a5cb-0105aecb79e6", false, "MENU-PC-Pho-Mai", "/img/pizza-300x300/MENU-PC-Pho-Mai.png", "MENU-PC-Pho-Mai", 10, 5, "short 1", "" },
                    { "f48dec10-2b6d-4594-a94c-807e51422ef9", "a1fc0dac-d13b-4190-a5cb-0105aecb79e6", false, "MENU-PC-my", "/img/pizza-300x300/MENU-PC-my.png", "MENU-PC-my", 10, 5, "short 1", "" },
                    { "096f7aeb-0747-4b87-bd48-f2cd272310b1", "a1fc0dac-d13b-4190-a5cb-0105aecb79e6", false, "MENU-PC-BBQ", "/img/pizza-300x300/MENU-PC-BBQ.png", "MENU-PC-BBQ", 10, 5, "short 1", "" },
                    { "fcd226c2-f628-4d22-ab05-e6940fa54798", "a1fc0dac-d13b-4190-a5cb-0105aecb79e6", false, "MENU-PC", "/img/pizza-300x300/MENU-PC.png", "MENU-PC", 10, 5, "short 1", "" },
                    { "2b5202d7-a9df-447a-97ee-140d30be427f", "90be5462-391a-440d-a2fb-1fcbf21241d5", false, "pasta-rau-cu", "/img/pizza-300x300/pasta-rau-cu.png", "pasta-rau-cu", 10, 5, "short 1", "" },
                    { "82795a38-baf0-4dd5-b98c-d86a3ca1e51a", "90be5462-391a-440d-a2fb-1fcbf21241d5", false, "pasta-hai-san", "/img/pizza-300x300/pasta-hai-san.png", "pasta-hai-san", 10, 5, "short 1", "" },
                    { "9c89d843-aee6-4a57-8b3a-02267e8d831d", "90be5462-391a-440d-a2fb-1fcbf21241d5", false, "pasta-bo-bam", "/img/pizza-300x300/pasta-bo-bam.png", "pasta", 10, 5, "short 1", "" },
                    { "e0a0c77e-b1d8-4706-bd81-723fb0292b36", "436314dc-6db0-4346-a250-d006c60afa6f", false, "Pizzaminsea", "/img/pizza-300x300/Pizzaminsea.png", "Pizzaminsea", 10, 5, "short 1", "" },
                    { "d35df30c-7912-4ae4-bf24-7e1a2c053796", "436314dc-6db0-4346-a250-d006c60afa6f", false, "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "pizza-bo", 10, 5, "short 1", "" },
                    { "0ff4cf5c-578f-441a-af37-51b5ed220205", "436314dc-6db0-4346-a250-d006c60afa6f", false, "Okonomiyaki", "/img/pizza-300x300/Okonomiyaki.png", "Okonomiyaki", 10, 5, "short 1", "" },
                    { "55f18f70-7d03-412e-99b4-c17f48ce34f4", "436314dc-6db0-4346-a250-d006c60afa6f", false, "Ocean-mania", "/img/pizza-300x300/Ocean-mania.png", "Ocean-mania", 10, 5, "short 1", "" },
                    { "7943ffd7-2e5f-4eac-baff-ebae7a3d0738", "436314dc-6db0-4346-a250-d006c60afa6f", false, "Meat-lover", "/img/pizza-300x300/Meat-lover.png", "Meat-lover", 10, 5, "short 1", "" },
                    { "a9db94e4-ce4a-4b46-ba83-2ae45ebc83eb", "436314dc-6db0-4346-a250-d006c60afa6f", false, "Haft-haft", "/img/pizza-300x300/Haft-haft.png", "Haft-haft", 10, 5, "short 1", "" },
                    { "322d37c2-be82-4c9b-9e6b-af65ef324a87", "436314dc-6db0-4346-a250-d006c60afa6f", false, "Extravaganza", "/img/pizza-300x300/Extravaganza.png", "Extravaganza", 10, 5, "short 1", "" },
                    { "0181432f-e266-477b-9d90-b4afa69f92fb", "436314dc-6db0-4346-a250-d006c60afa6f", false, "Pizza: bo", "/img/pizza-300x300/pizza-bo.png", "Pizza", 10, 5, "short 1", "" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" },
                    { "360E601E-92F2-4F08-832B-604A21293258", "DE544998-A3CC-4E12-ABB4-0642E57BD222" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "pic_CartId", "pic_ProductId", "pic_amount", "pic_color", "pic_size" },
                values: new object[] { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "0181432f-e266-477b-9d90-b4afa69f92fb", 2, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_About_about_AppUserFK",
                table: "About",
                column: "about_AppUserFK");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_bill_UserId",
                table: "Bills",
                column: "bill_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_cart_UserID",
                table: "Carts",
                column: "cart_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactSystems_Contact_AppUserFK",
                table: "ContactSystems",
                column: "Contact_AppUserFK");

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_coupon_AppUserFK",
                table: "Coupons",
                column: "coupon_AppUserFK");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCart_pic_ProductId",
                table: "ProductInCart",
                column: "pic_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoriesFK",
                table: "Products",
                column: "CategoriesFK");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Shipping_ship_AppUserFK",
                table: "Shipping",
                column: "ship_AppUserFK");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "ContactSystems");

            migrationBuilder.DropTable(
                name: "ContactUsers");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "EmailGuest");

            migrationBuilder.DropTable(
                name: "PriceForSize");

            migrationBuilder.DropTable(
                name: "ProductInCart");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Shipping");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
