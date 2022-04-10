using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thinh_Ecom.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactUsers",
                keyColumn: "cf_Id",
                keyValue: "993703f8-121c-4065-89be-b01d116d036e");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "16f6ad16-75ce-4238-9563-0552f04b39e8");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "48fdd6ac-5248-4e74-a810-ca6596c8cd80");

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumns: new[] { "pic_CartId", "pic_ProductId" },
                keyValues: new object[] { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "3eaa8ca4-5848-495b-8495-0803c7026e74" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "164c9881-9fde-4d8e-a85f-b62b33c8d547");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "1ae97a72-776e-43cb-8d40-fbe4341a2809");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "276fab79-7116-48a8-b267-5bea44b68a6a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "2d407846-3cb7-41b1-95dd-5f799410f954");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "3f430657-d1b6-464b-b262-79eefe649231");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "5c991382-361f-4d42-b457-694550b308a9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "7f29e51a-1d97-4e6f-8131-78b5d5267eae");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "9c2004cb-6706-46a0-bb1b-11714fad828b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "a1a4c9fc-cb31-49ce-a77c-9c2de8229595");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "a6e2cf9d-5201-4e61-aa9e-c15c34eb36a4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "ad084f25-2f1d-4fc9-bd2a-6e327ae55343");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "b7c64d44-96f5-4946-a481-9b9cd9e93ff2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "c53ddb67-9eed-4370-9492-5e19a735689a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "d34af6fb-a6d5-4db2-b8b7-91bdead1391b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "dcf0d1e4-622b-4965-8131-774de3a2e98f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "e117bd96-c37d-4dd3-a8cc-8d9c4ee4df3f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "f5e3dcdf-b5bc-4b3b-9315-fb4199815a79");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "48b74036-7649-4582-b4b4-54ec64aff8bb");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "6b79689f-d714-4ab9-9bec-d57dbaf1bbd2");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "e2c21fb1-fee7-48c4-a107-05147b1c7a06");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "3eaa8ca4-5848-495b-8495-0803c7026e74");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "7767aa8b-b2cd-4c19-ae80-777f5f6622c3");

            migrationBuilder.DropColumn(
                name: "bill_Cancelled",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "bill_Delivered",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "bill_Delivering",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "bill_WaitPickup",
                table: "Bills");

            migrationBuilder.RenameColumn(
                name: "bill_Quantity",
                table: "Bills",
                newName: "bill_QuantityList");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "bill_QuantityList",
                table: "Bills",
                newName: "bill_Quantity");

            migrationBuilder.AddColumn<bool>(
                name: "bill_Cancelled",
                table: "Bills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bill_Delivered",
                table: "Bills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bill_Delivering",
                table: "Bills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bill_WaitPickup",
                table: "Bills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "D269BF93-A5E2-4C4A-8146-9967DDE80D30",
                column: "bill_DatetimeOrder",
                value: new DateTime(2022, 4, 10, 0, 45, 20, 293, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { "7767aa8b-b2cd-4c19-ae80-777f5f6622c3", "Pizza", "", "" },
                    { "48b74036-7649-4582-b4b4-54ec64aff8bb", "Spaghetti", "", "" },
                    { "6b79689f-d714-4ab9-9bec-d57dbaf1bbd2", "Sidedishes", "", "" },
                    { "e2c21fb1-fee7-48c4-a107-05147b1c7a06", "Drink", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cf_Id", "cf_Description", "cf_Email", "cf_Name", "cf_Phone", "cf_Subject" },
                values: new object[] { "993703f8-121c-4065-89be-b01d116d036e", "Description", "Email", "Name", "0123456789", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "EndTime", "StartTime", "couponCode", "couponPrice", "coupon_AppUserFK" },
                values: new object[,]
                {
                    { "48fdd6ac-5248-4e74-a810-ca6596c8cd80", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code10", 10, null },
                    { "16f6ad16-75ce-4238-9563-0552f04b39e8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code50", 50, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "360E601E-92F2-4F08-832B-604A21293258",
                column: "ConcurrencyStamp",
                value: "4d37590b-d53c-4346-be85-0f9b7552e294");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd",
                column: "ConcurrencyStamp",
                value: "cb79e001-6d69-44d8-a42d-eabcac4b2201");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "DE544998-A3CC-4E12-ABB4-0642E57BD222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d413dfec-0cd5-4b13-9b17-496ecdc9018c", "AQAAAAEAACcQAAAAEME9ts1eXh6lnvT3rTku8elaX0J/F83QYnthMMcLbqzSQQq3s/gGzZaHNywWaw4A/Q==", "4a1b7667-82e5-41f4-90fd-e04279025955" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9712a4a-4af1-4a8e-b82d-3017706a8e36", "AQAAAAEAACcQAAAAEIMLSTshSHm52ElRcZwZzrJkeDLQnYfMPjmIeWAIBBJIeaOIrD0DsyvRJ88DPTD0sg==", "b07f5e2e-fdd5-494f-8ade-b6bedb7784c2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "CategoriesFK", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_MenuFacturer", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_Size" },
                values: new object[,]
                {
                    { "3eaa8ca4-5848-495b-8495-0803c7026e74", "7767aa8b-b2cd-4c19-ae80-777f5f6622c3", "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "", "", "", null, "Pizza", null, null, null, null, 10, 5, 5, "", "" },
                    { "276fab79-7116-48a8-b267-5bea44b68a6a", "6b79689f-d714-4ab9-9bec-d57dbaf1bbd2", "MENU-PC", "/img/pizza-300x300/MENU-PC.png", "", "", "", null, "MENU-PC", null, null, null, null, 10, 5, 5, "", "" },
                    { "e117bd96-c37d-4dd3-a8cc-8d9c4ee4df3f", "48b74036-7649-4582-b4b4-54ec64aff8bb", "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "", "", "", null, "pizza-bo", null, null, null, null, 10, 5, 5, "", "" },
                    { "2d407846-3cb7-41b1-95dd-5f799410f954", "48b74036-7649-4582-b4b4-54ec64aff8bb", "Meat-lover", "/img/pizza-300x300/Meat-lover.png", "", "", "", null, "Meat-lover", null, null, null, null, 10, 5, 5, "", "" },
                    { "a1a4c9fc-cb31-49ce-a77c-9c2de8229595", "48b74036-7649-4582-b4b4-54ec64aff8bb", "Haft-haft", "/img/pizza-300x300/Haft-haft.png", "", "", "", null, "Haft-haft", null, null, null, null, 10, 5, 5, "", "" },
                    { "a6e2cf9d-5201-4e61-aa9e-c15c34eb36a4", "7767aa8b-b2cd-4c19-ae80-777f5f6622c3", "pasta-rau-cu", "/img/pizza-300x300/pasta-rau-cu.png", "", "", "", null, "pasta-rau-cu", null, null, null, null, 10, 5, 5, "", "" },
                    { "7f29e51a-1d97-4e6f-8131-78b5d5267eae", "7767aa8b-b2cd-4c19-ae80-777f5f6622c3", "pasta-hai-san", "/img/pizza-300x300/pasta-hai-san.png", "", "", "", null, "pasta-hai-san", null, null, null, null, 10, 5, 5, "", "" },
                    { "b7c64d44-96f5-4946-a481-9b9cd9e93ff2", "7767aa8b-b2cd-4c19-ae80-777f5f6622c3", "pasta-bo-bam", "/img/pizza-300x300/pasta-bo-bam.png", "", "", "", null, "pasta", null, null, null, null, 10, 5, 5, "", "" },
                    { "c53ddb67-9eed-4370-9492-5e19a735689a", "7767aa8b-b2cd-4c19-ae80-777f5f6622c3", "Okonomiyaki", "/img/pizza-300x300/Okonomiyaki.png", "", "", "", null, "Okonomiyaki", null, null, null, null, 10, 5, 5, "", "" },
                    { "1ae97a72-776e-43cb-8d40-fbe4341a2809", "7767aa8b-b2cd-4c19-ae80-777f5f6622c3", "Ocean-mania", "/img/pizza-300x300/Ocean-mania.png", "", "", "", null, "Ocean-mania", null, null, null, null, 10, 5, 5, "", "" },
                    { "164c9881-9fde-4d8e-a85f-b62b33c8d547", "7767aa8b-b2cd-4c19-ae80-777f5f6622c3", "MENU-PC-Pho-Mai", "/img/pizza-300x300/MENU-PC-Pho-Mai.png", "", "", "", null, "MENU-PC-Pho-Mai", null, null, null, null, 10, 5, 5, "", "" },
                    { "3f430657-d1b6-464b-b262-79eefe649231", "7767aa8b-b2cd-4c19-ae80-777f5f6622c3", "MENU-PC-my", "/img/pizza-300x300/MENU-PC-my.png", "", "", "", null, "MENU-PC-my", null, null, null, null, 10, 5, 5, "", "" },
                    { "f5e3dcdf-b5bc-4b3b-9315-fb4199815a79", "7767aa8b-b2cd-4c19-ae80-777f5f6622c3", "MENU-PC-BBQ", "/img/pizza-300x300/MENU-PC-BBQ.png", "", "", "", null, "MENU-PC-BBQ", null, null, null, null, 10, 5, 5, "", "" },
                    { "d34af6fb-a6d5-4db2-b8b7-91bdead1391b", "7767aa8b-b2cd-4c19-ae80-777f5f6622c3", "pfanta-15", "/img/pizza-300x300/fanta-15.png", "", "", "", null, "fanta-1.5L", null, null, null, null, 10, 5, 5, "", "" },
                    { "dcf0d1e4-622b-4965-8131-774de3a2e98f", "7767aa8b-b2cd-4c19-ae80-777f5f6622c3", "Extravaganza", "/img/pizza-300x300/Extravaganza.png", "", "", "", null, "Extravaganza", null, null, null, null, 10, 5, 5, "", "" },
                    { "5c991382-361f-4d42-b457-694550b308a9", "7767aa8b-b2cd-4c19-ae80-777f5f6622c3", "coca-zero", "/img/pizza-300x300/coca-zero.png", "", "", "", null, "Cocacola Zero", null, null, null, null, 10, 5, 5, "", "" },
                    { "9c2004cb-6706-46a0-bb1b-11714fad828b", "6b79689f-d714-4ab9-9bec-d57dbaf1bbd2", "Pizzaminsea", "/img/pizza-300x300/Pizzaminsea.png", "", "", "", null, "Pizzaminsea", null, null, null, null, 10, 5, 5, "", "" },
                    { "ad084f25-2f1d-4fc9-bd2a-6e327ae55343", "e2c21fb1-fee7-48c4-a107-05147b1c7a06", "Sprite-15L", "/img/pizza-300x300/Sprite-15L.png", "", "", "", null, "Sprite-15L", null, null, null, null, 10, 5, 5, "", "" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "pic_CartId", "pic_ProductId", "pic_amount", "pic_color", "pic_size" },
                values: new object[] { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "3eaa8ca4-5848-495b-8495-0803c7026e74", 2, null, null });
        }
    }
}
