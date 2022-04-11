using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thinh_Ecom.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactUsers",
                keyColumn: "cf_Id",
                keyValue: "486d9114-bedb-4531-9032-a5873ee9edf1");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "4f7da3c8-468c-43d7-8dbd-828e643a74cf");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "f53ff523-0480-45bc-b438-b67a2413d1e9");

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumns: new[] { "pic_CartId", "pic_ProductId" },
                keyValues: new object[] { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "54715919-8f20-41d2-b9eb-fce9a6c7034a" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "13f5065b-715e-49a3-91df-2178d97d7d90");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "164f1fcf-ede7-4b0e-b959-354b6d8f88bb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "28cd2e92-5d10-4bd4-b57f-df50a8f47aff");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "42364d41-27dc-4412-835e-e097e29e7a03");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "4a72cb5b-a407-44f6-9175-fb5150e908fb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "71cd7e8c-a334-4247-bf3c-3de862feb629");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "77813e5a-79f5-44c6-bf91-8a09a9e84de7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "7a3c3fb5-5091-4544-bf62-0ce4c255c2bb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "85c04f8a-dcd3-4ed0-8e10-2f2e4f1ad8dc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "8e6659d1-5d6d-479e-8bf2-4d151ed8d723");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "aeee7702-1db6-45d8-b84f-5d235e305b8f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "b76287f6-d81b-4581-8484-f5ce740031af");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "bd5df6f7-81ca-4047-bbdd-fc91729544ca");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "c5775c64-a7eb-44a2-b6ad-7a3299dbdbf9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "c7b25000-5ea5-46e1-a944-5a04c5ce4730");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "ce872e4c-7a62-420b-9eb5-00133720266d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "d6b03492-ab8c-4a07-ac36-ec0e12e27b67");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "03e916db-9be1-454b-a3de-3b4299edb9cc");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "c9b10ecb-8f98-4631-a831-89de9f1c00ee");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "e704e911-b37a-4dda-ac31-3ef15dd21e2e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "54715919-8f20-41d2-b9eb-fce9a6c7034a");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "7d312756-0174-4577-8812-b0f9b0b018e8");

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "D269BF93-A5E2-4C4A-8146-9967DDE80D30",
                column: "bill_DatetimeOrder",
                value: new DateTime(2022, 4, 11, 13, 25, 21, 782, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { "53151c35-365b-486c-befc-daf15ac592a7", "Pizza", "", "" },
                    { "d0a5100b-a7e7-4408-bc3e-90c59813ec96", "Spaghetti", "", "" },
                    { "12e9fcb8-88e6-4ce4-9511-224469d00f7c", "Sidedishes", "", "" },
                    { "43c750b7-3c5e-4dd3-95b0-0761270c2450", "Drink", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cf_Id", "cf_Description", "cf_Email", "cf_Name", "cf_Phone", "cf_Subject" },
                values: new object[] { "dc3cf721-5d6b-48e7-be06-3259829494c9", "Description", "Email", "Name", "0123456789", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "EndTime", "StartTime", "couponCode", "couponPrice", "coupon_AppUserFK" },
                values: new object[,]
                {
                    { "ad725743-05e4-4405-b864-f1d4c032dce1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code10", 10, null },
                    { "b4d88c37-16cd-4f5b-aaad-fc7fd3e5ce61", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code50", 50, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "360E601E-92F2-4F08-832B-604A21293258",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "6eb3c297-7af9-4e53-9411-282c12ee32bb", "Admin" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "d70f0079-bccb-4343-bf5d-15980bbd3c8c", "Staff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "DE544998-A3CC-4E12-ABB4-0642E57BD222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa291f8d-9119-4c2e-8260-8bb32dcef31c", "AQAAAAEAACcQAAAAEHVN/ig6y/8Ap2RvZvrZ3jRKdMZllQw4Ba6+lHp1URvKKZSeEGuM2go1K4mVzhPIhw==", "5f9535bc-3786-4876-96b7-1c2865468e8c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e14f1916-6717-4378-aead-ab0adc6556d3", "AQAAAAEAACcQAAAAEMvdlPP41qXpTlgaWHBSZknVtMzRV7Kel4WiJkd7Xl3/CZAY7I8bAkDmVN8ceX3FMw==", "50f9c57a-59b0-4734-83be-6a64680f6d15" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "CategoriesFK", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_MenuFacturer", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_Size" },
                values: new object[,]
                {
                    { "b39b0d95-f680-48ec-9d42-512590e80d5f", "53151c35-365b-486c-befc-daf15ac592a7", "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "", "", "", null, "Pizza", null, null, null, null, 10, 5, 5, "short 1", "" },
                    { "f8331e99-8022-45b1-95e5-09587c28df8f", "43c750b7-3c5e-4dd3-95b0-0761270c2450", "coca-zero", "/img/pizza-300x300/coca-zero.png", "", "", "", null, "Cocacola Zero", null, null, null, null, 10, 5, 5, "short 2", "" },
                    { "dd46a709-bb57-4e9f-ae66-c323d6580fa0", "12e9fcb8-88e6-4ce4-9511-224469d00f7c", "Pizzaminsea", "/img/pizza-300x300/Pizzaminsea.png", "", "", "", null, "Pizzaminsea", null, null, null, null, 10, 5, 5, "", "" },
                    { "96627aa5-f239-43d4-bfb6-e662fd258961", "12e9fcb8-88e6-4ce4-9511-224469d00f7c", "MENU-PC", "/img/pizza-300x300/MENU-PC.png", "", "", "", null, "MENU-PC", null, null, null, null, 10, 5, 5, "", "" },
                    { "624866b9-c04a-4e7e-af10-debf2b3097c6", "d0a5100b-a7e7-4408-bc3e-90c59813ec96", "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "", "", "", null, "pizza-bo", null, null, null, null, 10, 5, 5, "", "" },
                    { "3a7d5287-2555-4d79-9e7d-8fd6e42ea1c8", "d0a5100b-a7e7-4408-bc3e-90c59813ec96", "pasta-rau-cu", "/img/pizza-300x300/pasta-rau-cu.png", "", "", "", null, "pasta-rau-cu", null, null, null, null, 10, 5, 5, "", "" },
                    { "ba6c552d-58de-4c34-adef-30e93f3c6472", "d0a5100b-a7e7-4408-bc3e-90c59813ec96", "MENU-PC-BBQ", "/img/pizza-300x300/MENU-PC-BBQ.png", "", "", "", null, "MENU-PC-BBQ", null, null, null, null, 10, 5, 5, "", "" },
                    { "e9289eca-97e2-4873-807c-e74eaa2e5917", "53151c35-365b-486c-befc-daf15ac592a7", "pasta-hai-san", "/img/pizza-300x300/pasta-hai-san.png", "", "", "", null, "pasta-hai-san", null, null, null, null, 10, 5, 5, "", "" },
                    { "939c9725-b2d9-4dde-aae0-7c9206eb6498", "53151c35-365b-486c-befc-daf15ac592a7", "pasta-bo-bam", "/img/pizza-300x300/pasta-bo-bam.png", "", "", "", null, "pasta", null, null, null, null, 10, 5, 5, "", "" },
                    { "a4e1104a-2e61-4682-8fb7-45983344a2d0", "53151c35-365b-486c-befc-daf15ac592a7", "Okonomiyaki", "/img/pizza-300x300/Okonomiyaki.png", "", "", "", null, "Okonomiyaki", null, null, null, null, 10, 5, 5, "", "" },
                    { "d829ea36-0dd5-4597-9f06-76f609dc9e0b", "53151c35-365b-486c-befc-daf15ac592a7", "Ocean-mania", "/img/pizza-300x300/Ocean-mania.png", "", "", "", null, "Ocean-mania", null, null, null, null, 10, 5, 5, "", "" },
                    { "14771e82-6763-41ab-b2d7-0ec544f0c5fd", "53151c35-365b-486c-befc-daf15ac592a7", "MENU-PC-Pho-Mai", "/img/pizza-300x300/MENU-PC-Pho-Mai.png", "", "", "", null, "MENU-PC-Pho-Mai", null, null, null, null, 10, 5, 5, "", "" },
                    { "9de4ab4c-5835-434b-bb9b-9e3771d8c84a", "53151c35-365b-486c-befc-daf15ac592a7", "MENU-PC-my", "/img/pizza-300x300/MENU-PC-my.png", "", "", "", null, "MENU-PC-my", null, null, null, null, 10, 5, 5, "", "" },
                    { "8f74be5e-4dad-4e82-838d-f5aaf598d81c", "53151c35-365b-486c-befc-daf15ac592a7", "Meat-lover", "/img/pizza-300x300/Meat-lover.png", "", "", "", null, "Meat-lover", null, null, null, null, 10, 5, 5, "", "" },
                    { "10084160-6eca-49cf-a267-d35d10bc70fe", "53151c35-365b-486c-befc-daf15ac592a7", "Haft-haft", "/img/pizza-300x300/Haft-haft.png", "", "", "", null, "Haft-haft", null, null, null, null, 10, 5, 5, "", "" },
                    { "9f028af3-17db-41c5-ba7b-a9b739f58c72", "53151c35-365b-486c-befc-daf15ac592a7", "Extravaganza", "/img/pizza-300x300/Extravaganza.png", "", "", "", null, "Extravaganza", null, null, null, null, 10, 5, 5, "", "" },
                    { "14a9999c-ac52-45d5-96e6-ca81ab31361b", "43c750b7-3c5e-4dd3-95b0-0761270c2450", "pfanta-15", "/img/pizza-300x300/fanta-15.png", "", "", "", null, "fanta-1.5L", null, null, null, null, 10, 5, 5, "short 3", "" },
                    { "c1ef5d85-11e4-47e4-9947-131c0dd1a147", "43c750b7-3c5e-4dd3-95b0-0761270c2450", "Sprite-15L", "/img/pizza-300x300/Sprite-15L.png", "", "", "", null, "Sprite-15L", null, null, null, null, 10, 5, 5, "", "" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "pic_CartId", "pic_ProductId", "pic_amount", "pic_color", "pic_size" },
                values: new object[] { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "b39b0d95-f680-48ec-9d42-512590e80d5f", 2, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactUsers",
                keyColumn: "cf_Id",
                keyValue: "dc3cf721-5d6b-48e7-be06-3259829494c9");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "ad725743-05e4-4405-b864-f1d4c032dce1");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "b4d88c37-16cd-4f5b-aaad-fc7fd3e5ce61");

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumns: new[] { "pic_CartId", "pic_ProductId" },
                keyValues: new object[] { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "b39b0d95-f680-48ec-9d42-512590e80d5f" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "10084160-6eca-49cf-a267-d35d10bc70fe");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "14771e82-6763-41ab-b2d7-0ec544f0c5fd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "14a9999c-ac52-45d5-96e6-ca81ab31361b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "3a7d5287-2555-4d79-9e7d-8fd6e42ea1c8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "624866b9-c04a-4e7e-af10-debf2b3097c6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "8f74be5e-4dad-4e82-838d-f5aaf598d81c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "939c9725-b2d9-4dde-aae0-7c9206eb6498");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "96627aa5-f239-43d4-bfb6-e662fd258961");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "9de4ab4c-5835-434b-bb9b-9e3771d8c84a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "9f028af3-17db-41c5-ba7b-a9b739f58c72");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "a4e1104a-2e61-4682-8fb7-45983344a2d0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "ba6c552d-58de-4c34-adef-30e93f3c6472");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "c1ef5d85-11e4-47e4-9947-131c0dd1a147");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "d829ea36-0dd5-4597-9f06-76f609dc9e0b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "dd46a709-bb57-4e9f-ae66-c323d6580fa0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "e9289eca-97e2-4873-807c-e74eaa2e5917");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "f8331e99-8022-45b1-95e5-09587c28df8f");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "12e9fcb8-88e6-4ce4-9511-224469d00f7c");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "43c750b7-3c5e-4dd3-95b0-0761270c2450");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "d0a5100b-a7e7-4408-bc3e-90c59813ec96");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "b39b0d95-f680-48ec-9d42-512590e80d5f");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "53151c35-365b-486c-befc-daf15ac592a7");

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "D269BF93-A5E2-4C4A-8146-9967DDE80D30",
                column: "bill_DatetimeOrder",
                value: new DateTime(2022, 4, 11, 13, 21, 27, 455, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { "7d312756-0174-4577-8812-b0f9b0b018e8", "Pizza", "", "" },
                    { "03e916db-9be1-454b-a3de-3b4299edb9cc", "Spaghetti", "", "" },
                    { "c9b10ecb-8f98-4631-a831-89de9f1c00ee", "Sidedishes", "", "" },
                    { "e704e911-b37a-4dda-ac31-3ef15dd21e2e", "Drink", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cf_Id", "cf_Description", "cf_Email", "cf_Name", "cf_Phone", "cf_Subject" },
                values: new object[] { "486d9114-bedb-4531-9032-a5873ee9edf1", "Description", "Email", "Name", "0123456789", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "EndTime", "StartTime", "couponCode", "couponPrice", "coupon_AppUserFK" },
                values: new object[,]
                {
                    { "4f7da3c8-468c-43d7-8dbd-828e643a74cf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code10", 10, null },
                    { "f53ff523-0480-45bc-b438-b67a2413d1e9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code50", 50, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "360E601E-92F2-4F08-832B-604A21293258",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "5dcedaa7-8350-4951-876b-e5fec9d54cab", null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "0ca588f3-edb9-472d-9803-92222a6fb20a", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "DE544998-A3CC-4E12-ABB4-0642E57BD222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a584a327-eb2c-4bcc-85e0-99aede2ea830", "AQAAAAEAACcQAAAAEIszxNp9uuOAPAGCQiUlPkHBmeT2ZU0txJZMkEngs57I2eN8SXPANJGFc6ycplhPKA==", "1b7ab7ed-6661-41d8-b9d0-cebc3ad03f80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3b4c1b0-d72e-4a32-b187-f68e6297df80", "AQAAAAEAACcQAAAAEBQd5lfMoL0cpmWH9y3lTRN6a3LNa3HH8Ydjr5qSinxH/fGte1EyPbEqgJUuNbYfcA==", "a5944b14-499c-41ac-bf57-a73c83e9cb43" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "CategoriesFK", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_MenuFacturer", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_Size" },
                values: new object[,]
                {
                    { "54715919-8f20-41d2-b9eb-fce9a6c7034a", "7d312756-0174-4577-8812-b0f9b0b018e8", "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "", "", "", null, "Pizza", null, null, null, null, 10, 5, 5, "short 1", "" },
                    { "c7b25000-5ea5-46e1-a944-5a04c5ce4730", "e704e911-b37a-4dda-ac31-3ef15dd21e2e", "coca-zero", "/img/pizza-300x300/coca-zero.png", "", "", "", null, "Cocacola Zero", null, null, null, null, 10, 5, 5, "short 2", "" },
                    { "4a72cb5b-a407-44f6-9175-fb5150e908fb", "c9b10ecb-8f98-4631-a831-89de9f1c00ee", "Pizzaminsea", "/img/pizza-300x300/Pizzaminsea.png", "", "", "", null, "Pizzaminsea", null, null, null, null, 10, 5, 5, "", "" },
                    { "bd5df6f7-81ca-4047-bbdd-fc91729544ca", "c9b10ecb-8f98-4631-a831-89de9f1c00ee", "MENU-PC", "/img/pizza-300x300/MENU-PC.png", "", "", "", null, "MENU-PC", null, null, null, null, 10, 5, 5, "", "" },
                    { "164f1fcf-ede7-4b0e-b959-354b6d8f88bb", "03e916db-9be1-454b-a3de-3b4299edb9cc", "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "", "", "", null, "pizza-bo", null, null, null, null, 10, 5, 5, "", "" },
                    { "28cd2e92-5d10-4bd4-b57f-df50a8f47aff", "03e916db-9be1-454b-a3de-3b4299edb9cc", "pasta-rau-cu", "/img/pizza-300x300/pasta-rau-cu.png", "", "", "", null, "pasta-rau-cu", null, null, null, null, 10, 5, 5, "", "" },
                    { "71cd7e8c-a334-4247-bf3c-3de862feb629", "03e916db-9be1-454b-a3de-3b4299edb9cc", "MENU-PC-BBQ", "/img/pizza-300x300/MENU-PC-BBQ.png", "", "", "", null, "MENU-PC-BBQ", null, null, null, null, 10, 5, 5, "", "" },
                    { "c5775c64-a7eb-44a2-b6ad-7a3299dbdbf9", "7d312756-0174-4577-8812-b0f9b0b018e8", "pasta-hai-san", "/img/pizza-300x300/pasta-hai-san.png", "", "", "", null, "pasta-hai-san", null, null, null, null, 10, 5, 5, "", "" },
                    { "85c04f8a-dcd3-4ed0-8e10-2f2e4f1ad8dc", "7d312756-0174-4577-8812-b0f9b0b018e8", "pasta-bo-bam", "/img/pizza-300x300/pasta-bo-bam.png", "", "", "", null, "pasta", null, null, null, null, 10, 5, 5, "", "" },
                    { "b76287f6-d81b-4581-8484-f5ce740031af", "7d312756-0174-4577-8812-b0f9b0b018e8", "Okonomiyaki", "/img/pizza-300x300/Okonomiyaki.png", "", "", "", null, "Okonomiyaki", null, null, null, null, 10, 5, 5, "", "" },
                    { "7a3c3fb5-5091-4544-bf62-0ce4c255c2bb", "7d312756-0174-4577-8812-b0f9b0b018e8", "Ocean-mania", "/img/pizza-300x300/Ocean-mania.png", "", "", "", null, "Ocean-mania", null, null, null, null, 10, 5, 5, "", "" },
                    { "aeee7702-1db6-45d8-b84f-5d235e305b8f", "7d312756-0174-4577-8812-b0f9b0b018e8", "MENU-PC-Pho-Mai", "/img/pizza-300x300/MENU-PC-Pho-Mai.png", "", "", "", null, "MENU-PC-Pho-Mai", null, null, null, null, 10, 5, 5, "", "" },
                    { "8e6659d1-5d6d-479e-8bf2-4d151ed8d723", "7d312756-0174-4577-8812-b0f9b0b018e8", "MENU-PC-my", "/img/pizza-300x300/MENU-PC-my.png", "", "", "", null, "MENU-PC-my", null, null, null, null, 10, 5, 5, "", "" },
                    { "d6b03492-ab8c-4a07-ac36-ec0e12e27b67", "7d312756-0174-4577-8812-b0f9b0b018e8", "Meat-lover", "/img/pizza-300x300/Meat-lover.png", "", "", "", null, "Meat-lover", null, null, null, null, 10, 5, 5, "", "" },
                    { "42364d41-27dc-4412-835e-e097e29e7a03", "7d312756-0174-4577-8812-b0f9b0b018e8", "Haft-haft", "/img/pizza-300x300/Haft-haft.png", "", "", "", null, "Haft-haft", null, null, null, null, 10, 5, 5, "", "" },
                    { "13f5065b-715e-49a3-91df-2178d97d7d90", "7d312756-0174-4577-8812-b0f9b0b018e8", "Extravaganza", "/img/pizza-300x300/Extravaganza.png", "", "", "", null, "Extravaganza", null, null, null, null, 10, 5, 5, "", "" },
                    { "ce872e4c-7a62-420b-9eb5-00133720266d", "e704e911-b37a-4dda-ac31-3ef15dd21e2e", "pfanta-15", "/img/pizza-300x300/fanta-15.png", "", "", "", null, "fanta-1.5L", null, null, null, null, 10, 5, 5, "short 3", "" },
                    { "77813e5a-79f5-44c6-bf91-8a09a9e84de7", "e704e911-b37a-4dda-ac31-3ef15dd21e2e", "Sprite-15L", "/img/pizza-300x300/Sprite-15L.png", "", "", "", null, "Sprite-15L", null, null, null, null, 10, 5, 5, "", "" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "pic_CartId", "pic_ProductId", "pic_amount", "pic_color", "pic_size" },
                values: new object[] { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "54715919-8f20-41d2-b9eb-fce9a6c7034a", 2, null, null });
        }
    }
}
