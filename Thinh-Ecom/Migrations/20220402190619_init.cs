using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thinh_Ecom.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    about_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    about_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.about_id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    cg_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cg_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cg_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cg_Sale = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.cg_Id);
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
                    Contact_Website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactSystems", x => x.Contact_Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUsers",
                columns: table => new
                {
                    cu_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cu_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsers", x => x.cu_Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    couponId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    couponCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    couponPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.couponId);
                });

            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    deviceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    deviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devicePostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devicePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.deviceId);
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
                    pd_NameImg1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_NameImg2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_NameImg3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_NameImg4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Rate = table.Column<int>(type: "int", nullable: false),
                    pd_MenuFacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Size = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.pd_Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shipping",
                columns: table => new
                {
                    ship_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ship_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ship_Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping", x => x.ship_Id);
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
                    bill_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "CartsDevice",
                columns: table => new
                {
                    cartd_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cartd_DeviceId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartsDevice", x => x.cartd_Id);
                    table.ForeignKey(
                        name: "FK_CartsDevice_Device_cartd_DeviceId",
                        column: x => x.cartd_DeviceId,
                        principalTable: "Device",
                        principalColumn: "deviceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductsInCategories",
                columns: table => new
                {
                    pic_CategoriesId = table.Column<int>(type: "int", nullable: false),
                    pic_productId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsInCategories", x => new { x.pic_productId, x.pic_CategoriesId });
                    table.ForeignKey(
                        name: "FK_ProductsInCategories_Categories_pic_CategoriesId",
                        column: x => x.pic_CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "cg_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsInCategories_Products_pic_productId",
                        column: x => x.pic_productId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Bills",
                columns: table => new
                {
                    bill_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bill_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    bill_PaidTotal = table.Column<int>(type: "int", nullable: false),
                    bill_ProductIdlist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductNamelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductSizelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductColorlist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductPricelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Shipping = table.Column<int>(type: "int", nullable: false),
                    bill_Discount = table.Column<int>(type: "int", nullable: false),
                    bill_Confirmation = table.Column<bool>(type: "bit", nullable: false),
                    bill_DatetimeOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bill_PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    bill_WaitForConfirmation = table.Column<bool>(type: "bit", nullable: false),
                    bill_WaitPickup = table.Column<bool>(type: "bit", nullable: false),
                    bill_Delivering = table.Column<bool>(type: "bit", nullable: false),
                    bill_Delivered = table.Column<bool>(type: "bit", nullable: false),
                    bill_Cancelled = table.Column<bool>(type: "bit", nullable: false)
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
                name: "Reviews",
                columns: table => new
                {
                    review_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    review_Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    review_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    review_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    review_ReviewType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    review_UploadTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.review_id);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_review_UserId",
                        column: x => x.review_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubReview",
                columns: table => new
                {
                    subReview_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    subReview_Commnet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subReview_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    subReview_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    subreview_SubReviewType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subReview_DateCommnet = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubReview", x => x.subReview_Id);
                    table.ForeignKey(
                        name: "FK_SubReview_Users_subReview_UserId",
                        column: x => x.subReview_UserId,
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "ProductInCartDevices",
                columns: table => new
                {
                    picd_CartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    picd_ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    picd_amount = table.Column<int>(type: "int", nullable: false),
                    picd_size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    picd_color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCartDevices", x => new { x.picd_CartId, x.picd_ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCartDevices_CartsDevice_picd_CartId",
                        column: x => x.picd_CartId,
                        principalTable: "CartsDevice",
                        principalColumn: "cartd_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCartDevices_Products_picd_ProductId",
                        column: x => x.picd_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCart",
                columns: table => new
                {
                    pic_CartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pic_ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "ReviewInproduct",
                columns: table => new
                {
                    rip_ReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    rip_ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewInproduct", x => new { x.rip_ProductId, x.rip_ReviewId });
                    table.ForeignKey(
                        name: "FK_ReviewInproduct_Products_rip_ProductId",
                        column: x => x.rip_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewInproduct_Reviews_rip_ReviewId",
                        column: x => x.rip_ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "review_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubReviewInReview",
                columns: table => new
                {
                    SRiR_ReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SRiR_SubReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubReviewInReview", x => new { x.SRiR_ReviewId, x.SRiR_SubReviewId });
                    table.ForeignKey(
                        name: "FK_SubReviewInReview_Reviews_SRiR_ReviewId",
                        column: x => x.SRiR_ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "review_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubReviewInReview_SubReview_SRiR_SubReviewId",
                        column: x => x.SRiR_SubReviewId,
                        principalTable: "SubReview",
                        principalColumn: "subReview_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "about_id", "about_Description", "about_Title", "about_Url" },
                values: new object[] { 1, "The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. \n \n When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove,the headline of Alphabet Village and the subline of her own road,the Line Lane.Pityful a rethoric question ran over her cheek,then she continued her way.", "Footwear the leading eCommerce Store around the Globe", "https://www.youtube.com/watch?v=F1vcruph8JA" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { 1, "Pizza", "", "" },
                    { 2, "Spaghetti", "", "" },
                    { 3, "Side dishes", "", "" },
                    { 4, "Drink", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactSystems",
                columns: new[] { "Contact_Id", "Contact_Address", "Contact_Email", "Contact_Phone", "Contact_Website" },
                values: new object[] { 1, " 123, An Lac A Ward, Binh Tan District, HCM", "admin@gmail.com", "0123456789", "https://shoes.com" });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cu_Id", "cu_Description", "cu_Email", "cu_FirstName", "cu_LastName", "cu_Subject" },
                values: new object[] { 1, "Description", "Email", "FirstName", "LastName", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "couponCode", "couponPrice" },
                values: new object[,]
                {
                    { "ad62d42b-f319-4511-a61b-8fb2b09bc2c5", "code50", 50 },
                    { "da30fc7d-9523-4010-bf12-353353cfac41", "code10", 10 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_MenuFacturer", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_Size" },
                values: new object[,]
                {
                    { "f62cf5c5-16a7-4bb0-a7e9-7bc889fa8f1b", "MENU-PC-Pho-Mai", "/img/pizza-300x300/MENU-PC-Pho-Mai.png", "", "", "", null, "MENU-PC-Pho-Mai", null, null, null, null, 10, 5, 5, "", "" },
                    { "05140b88-40b1-4261-9ae2-691a4df295e8", "Sprite-15L", "/img/pizza-300x300/Sprite-15L.png", "", "", "", null, "Sprite-15L", null, null, null, null, 10, 5, 5, "", "" },
                    { "abdd81e8-3518-4397-9f62-d30239a0fa43", "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "", "", "", null, "pizza-bo", null, null, null, null, 10, 5, 5, "", "" },
                    { "66ee31fe-e49a-43af-9498-d0251e40834a", "pasta-rau-cu", "/img/pizza-300x300/pasta-rau-cu.png", "", "", "", null, "pasta-rau-cu", null, null, null, null, 10, 5, 5, "", "" },
                    { "1d57b4b4-7966-4aee-a9ec-45310196b492", "pasta-hai-san", "/img/pizza-300x300/pasta-hai-san.png", "", "", "", null, "pasta-hai-san", null, null, null, null, 10, 5, 5, "", "" },
                    { "d367299b-732b-417a-95e3-220976b185f2", "pasta-bo-bam", "/img/pizza-300x300/pasta-bo-bam.png", "", "", "", null, "pasta", null, null, null, null, 10, 5, 5, "", "" },
                    { "10018e4c-adc3-43a2-b583-6d728ab37e1b", "Okonomiyaki", "/img/pizza-300x300/Okonomiyaki.png", "", "", "", null, "Okonomiyaki", null, null, null, null, 10, 5, 5, "", "" },
                    { "538046e6-4b2c-48e0-9a99-5403e40582e9", "Ocean-mania", "/img/pizza-300x300/Ocean-mania.png", "", "", "", null, "Ocean-mania", null, null, null, null, 10, 5, 5, "", "" },
                    { "af555bf0-2bc2-4ac0-93e2-21a764378660", "Pizzaminsea", "/img/pizza-300x300/Pizzaminsea.png", "", "", "", null, "Pizzaminsea", null, null, null, null, 10, 5, 5, "", "" },
                    { "907875d7-f75d-4193-a25e-88ae77893882", "MENU-PC-my", "/img/pizza-300x300/MENU-PC-my.png", "", "", "", null, "MENU-PC-my", null, null, null, null, 10, 5, 5, "", "" },
                    { "0de14623-6aed-4c5b-afc2-3b704197da31", "Haft-haft", "/img/pizza-300x300/Haft-haft.png", "", "", "", null, "Haft-haft", null, null, null, null, 10, 5, 5, "", "" },
                    { "c647fc7d-6a74-4d60-8c22-8a49cfb4b5be", "MENU-PC", "/img/pizza-300x300/MENU-PC.png", "", "", "", null, "MENU-PC", null, null, null, null, 10, 5, 5, "", "" },
                    { "91c7119c-ebd6-43a0-a37f-278bc5ff203e", "Meat-lover", "/img/pizza-300x300/Meat-lover.png", "", "", "", null, "Meat-lover", null, null, null, null, 10, 5, 5, "", "" },
                    { "c9498180-950b-4f93-8e73-aa1ffaa5a1c3", "pfanta-15", "/img/pizza-300x300/fanta-15.png", "", "", "", null, "fanta-1.5L", null, null, null, null, 10, 5, 5, "", "" },
                    { "292b7c59-c200-4b42-9353-b475683d7491", "Extravaganza", "/img/pizza-300x300/Extravaganza.png", "", "", "", null, "Extravaganza", null, null, null, null, 10, 5, 5, "", "" },
                    { "3c27363b-20c8-44ab-ad73-0e394a4b4a41", "coca-zero", "/img/pizza-300x300/coca-zero.png", "", "", "", null, "Cocacola Zero", null, null, null, null, 10, 5, 5, "", "" },
                    { "397a21d4-8724-4f03-8fb5-543aebabafbf", "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "", "", "", null, "Pizza", null, null, null, null, 10, 5, 5, "", "" },
                    { "c37c9c56-c92b-41f1-a043-e9195c94fa63", "MENU-PC-BBQ", "/img/pizza-300x300/MENU-PC-BBQ.png", "", "", "", null, "MENU-PC-BBQ", null, null, null, null, 10, 5, 5, "", "" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "b9fec546-1eac-41cb-9ac9-647779848b46", "Staff", "AppRole", "staff", null },
                    { "360E601E-92F2-4F08-832B-604A21293258", "02890dcf-322d-4665-ba1c-fd537c656606", "admin", "AppRole", "admin", null }
                });

            migrationBuilder.InsertData(
                table: "Shipping",
                columns: new[] { "ship_Id", "ship_Name", "ship_Price" },
                values: new object[] { "7CF94A7D-9239-446E-A404-086518F84652", "Ship", 5 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "bill_Address1", "bill_Address2", "bill_City", "bill_CompanyName", "bill_Country", "bill_PhoneNumber", "bill_PostalCode", "bill_State" },
                values: new object[,]
                {
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", 0, "1537772e-193c-477a-a145-24caa2e48c16", "AppUser", new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@gmail.com", true, "staff", "staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEGqTfBdf9BKWAGySAyDM48f3lv86Kiw2C/2McXbBMeFGsV9jZ6DRk2GltC3PHgyZIw==", null, false, "f1c58698-d3b7-4b9e-84d8-512741e5e863", false, "Staff", null, null, null, null, null, null, null, null },
                    { "DE544998-A3CC-4E12-ABB4-0642E57BD222", 0, "4d8d6904-b85c-4901-adb5-20a0ce75a5a2", "AppUser", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "admin", "admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAELs8L1o6lqj9yN49c1+PTh3t2mMqatgFya2JUJDbcPPNRyC4oIARzrdPeqLhJoCx2g==", null, false, "0067d1ec-9823-4e47-84c0-2576ff767720", false, "Admin", null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "bill_Cancelled", "bill_Confirmation", "bill_DatetimeOrder", "bill_Delivered", "bill_Delivering", "bill_Discount", "bill_HideStatus", "bill_Note", "bill_PaidTotal", "bill_PaymentMethod", "bill_ProductColorlist", "bill_ProductIdlist", "bill_ProductNamelist", "bill_ProductPricelist", "bill_ProductSizelist", "bill_Quantity", "bill_Shipping", "bill_UserId", "bill_WaitForConfirmation", "bill_WaitPickup" },
                values: new object[] { "D269BF93-A5E2-4C4A-8146-9967DDE80D30", false, true, new DateTime(2022, 4, 3, 2, 6, 19, 46, DateTimeKind.Local).AddTicks(7471), false, false, 0, false, "", 2000, "Check Payment", "Blue|Red|Black|Green", "1|2|3|4", "product 1|product 2| product 3| product 4", "550|450|350|640", "7|8|9|14", "1|1|2|1", 10, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", false, false });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "cart_Id", "cart_UserID" },
                values: new object[,]
                {
                    { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "72309286-ECBB-4D20-AD95-2819D31E3400", "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" }
                });

            migrationBuilder.InsertData(
                table: "ProductsInCategories",
                columns: new[] { "pic_CategoriesId", "pic_productId" },
                values: new object[,]
                {
                    { 4, "05140b88-40b1-4261-9ae2-691a4df295e8" },
                    { 2, "af555bf0-2bc2-4ac0-93e2-21a764378660" },
                    { 1, "af555bf0-2bc2-4ac0-93e2-21a764378660" },
                    { 1, "abdd81e8-3518-4397-9f62-d30239a0fa43" },
                    { 2, "66ee31fe-e49a-43af-9498-d0251e40834a" },
                    { 2, "1d57b4b4-7966-4aee-a9ec-45310196b492" },
                    { 2, "d367299b-732b-417a-95e3-220976b185f2" },
                    { 1, "10018e4c-adc3-43a2-b583-6d728ab37e1b" },
                    { 1, "538046e6-4b2c-48e0-9a99-5403e40582e9" },
                    { 3, "f62cf5c5-16a7-4bb0-a7e9-7bc889fa8f1b" },
                    { 3, "907875d7-f75d-4193-a25e-88ae77893882" },
                    { 3, "c37c9c56-c92b-41f1-a043-e9195c94fa63" },
                    { 1, "91c7119c-ebd6-43a0-a37f-278bc5ff203e" },
                    { 1, "0de14623-6aed-4c5b-afc2-3b704197da31" },
                    { 4, "c9498180-950b-4f93-8e73-aa1ffaa5a1c3" },
                    { 1, "292b7c59-c200-4b42-9353-b475683d7491" },
                    { 4, "3c27363b-20c8-44ab-ad73-0e394a4b4a41" },
                    { 1, "397a21d4-8724-4f03-8fb5-543aebabafbf" },
                    { 3, "c647fc7d-6a74-4d60-8c22-8a49cfb4b5be" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "review_id", "review_Comment", "review_HideStatus", "review_ReviewType", "review_UploadTime", "review_UserId" },
                values: new object[,]
                {
                    { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "Good2", false, "Review", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" },
                    { "C2A543C2-B1E2-4DC5-A131-9137E4673FA6", "Good3", false, "Review", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "Good1", false, "Review", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "DE544998-A3CC-4E12-ABB4-0642E57BD222" }
                });

            migrationBuilder.InsertData(
                table: "SubReview",
                columns: new[] { "subReview_Id", "subReview_Commnet", "subReview_DateCommnet", "subReview_HideStatus", "subReview_UserId", "subreview_SubReviewType" },
                values: new object[,]
                {
                    { "ed873c85-dfd3-480c-8ad1-10a8917f2cb2", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", "SubReview" },
                    { "7575f75c-1e60-4f18-8140-96ae6777b15e", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" },
                    { "62757e49-945e-4ca9-89d3-573193c8e2fa", "subreview 1", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" }
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
                values: new object[] { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "397a21d4-8724-4f03-8fb5-543aebabafbf", 2, null, null });

            migrationBuilder.InsertData(
                table: "ReviewInproduct",
                columns: new[] { "rip_ProductId", "rip_ReviewId" },
                values: new object[,]
                {
                    { "397a21d4-8724-4f03-8fb5-543aebabafbf", "EEBA6608-AB75-4E83-909F-604B1A06F16C" },
                    { "397a21d4-8724-4f03-8fb5-543aebabafbf", "C2A543C2-B1E2-4DC5-A131-9137E4673FA6" },
                    { "397a21d4-8724-4f03-8fb5-543aebabafbf", "9EED8607-D2BB-45EE-AEE3-C59D858A7F97" }
                });

            migrationBuilder.InsertData(
                table: "SubReviewInReview",
                columns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                values: new object[,]
                {
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "62757e49-945e-4ca9-89d3-573193c8e2fa" },
                    { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "7575f75c-1e60-4f18-8140-96ae6777b15e" },
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "ed873c85-dfd3-480c-8ad1-10a8917f2cb2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_bill_UserId",
                table: "Bills",
                column: "bill_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_cart_UserID",
                table: "Carts",
                column: "cart_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CartsDevice_cartd_DeviceId",
                table: "CartsDevice",
                column: "cartd_DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCart_pic_ProductId",
                table: "ProductInCart",
                column: "pic_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCartDevices_picd_ProductId",
                table: "ProductInCartDevices",
                column: "picd_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInCategories_pic_CategoriesId",
                table: "ProductsInCategories",
                column: "pic_CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewInproduct_rip_ReviewId",
                table: "ReviewInproduct",
                column: "rip_ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_review_UserId",
                table: "Reviews",
                column: "review_UserId");

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
                name: "IX_SubReview_subReview_UserId",
                table: "SubReview",
                column: "subReview_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubReviewInReview_SRiR_SubReviewId",
                table: "SubReviewInReview",
                column: "SRiR_SubReviewId");

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
                name: "ProductInCart");

            migrationBuilder.DropTable(
                name: "ProductInCartDevices");

            migrationBuilder.DropTable(
                name: "ProductsInCategories");

            migrationBuilder.DropTable(
                name: "ReviewInproduct");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Shipping");

            migrationBuilder.DropTable(
                name: "SubReviewInReview");

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
                name: "CartsDevice");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "SubReview");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
