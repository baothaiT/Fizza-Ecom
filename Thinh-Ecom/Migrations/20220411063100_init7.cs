using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thinh_Ecom.Migrations
{
    public partial class init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2022, 4, 11, 13, 30, 59, 131, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { "11a7d74f-b20d-4212-8896-444ee3086b68", "Pizza", "", "" },
                    { "988bd9f7-91ff-42a4-8966-ee6d2bcf8d62", "Spaghetti", "", "" },
                    { "f312bdee-521a-400e-8ad7-13025c4fda19", "Sidedishes", "", "" },
                    { "275a8557-5e33-469d-aa8e-be1ea7660460", "Drink", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cf_Id", "cf_Description", "cf_Email", "cf_Name", "cf_Phone", "cf_Subject" },
                values: new object[] { "8b00a3a2-689d-41c5-8b15-8b52d3a021d6", "Description", "Email", "Name", "0123456789", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "EndTime", "StartTime", "couponCode", "couponPrice", "coupon_AppUserFK" },
                values: new object[,]
                {
                    { "be1b2e35-772a-466a-aba7-7b99d6166a6d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code10", 10, null },
                    { "3b965bf1-7ee6-4e07-b31b-fe78abae05bd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code50", 50, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "360E601E-92F2-4F08-832B-604A21293258",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "26e0e839-1143-4d90-8770-ebdea2111401", "Admin" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "451a8a2d-ccf5-4dab-a628-c8e2ee610622", "Staff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "DE544998-A3CC-4E12-ABB4-0642E57BD222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a4f2d5f-3b14-4972-9bb2-97a36fcd8a06", "AQAAAAEAACcQAAAAEKHCMI6OAvKnHdO3m6MAvMfkTVoqe/XL279ga8dhv73D5JPN3iimgmuhbXpehTkm3A==", "00b15e93-a83a-4826-b9a2-02c214cc94bf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9122fe55-737e-46e0-be6f-2f50542e3c24", "AQAAAAEAACcQAAAAEF5DQJ8diA8J5v8UrfeU5264uHOaqmoaZpyX6hTvBbKolqHEjgKgwiSgunD5dA3Llg==", "aee56107-4580-46ab-8754-3e99678480cb" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "CategoriesFK", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_MenuFacturer", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_Size" },
                values: new object[,]
                {
                    { "a5d82765-5bcb-48e1-9e81-2b05cecd085f", "11a7d74f-b20d-4212-8896-444ee3086b68", "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "", "", "", null, "Pizza", null, null, null, null, 10, 5, 5, "short 1", "" },
                    { "8f272d13-c87d-45a0-acae-612fc8a563d9", "275a8557-5e33-469d-aa8e-be1ea7660460", "coca-zero", "/img/pizza-300x300/coca-zero.png", "", "", "", null, "Cocacola Zero", null, null, null, null, 10, 5, 5, "short 2", "" },
                    { "86640ca2-0bdc-4d73-af88-adfcc51ec2d5", "f312bdee-521a-400e-8ad7-13025c4fda19", "Pizzaminsea", "/img/pizza-300x300/Pizzaminsea.png", "", "", "", null, "Pizzaminsea", null, null, null, null, 10, 5, 5, "", "" },
                    { "d15ff6e8-55b9-49f0-8ef8-e090541e2431", "f312bdee-521a-400e-8ad7-13025c4fda19", "MENU-PC", "/img/pizza-300x300/MENU-PC.png", "", "", "", null, "MENU-PC", null, null, null, null, 10, 5, 5, "", "" },
                    { "355f5f8b-7482-4514-b886-ecb6beaaa36c", "988bd9f7-91ff-42a4-8966-ee6d2bcf8d62", "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "", "", "", null, "pizza-bo", null, null, null, null, 10, 5, 5, "", "" },
                    { "ba2648b0-aa60-4639-b298-ab17c82e6290", "988bd9f7-91ff-42a4-8966-ee6d2bcf8d62", "pasta-rau-cu", "/img/pizza-300x300/pasta-rau-cu.png", "", "", "", null, "pasta-rau-cu", null, null, null, null, 10, 5, 5, "", "" },
                    { "af6caab0-8f60-4482-850e-07bc6c6a5bfd", "988bd9f7-91ff-42a4-8966-ee6d2bcf8d62", "MENU-PC-BBQ", "/img/pizza-300x300/MENU-PC-BBQ.png", "", "", "", null, "MENU-PC-BBQ", null, null, null, null, 10, 5, 5, "", "" },
                    { "81b193b2-2f0a-406f-aeb1-9457f91b1f09", "11a7d74f-b20d-4212-8896-444ee3086b68", "pasta-hai-san", "/img/pizza-300x300/pasta-hai-san.png", "", "", "", null, "pasta-hai-san", null, null, null, null, 10, 5, 5, "", "" },
                    { "3a58658e-c343-48e9-b399-50655e06b207", "11a7d74f-b20d-4212-8896-444ee3086b68", "pasta-bo-bam", "/img/pizza-300x300/pasta-bo-bam.png", "", "", "", null, "pasta", null, null, null, null, 10, 5, 5, "", "" },
                    { "55715c42-679c-4d63-add6-b516c555597c", "11a7d74f-b20d-4212-8896-444ee3086b68", "Okonomiyaki", "/img/pizza-300x300/Okonomiyaki.png", "", "", "", null, "Okonomiyaki", null, null, null, null, 10, 5, 5, "", "" },
                    { "a6ebd0dd-0432-4af2-a6e8-b3b7a4a2d3b4", "11a7d74f-b20d-4212-8896-444ee3086b68", "Ocean-mania", "/img/pizza-300x300/Ocean-mania.png", "", "", "", null, "Ocean-mania", null, null, null, null, 10, 5, 5, "", "" },
                    { "24eda427-0770-4a33-9481-312fe506a8f4", "11a7d74f-b20d-4212-8896-444ee3086b68", "MENU-PC-Pho-Mai", "/img/pizza-300x300/MENU-PC-Pho-Mai.png", "", "", "", null, "MENU-PC-Pho-Mai", null, null, null, null, 10, 5, 5, "", "" },
                    { "cf36b3c9-20b9-4cc6-81fd-efea1f940fc8", "11a7d74f-b20d-4212-8896-444ee3086b68", "MENU-PC-my", "/img/pizza-300x300/MENU-PC-my.png", "", "", "", null, "MENU-PC-my", null, null, null, null, 10, 5, 5, "", "" },
                    { "e7c811d0-d888-48b4-a3bc-fa8d820cfea6", "11a7d74f-b20d-4212-8896-444ee3086b68", "Meat-lover", "/img/pizza-300x300/Meat-lover.png", "", "", "", null, "Meat-lover", null, null, null, null, 10, 5, 5, "", "" },
                    { "9d5ad08d-1525-4716-8797-bb71cb3e6177", "11a7d74f-b20d-4212-8896-444ee3086b68", "Haft-haft", "/img/pizza-300x300/Haft-haft.png", "", "", "", null, "Haft-haft", null, null, null, null, 10, 5, 5, "", "" },
                    { "0e148aa9-0207-4136-b7dc-03e7a4ae5a2f", "11a7d74f-b20d-4212-8896-444ee3086b68", "Extravaganza", "/img/pizza-300x300/Extravaganza.png", "", "", "", null, "Extravaganza", null, null, null, null, 10, 5, 5, "", "" },
                    { "59c6ba30-9dd3-4caa-937b-5ddcfd9b3ae9", "275a8557-5e33-469d-aa8e-be1ea7660460", "pfanta-15", "/img/pizza-300x300/fanta-15.png", "", "", "", null, "fanta-1.5L", null, null, null, null, 10, 5, 5, "short 3", "" },
                    { "da6c31c7-d259-4f80-8b1b-c8d0e382cca6", "275a8557-5e33-469d-aa8e-be1ea7660460", "Sprite-15L", "/img/pizza-300x300/Sprite-15L.png", "", "", "", null, "Sprite-15L", null, null, null, null, 10, 5, 5, "", "" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "pic_CartId", "pic_ProductId", "pic_amount", "pic_color", "pic_size" },
                values: new object[] { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "a5d82765-5bcb-48e1-9e81-2b05cecd085f", 2, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactUsers",
                keyColumn: "cf_Id",
                keyValue: "8b00a3a2-689d-41c5-8b15-8b52d3a021d6");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "3b965bf1-7ee6-4e07-b31b-fe78abae05bd");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "be1b2e35-772a-466a-aba7-7b99d6166a6d");

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumns: new[] { "pic_CartId", "pic_ProductId" },
                keyValues: new object[] { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "a5d82765-5bcb-48e1-9e81-2b05cecd085f" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "0e148aa9-0207-4136-b7dc-03e7a4ae5a2f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "24eda427-0770-4a33-9481-312fe506a8f4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "355f5f8b-7482-4514-b886-ecb6beaaa36c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "3a58658e-c343-48e9-b399-50655e06b207");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "55715c42-679c-4d63-add6-b516c555597c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "59c6ba30-9dd3-4caa-937b-5ddcfd9b3ae9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "81b193b2-2f0a-406f-aeb1-9457f91b1f09");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "86640ca2-0bdc-4d73-af88-adfcc51ec2d5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "8f272d13-c87d-45a0-acae-612fc8a563d9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "9d5ad08d-1525-4716-8797-bb71cb3e6177");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "a6ebd0dd-0432-4af2-a6e8-b3b7a4a2d3b4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "af6caab0-8f60-4482-850e-07bc6c6a5bfd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "ba2648b0-aa60-4639-b298-ab17c82e6290");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "cf36b3c9-20b9-4cc6-81fd-efea1f940fc8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "d15ff6e8-55b9-49f0-8ef8-e090541e2431");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "da6c31c7-d259-4f80-8b1b-c8d0e382cca6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "e7c811d0-d888-48b4-a3bc-fa8d820cfea6");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "275a8557-5e33-469d-aa8e-be1ea7660460");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "988bd9f7-91ff-42a4-8966-ee6d2bcf8d62");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "f312bdee-521a-400e-8ad7-13025c4fda19");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "a5d82765-5bcb-48e1-9e81-2b05cecd085f");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "11a7d74f-b20d-4212-8896-444ee3086b68");

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
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "6eb3c297-7af9-4e53-9411-282c12ee32bb", "admin" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "d70f0079-bccb-4343-bf5d-15980bbd3c8c", "staff" });

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
    }
}
