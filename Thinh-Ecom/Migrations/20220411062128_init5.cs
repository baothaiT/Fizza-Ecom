using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thinh_Ecom.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactUsers",
                keyColumn: "cf_Id",
                keyValue: "29ae16da-a8ed-4b89-b601-7dc4cdaff3ec");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "2a5f8c1a-a574-41ca-b0fe-74d95c8fb432");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "8f9d5de6-da00-4fb9-aa26-ae3f153d9359");

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumns: new[] { "pic_CartId", "pic_ProductId" },
                keyValues: new object[] { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "281e1a4c-d815-420a-be53-6b376be94da4" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "0269b350-345a-42ba-95e2-dbaaf4cff7e6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "02b23ae9-25d1-4239-a3ed-24da76b961f1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "054f3fff-69b4-4ab2-8217-f8d524577221");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "182bd75d-7c4d-4f47-bc7e-0abd7ab22907");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "1f16d509-5b23-400d-b3ae-8b49330abbf9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "42905455-ae1b-4624-9f22-3696e39a242a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "4615b197-d478-4a7a-a5b9-858f0667a1b6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "4e10fefb-7798-422f-bdb1-1f85b2892656");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "558dff2a-87cf-4288-9719-25d511b1a8a5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "75648559-5c1f-4720-8e12-fc92bd4d0e9c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "7aa7b728-fae1-49cf-8971-f1cc430552f4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "a56e3d92-adde-41dc-8a10-79f5ef592147");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "a705c6d7-e279-4281-ac28-b1d529b98874");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "d199575d-999d-4946-81c2-df25558f3d1c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "ea9b471d-d22c-444a-8249-00f808660881");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "effc53d6-ff58-4bdd-b233-7e09e319b90c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "f7e351da-fe28-4bd8-860b-1c5330e787f7");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "9bbfafcf-55ca-49a7-85d4-846f0ad31c4f");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "ada4d7a8-6b5d-43f5-8dc7-4790eb8a79fc");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "f7eec5bd-a55b-4328-a646-f53fbbc3122c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "281e1a4c-d815-420a-be53-6b376be94da4");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "13ecd696-fa6f-4ab1-a521-ca0214b5ec3a");

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
                column: "ConcurrencyStamp",
                value: "5dcedaa7-8350-4951-876b-e5fec9d54cab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd",
                column: "ConcurrencyStamp",
                value: "0ca588f3-edb9-472d-9803-92222a6fb20a");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2022, 4, 11, 0, 46, 14, 541, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { "13ecd696-fa6f-4ab1-a521-ca0214b5ec3a", "Pizza", "", "" },
                    { "9bbfafcf-55ca-49a7-85d4-846f0ad31c4f", "Spaghetti", "", "" },
                    { "f7eec5bd-a55b-4328-a646-f53fbbc3122c", "Sidedishes", "", "" },
                    { "ada4d7a8-6b5d-43f5-8dc7-4790eb8a79fc", "Drink", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cf_Id", "cf_Description", "cf_Email", "cf_Name", "cf_Phone", "cf_Subject" },
                values: new object[] { "29ae16da-a8ed-4b89-b601-7dc4cdaff3ec", "Description", "Email", "Name", "0123456789", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "EndTime", "StartTime", "couponCode", "couponPrice", "coupon_AppUserFK" },
                values: new object[,]
                {
                    { "8f9d5de6-da00-4fb9-aa26-ae3f153d9359", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code10", 10, null },
                    { "2a5f8c1a-a574-41ca-b0fe-74d95c8fb432", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code50", 50, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "360E601E-92F2-4F08-832B-604A21293258",
                column: "ConcurrencyStamp",
                value: "19ef73e0-d4f2-4470-9f27-08394f10db49");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd",
                column: "ConcurrencyStamp",
                value: "3cf4de25-a94c-4310-a592-40b92c27e5fe");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "DE544998-A3CC-4E12-ABB4-0642E57BD222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2998412b-dd3c-4608-93c1-309acad6a437", "AQAAAAEAACcQAAAAEOlgqOcB0Uv0TQ1E/oA7KoQjGstjd8HCOxJLOE3EsFff/iO7KCuBOl85A8l/R5dw3w==", "1e11a7e6-b76b-4b94-a986-b0712c9cc0ca" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f12e155-a808-4e03-8006-d9f7c1f65210", "AQAAAAEAACcQAAAAEH8cTMLyvGLgH/anumsY7ATvr8i8JgvEcoV/CPvzk+zManbYBDj7mlgDcpYKDMgZeQ==", "9af42839-9d84-4411-a19d-c87e0aedc3c1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "CategoriesFK", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_MenuFacturer", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_Size" },
                values: new object[,]
                {
                    { "281e1a4c-d815-420a-be53-6b376be94da4", "13ecd696-fa6f-4ab1-a521-ca0214b5ec3a", "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "", "", "", null, "Pizza", null, null, null, null, 10, 5, 5, "short 1", "" },
                    { "42905455-ae1b-4624-9f22-3696e39a242a", "f7eec5bd-a55b-4328-a646-f53fbbc3122c", "MENU-PC", "/img/pizza-300x300/MENU-PC.png", "", "", "", null, "MENU-PC", null, null, null, null, 10, 5, 5, "", "" },
                    { "558dff2a-87cf-4288-9719-25d511b1a8a5", "9bbfafcf-55ca-49a7-85d4-846f0ad31c4f", "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "", "", "", null, "pizza-bo", null, null, null, null, 10, 5, 5, "", "" },
                    { "1f16d509-5b23-400d-b3ae-8b49330abbf9", "9bbfafcf-55ca-49a7-85d4-846f0ad31c4f", "Meat-lover", "/img/pizza-300x300/Meat-lover.png", "", "", "", null, "Meat-lover", null, null, null, null, 10, 5, 5, "", "" },
                    { "182bd75d-7c4d-4f47-bc7e-0abd7ab22907", "9bbfafcf-55ca-49a7-85d4-846f0ad31c4f", "Haft-haft", "/img/pizza-300x300/Haft-haft.png", "", "", "", null, "Haft-haft", null, null, null, null, 10, 5, 5, "", "" },
                    { "effc53d6-ff58-4bdd-b233-7e09e319b90c", "13ecd696-fa6f-4ab1-a521-ca0214b5ec3a", "pasta-rau-cu", "/img/pizza-300x300/pasta-rau-cu.png", "", "", "", null, "pasta-rau-cu", null, null, null, null, 10, 5, 5, "", "" },
                    { "75648559-5c1f-4720-8e12-fc92bd4d0e9c", "13ecd696-fa6f-4ab1-a521-ca0214b5ec3a", "pasta-hai-san", "/img/pizza-300x300/pasta-hai-san.png", "", "", "", null, "pasta-hai-san", null, null, null, null, 10, 5, 5, "", "" },
                    { "a56e3d92-adde-41dc-8a10-79f5ef592147", "13ecd696-fa6f-4ab1-a521-ca0214b5ec3a", "pasta-bo-bam", "/img/pizza-300x300/pasta-bo-bam.png", "", "", "", null, "pasta", null, null, null, null, 10, 5, 5, "", "" },
                    { "4615b197-d478-4a7a-a5b9-858f0667a1b6", "13ecd696-fa6f-4ab1-a521-ca0214b5ec3a", "Okonomiyaki", "/img/pizza-300x300/Okonomiyaki.png", "", "", "", null, "Okonomiyaki", null, null, null, null, 10, 5, 5, "", "" },
                    { "f7e351da-fe28-4bd8-860b-1c5330e787f7", "13ecd696-fa6f-4ab1-a521-ca0214b5ec3a", "Ocean-mania", "/img/pizza-300x300/Ocean-mania.png", "", "", "", null, "Ocean-mania", null, null, null, null, 10, 5, 5, "", "" },
                    { "ea9b471d-d22c-444a-8249-00f808660881", "13ecd696-fa6f-4ab1-a521-ca0214b5ec3a", "MENU-PC-Pho-Mai", "/img/pizza-300x300/MENU-PC-Pho-Mai.png", "", "", "", null, "MENU-PC-Pho-Mai", null, null, null, null, 10, 5, 5, "", "" },
                    { "7aa7b728-fae1-49cf-8971-f1cc430552f4", "13ecd696-fa6f-4ab1-a521-ca0214b5ec3a", "MENU-PC-my", "/img/pizza-300x300/MENU-PC-my.png", "", "", "", null, "MENU-PC-my", null, null, null, null, 10, 5, 5, "", "" },
                    { "0269b350-345a-42ba-95e2-dbaaf4cff7e6", "13ecd696-fa6f-4ab1-a521-ca0214b5ec3a", "MENU-PC-BBQ", "/img/pizza-300x300/MENU-PC-BBQ.png", "", "", "", null, "MENU-PC-BBQ", null, null, null, null, 10, 5, 5, "", "" },
                    { "4e10fefb-7798-422f-bdb1-1f85b2892656", "13ecd696-fa6f-4ab1-a521-ca0214b5ec3a", "pfanta-15", "/img/pizza-300x300/fanta-15.png", "", "", "", null, "fanta-1.5L", null, null, null, null, 10, 5, 5, "short 3", "" },
                    { "02b23ae9-25d1-4239-a3ed-24da76b961f1", "13ecd696-fa6f-4ab1-a521-ca0214b5ec3a", "Extravaganza", "/img/pizza-300x300/Extravaganza.png", "", "", "", null, "Extravaganza", null, null, null, null, 10, 5, 5, "", "" },
                    { "d199575d-999d-4946-81c2-df25558f3d1c", "13ecd696-fa6f-4ab1-a521-ca0214b5ec3a", "coca-zero", "/img/pizza-300x300/coca-zero.png", "", "", "", null, "Cocacola Zero", null, null, null, null, 10, 5, 5, "short 2", "" },
                    { "a705c6d7-e279-4281-ac28-b1d529b98874", "f7eec5bd-a55b-4328-a646-f53fbbc3122c", "Pizzaminsea", "/img/pizza-300x300/Pizzaminsea.png", "", "", "", null, "Pizzaminsea", null, null, null, null, 10, 5, 5, "", "" },
                    { "054f3fff-69b4-4ab2-8217-f8d524577221", "ada4d7a8-6b5d-43f5-8dc7-4790eb8a79fc", "Sprite-15L", "/img/pizza-300x300/Sprite-15L.png", "", "", "", null, "Sprite-15L", null, null, null, null, 10, 5, 5, "", "" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "pic_CartId", "pic_ProductId", "pic_amount", "pic_color", "pic_size" },
                values: new object[] { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "281e1a4c-d815-420a-be53-6b376be94da4", 2, null, null });
        }
    }
}
