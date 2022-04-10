using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thinh_Ecom.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactUsers",
                keyColumn: "cf_Id",
                keyValue: "d3c0c7f9-e42a-4f54-bc1b-700eb3671736");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "39cddbed-5b28-40fa-82c0-23c1fbbbae81");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "eeba2606-a0c5-4115-97fb-7422793054ce");

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumns: new[] { "pic_CartId", "pic_ProductId" },
                keyValues: new object[] { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "39e09197-0b50-4fbb-9535-35188b07733b" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "0db60636-640d-4f7c-9199-f7d2d4f40562");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "11d9d8d6-ad8e-40bb-8a3f-4f04f7837860");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "354e5b23-70cf-44d5-9c76-b755a3a59d7e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "3aa9c686-b077-4c8d-9655-38561abbdc3f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "41954671-db97-4e4f-9fce-45fe0a2e9142");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "4b3e811f-be28-4538-a314-2d5fe816afa1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "4c156902-ceb8-4097-b906-cd3a7bdcaa77");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "5751f872-4bac-4045-b371-8688e04c4317");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "6359b7c9-1bd8-467d-842c-24bd8416e99c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "63d8a3f3-57b9-49b5-860c-7f608e4dfdb0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "6790954b-34ce-4dc4-a658-5c768b4a1df4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "71d336f3-aeef-48f7-b5d2-b07c73281d57");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "86db3b5b-9448-435e-a47a-c4c44c456eb5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "8e2537d8-9072-478d-afe3-d6df2fc6efba");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "981734f8-4203-421e-b176-125dc7254329");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "c66679b2-8235-4672-8418-47be10226b20");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "d5e4a170-b154-4dc3-b89a-4cdf9465e583");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "08ba11e6-becb-4d9b-94cb-f1c24c856f29");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "6b0abe7b-1623-4556-a2a5-58d13374f273");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "968fd1ed-175e-44de-8933-ee693d99c2cf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "39e09197-0b50-4fbb-9535-35188b07733b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "56a31666-0918-41a0-9fda-27c975a48fcb");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailGuest");

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
                value: new DateTime(2022, 4, 10, 17, 25, 36, 228, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { "56a31666-0918-41a0-9fda-27c975a48fcb", "Pizza", "", "" },
                    { "08ba11e6-becb-4d9b-94cb-f1c24c856f29", "Spaghetti", "", "" },
                    { "6b0abe7b-1623-4556-a2a5-58d13374f273", "Sidedishes", "", "" },
                    { "968fd1ed-175e-44de-8933-ee693d99c2cf", "Drink", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cf_Id", "cf_Description", "cf_Email", "cf_Name", "cf_Phone", "cf_Subject" },
                values: new object[] { "d3c0c7f9-e42a-4f54-bc1b-700eb3671736", "Description", "Email", "Name", "0123456789", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "EndTime", "StartTime", "couponCode", "couponPrice", "coupon_AppUserFK" },
                values: new object[,]
                {
                    { "eeba2606-a0c5-4115-97fb-7422793054ce", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code10", 10, null },
                    { "39cddbed-5b28-40fa-82c0-23c1fbbbae81", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code50", 50, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "360E601E-92F2-4F08-832B-604A21293258",
                column: "ConcurrencyStamp",
                value: "ef496c2a-bbc3-4d5e-a4d9-ac523922ad53");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd",
                column: "ConcurrencyStamp",
                value: "4aaa69e3-6ffe-4a0e-8bec-679b1d3970a9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "DE544998-A3CC-4E12-ABB4-0642E57BD222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71bffca9-0f6b-4826-964c-b85a5931e7f2", "AQAAAAEAACcQAAAAEHcihIfTLFPc4EdSgUKoLC0ncLLPYk2bvLe1IXRRGppcF9YhzCTYib+DeCIK42PyiQ==", "31d51914-793a-4619-affb-00bfb043bf17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1b40ac5-0b08-4d0c-997f-3ae07a815760", "AQAAAAEAACcQAAAAEBZdMGHnd9y2GYmgR26dOt0R0AcHMl3WBNn6WRGNQ/ANrc7DjrlWhZ1hDh7BAImrsA==", "fdeb0bce-dd5a-48a9-9db4-16e653c69fc6" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "CategoriesFK", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_MenuFacturer", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_Size" },
                values: new object[,]
                {
                    { "39e09197-0b50-4fbb-9535-35188b07733b", "56a31666-0918-41a0-9fda-27c975a48fcb", "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "", "", "", null, "Pizza", null, null, null, null, 10, 5, 5, "", "" },
                    { "d5e4a170-b154-4dc3-b89a-4cdf9465e583", "6b0abe7b-1623-4556-a2a5-58d13374f273", "MENU-PC", "/img/pizza-300x300/MENU-PC.png", "", "", "", null, "MENU-PC", null, null, null, null, 10, 5, 5, "", "" },
                    { "6790954b-34ce-4dc4-a658-5c768b4a1df4", "08ba11e6-becb-4d9b-94cb-f1c24c856f29", "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "", "", "", null, "pizza-bo", null, null, null, null, 10, 5, 5, "", "" },
                    { "71d336f3-aeef-48f7-b5d2-b07c73281d57", "08ba11e6-becb-4d9b-94cb-f1c24c856f29", "Meat-lover", "/img/pizza-300x300/Meat-lover.png", "", "", "", null, "Meat-lover", null, null, null, null, 10, 5, 5, "", "" },
                    { "41954671-db97-4e4f-9fce-45fe0a2e9142", "08ba11e6-becb-4d9b-94cb-f1c24c856f29", "Haft-haft", "/img/pizza-300x300/Haft-haft.png", "", "", "", null, "Haft-haft", null, null, null, null, 10, 5, 5, "", "" },
                    { "86db3b5b-9448-435e-a47a-c4c44c456eb5", "56a31666-0918-41a0-9fda-27c975a48fcb", "pasta-rau-cu", "/img/pizza-300x300/pasta-rau-cu.png", "", "", "", null, "pasta-rau-cu", null, null, null, null, 10, 5, 5, "", "" },
                    { "5751f872-4bac-4045-b371-8688e04c4317", "56a31666-0918-41a0-9fda-27c975a48fcb", "pasta-hai-san", "/img/pizza-300x300/pasta-hai-san.png", "", "", "", null, "pasta-hai-san", null, null, null, null, 10, 5, 5, "", "" },
                    { "8e2537d8-9072-478d-afe3-d6df2fc6efba", "56a31666-0918-41a0-9fda-27c975a48fcb", "pasta-bo-bam", "/img/pizza-300x300/pasta-bo-bam.png", "", "", "", null, "pasta", null, null, null, null, 10, 5, 5, "", "" },
                    { "4b3e811f-be28-4538-a314-2d5fe816afa1", "56a31666-0918-41a0-9fda-27c975a48fcb", "Okonomiyaki", "/img/pizza-300x300/Okonomiyaki.png", "", "", "", null, "Okonomiyaki", null, null, null, null, 10, 5, 5, "", "" },
                    { "63d8a3f3-57b9-49b5-860c-7f608e4dfdb0", "56a31666-0918-41a0-9fda-27c975a48fcb", "Ocean-mania", "/img/pizza-300x300/Ocean-mania.png", "", "", "", null, "Ocean-mania", null, null, null, null, 10, 5, 5, "", "" },
                    { "354e5b23-70cf-44d5-9c76-b755a3a59d7e", "56a31666-0918-41a0-9fda-27c975a48fcb", "MENU-PC-Pho-Mai", "/img/pizza-300x300/MENU-PC-Pho-Mai.png", "", "", "", null, "MENU-PC-Pho-Mai", null, null, null, null, 10, 5, 5, "", "" },
                    { "c66679b2-8235-4672-8418-47be10226b20", "56a31666-0918-41a0-9fda-27c975a48fcb", "MENU-PC-my", "/img/pizza-300x300/MENU-PC-my.png", "", "", "", null, "MENU-PC-my", null, null, null, null, 10, 5, 5, "", "" },
                    { "0db60636-640d-4f7c-9199-f7d2d4f40562", "56a31666-0918-41a0-9fda-27c975a48fcb", "MENU-PC-BBQ", "/img/pizza-300x300/MENU-PC-BBQ.png", "", "", "", null, "MENU-PC-BBQ", null, null, null, null, 10, 5, 5, "", "" },
                    { "6359b7c9-1bd8-467d-842c-24bd8416e99c", "56a31666-0918-41a0-9fda-27c975a48fcb", "pfanta-15", "/img/pizza-300x300/fanta-15.png", "", "", "", null, "fanta-1.5L", null, null, null, null, 10, 5, 5, "", "" },
                    { "981734f8-4203-421e-b176-125dc7254329", "56a31666-0918-41a0-9fda-27c975a48fcb", "Extravaganza", "/img/pizza-300x300/Extravaganza.png", "", "", "", null, "Extravaganza", null, null, null, null, 10, 5, 5, "", "" },
                    { "3aa9c686-b077-4c8d-9655-38561abbdc3f", "56a31666-0918-41a0-9fda-27c975a48fcb", "coca-zero", "/img/pizza-300x300/coca-zero.png", "", "", "", null, "Cocacola Zero", null, null, null, null, 10, 5, 5, "", "" },
                    { "4c156902-ceb8-4097-b906-cd3a7bdcaa77", "6b0abe7b-1623-4556-a2a5-58d13374f273", "Pizzaminsea", "/img/pizza-300x300/Pizzaminsea.png", "", "", "", null, "Pizzaminsea", null, null, null, null, 10, 5, 5, "", "" },
                    { "11d9d8d6-ad8e-40bb-8a3f-4f04f7837860", "968fd1ed-175e-44de-8933-ee693d99c2cf", "Sprite-15L", "/img/pizza-300x300/Sprite-15L.png", "", "", "", null, "Sprite-15L", null, null, null, null, 10, 5, 5, "", "" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "pic_CartId", "pic_ProductId", "pic_amount", "pic_color", "pic_size" },
                values: new object[] { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "39e09197-0b50-4fbb-9535-35188b07733b", 2, null, null });
        }
    }
}
