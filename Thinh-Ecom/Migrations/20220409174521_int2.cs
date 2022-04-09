using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thinh_Ecom.Migrations
{
    public partial class int2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactUsers",
                keyColumn: "cf_Id",
                keyValue: "e56ab218-02b1-42fa-8c37-96e208ead92f");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "03e04bb0-9a6c-45dc-9816-1ab62645cad0");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "6fb0b6ab-0f11-4430-98f1-8546cd110afe");

            migrationBuilder.DeleteData(
                table: "ProductInCart",
                keyColumns: new[] { "pic_CartId", "pic_ProductId" },
                keyValues: new object[] { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "30ae57c0-fa17-4593-8c0b-9dfead70e397" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "08d481bf-82e2-493f-abdc-963efd4e513e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "2c26047f-a2e9-4b79-9cad-adb28a7058e1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "3345f7a6-ee6f-4f2f-8fb9-c1fb63f9aaac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "388af5b7-1558-4001-a237-611edd60b2a0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "519d2aa4-4bba-468d-afef-7905f370fe82");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "55c9e49b-785b-4a2a-a905-f4a3a0f33f3b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "678bda1a-3275-44dc-9d75-281a075b28cf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "6d74282e-010a-4b64-b8ee-184a5f2c556c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "6e54d7e0-8b44-4962-abbb-d6febe26d056");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "96cb5989-6229-4e4c-b065-cd53e69b3e76");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "a65ba8bf-35aa-488e-9472-f347e9ca538d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "c95f8967-d319-43fb-9b1c-58809c5f8e71");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "ce2b460c-16fe-4468-81f9-ce0dfd38f7db");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "d30973e5-b046-40ac-919a-710b609df8d9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "e387e71c-e433-43d5-99bc-00747b13c850");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "e8e47b5a-c595-4fa6-8489-75ef927f9f3c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "f5934811-4d3d-4c90-bbd4-fa9ecca478bc");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "4bce01c4-3313-49f1-8bc8-c54d95366513");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "805b7f02-cf9a-4af1-a533-42f9a2c9a4a7");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "ceef6e1d-5ff9-4992-a7f8-cc90656b8e78");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "30ae57c0-fa17-4593-8c0b-9dfead70e397");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "89b799fd-89ee-45ce-b803-f4f87a6b9b61");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "D269BF93-A5E2-4C4A-8146-9967DDE80D30",
                column: "bill_DatetimeOrder",
                value: new DateTime(2022, 4, 7, 5, 26, 9, 302, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { "89b799fd-89ee-45ce-b803-f4f87a6b9b61", "Pizza", "", "" },
                    { "ceef6e1d-5ff9-4992-a7f8-cc90656b8e78", "Spaghetti", "", "" },
                    { "4bce01c4-3313-49f1-8bc8-c54d95366513", "Sidedishes", "", "" },
                    { "805b7f02-cf9a-4af1-a533-42f9a2c9a4a7", "Drink", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cf_Id", "cf_Description", "cf_Email", "cf_Name", "cf_Phone", "cf_Subject" },
                values: new object[] { "e56ab218-02b1-42fa-8c37-96e208ead92f", "Description", "Email", "Name", "0123456789", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "EndTime", "StartTime", "couponCode", "couponPrice", "coupon_AppUserFK" },
                values: new object[,]
                {
                    { "6fb0b6ab-0f11-4430-98f1-8546cd110afe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code10", 10, null },
                    { "03e04bb0-9a6c-45dc-9816-1ab62645cad0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "code50", 50, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "360E601E-92F2-4F08-832B-604A21293258",
                column: "ConcurrencyStamp",
                value: "bb6228cd-165f-4d46-adf6-263223979e6c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd",
                column: "ConcurrencyStamp",
                value: "73e7483a-dac0-4e67-af33-8d9cbfde6828");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "DE544998-A3CC-4E12-ABB4-0642E57BD222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5dd49c13-db5f-4a78-b51a-74e6a1f917bc", "AQAAAAEAACcQAAAAEIb8Zy6keY4jS3GOcv0bgXkiKK6lbmYSglC/quzdDa2/6lJ2Hdjv2secEA+9nqcULQ==", "e8531444-1aa2-49f7-ae67-f0561414f61f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1915b628-e408-4120-811f-2af6ed8d9328", "AQAAAAEAACcQAAAAEBn98r7PevyE6CiVLc3VFp2CIG2sHchT+7uJI8D/AUEQD4k3vOP2mPlzq9ZXyP4UiQ==", "7c209abe-7c5f-47b4-9a16-cac9f193de4d" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "CategoriesFK", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_MenuFacturer", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_Size" },
                values: new object[,]
                {
                    { "30ae57c0-fa17-4593-8c0b-9dfead70e397", "89b799fd-89ee-45ce-b803-f4f87a6b9b61", "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "", "", "", null, "Pizza", null, null, null, null, 10, 5, 5, "", "" },
                    { "6e54d7e0-8b44-4962-abbb-d6febe26d056", "4bce01c4-3313-49f1-8bc8-c54d95366513", "MENU-PC", "/img/pizza-300x300/MENU-PC.png", "", "", "", null, "MENU-PC", null, null, null, null, 10, 5, 5, "", "" },
                    { "6d74282e-010a-4b64-b8ee-184a5f2c556c", "ceef6e1d-5ff9-4992-a7f8-cc90656b8e78", "pizza-bo", "/img/pizza-300x300/pizza-bo.png", "", "", "", null, "pizza-bo", null, null, null, null, 10, 5, 5, "", "" },
                    { "55c9e49b-785b-4a2a-a905-f4a3a0f33f3b", "ceef6e1d-5ff9-4992-a7f8-cc90656b8e78", "Meat-lover", "/img/pizza-300x300/Meat-lover.png", "", "", "", null, "Meat-lover", null, null, null, null, 10, 5, 5, "", "" },
                    { "c95f8967-d319-43fb-9b1c-58809c5f8e71", "ceef6e1d-5ff9-4992-a7f8-cc90656b8e78", "Haft-haft", "/img/pizza-300x300/Haft-haft.png", "", "", "", null, "Haft-haft", null, null, null, null, 10, 5, 5, "", "" },
                    { "519d2aa4-4bba-468d-afef-7905f370fe82", "89b799fd-89ee-45ce-b803-f4f87a6b9b61", "pasta-rau-cu", "/img/pizza-300x300/pasta-rau-cu.png", "", "", "", null, "pasta-rau-cu", null, null, null, null, 10, 5, 5, "", "" },
                    { "d30973e5-b046-40ac-919a-710b609df8d9", "89b799fd-89ee-45ce-b803-f4f87a6b9b61", "pasta-hai-san", "/img/pizza-300x300/pasta-hai-san.png", "", "", "", null, "pasta-hai-san", null, null, null, null, 10, 5, 5, "", "" },
                    { "f5934811-4d3d-4c90-bbd4-fa9ecca478bc", "89b799fd-89ee-45ce-b803-f4f87a6b9b61", "pasta-bo-bam", "/img/pizza-300x300/pasta-bo-bam.png", "", "", "", null, "pasta", null, null, null, null, 10, 5, 5, "", "" },
                    { "08d481bf-82e2-493f-abdc-963efd4e513e", "89b799fd-89ee-45ce-b803-f4f87a6b9b61", "Okonomiyaki", "/img/pizza-300x300/Okonomiyaki.png", "", "", "", null, "Okonomiyaki", null, null, null, null, 10, 5, 5, "", "" },
                    { "678bda1a-3275-44dc-9d75-281a075b28cf", "89b799fd-89ee-45ce-b803-f4f87a6b9b61", "Ocean-mania", "/img/pizza-300x300/Ocean-mania.png", "", "", "", null, "Ocean-mania", null, null, null, null, 10, 5, 5, "", "" },
                    { "a65ba8bf-35aa-488e-9472-f347e9ca538d", "89b799fd-89ee-45ce-b803-f4f87a6b9b61", "MENU-PC-Pho-Mai", "/img/pizza-300x300/MENU-PC-Pho-Mai.png", "", "", "", null, "MENU-PC-Pho-Mai", null, null, null, null, 10, 5, 5, "", "" },
                    { "96cb5989-6229-4e4c-b065-cd53e69b3e76", "89b799fd-89ee-45ce-b803-f4f87a6b9b61", "MENU-PC-my", "/img/pizza-300x300/MENU-PC-my.png", "", "", "", null, "MENU-PC-my", null, null, null, null, 10, 5, 5, "", "" },
                    { "ce2b460c-16fe-4468-81f9-ce0dfd38f7db", "89b799fd-89ee-45ce-b803-f4f87a6b9b61", "MENU-PC-BBQ", "/img/pizza-300x300/MENU-PC-BBQ.png", "", "", "", null, "MENU-PC-BBQ", null, null, null, null, 10, 5, 5, "", "" },
                    { "e8e47b5a-c595-4fa6-8489-75ef927f9f3c", "89b799fd-89ee-45ce-b803-f4f87a6b9b61", "pfanta-15", "/img/pizza-300x300/fanta-15.png", "", "", "", null, "fanta-1.5L", null, null, null, null, 10, 5, 5, "", "" },
                    { "388af5b7-1558-4001-a237-611edd60b2a0", "89b799fd-89ee-45ce-b803-f4f87a6b9b61", "Extravaganza", "/img/pizza-300x300/Extravaganza.png", "", "", "", null, "Extravaganza", null, null, null, null, 10, 5, 5, "", "" },
                    { "3345f7a6-ee6f-4f2f-8fb9-c1fb63f9aaac", "89b799fd-89ee-45ce-b803-f4f87a6b9b61", "coca-zero", "/img/pizza-300x300/coca-zero.png", "", "", "", null, "Cocacola Zero", null, null, null, null, 10, 5, 5, "", "" },
                    { "2c26047f-a2e9-4b79-9cad-adb28a7058e1", "4bce01c4-3313-49f1-8bc8-c54d95366513", "Pizzaminsea", "/img/pizza-300x300/Pizzaminsea.png", "", "", "", null, "Pizzaminsea", null, null, null, null, 10, 5, 5, "", "" },
                    { "e387e71c-e433-43d5-99bc-00747b13c850", "805b7f02-cf9a-4af1-a533-42f9a2c9a4a7", "Sprite-15L", "/img/pizza-300x300/Sprite-15L.png", "", "", "", null, "Sprite-15L", null, null, null, null, 10, 5, 5, "", "" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "pic_CartId", "pic_ProductId", "pic_amount", "pic_color", "pic_size" },
                values: new object[] { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "30ae57c0-fa17-4593-8c0b-9dfead70e397", 2, null, null });
        }
    }
}
