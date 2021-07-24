using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketProj.DAL.Migrations
{
    public partial class dataSeed_UserProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("24eb8030-fe45-4de5-acb2-9ee48f696653"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("600ebb44-d93c-4d9e-b955-6b4ab0bd0bc3"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("67a2668d-37be-4c18-ab70-92c9aaca23ff"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("9cc3989b-083b-45e6-95c0-01462eb35e39"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("a05ee80d-1830-44db-b300-8fd1188ebbf0"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("f4c69ad7-fa7d-4f2e-88b1-db10990d02d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ed5281e-ec55-41d0-9d4b-01899a11bff5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8776cb0-c3a6-43f5-a024-01f11170feaf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3665ed66-c9be-4e7f-88c7-881fe37f5af2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7874d194-060f-4227-991b-ed4f7d6b9b98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b94f2e29-4699-4aa7-8da7-0b493acf11b0"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Clothes", "Color", "Date", "DiscountPercent", "DiscountPrice", "Gender", "Model", "Name", "Price", "Size" },
                values: new object[,]
                {
                    { new Guid("44a49261-e520-48e0-9b8f-32a3287ac366"), 0, "White", new DateTime(2020, 6, 15, 17, 2, 0, 22, DateTimeKind.Local).AddTicks(9469), 0.0, 0.0, 1, "Nike", "Buisnes Shirt", 20.0, 32.0 },
                    { new Guid("7d16bcaf-37ac-4e42-8619-38d9afd2e798"), 1, "Black", new DateTime(2020, 6, 15, 17, 2, 0, 26, DateTimeKind.Local).AddTicks(7342), 0.0, 0.0, 1, "Levis", "Buisnes Short", 25.0, 32.0 },
                    { new Guid("12173eb7-78c8-43ac-a171-6ff8ed5b6c23"), 2, "Black", new DateTime(2020, 6, 15, 17, 2, 0, 26, DateTimeKind.Local).AddTicks(7846), 0.0, 0.0, 2, "Adidas", "Sport Nice", 25.0, 32.0 },
                    { new Guid("5a0aefdb-46ae-4878-a539-0493a002fe51"), 3, "Blue", new DateTime(2020, 6, 15, 17, 2, 0, 26, DateTimeKind.Local).AddTicks(7865), 0.0, 0.0, 2, "Hugo", "Hat", 12.5, 32.0 },
                    { new Guid("f708dd0c-781a-420c-bd09-404e9210d0a8"), 3, "Blue", new DateTime(2020, 6, 15, 17, 2, 0, 26, DateTimeKind.Local).AddTicks(7901), 0.0, 0.0, 2, "Diamond", "Earrings Golden", 200.5, 32.0 }
                });

            migrationBuilder.InsertData(
                table: "UserProducts",
                columns: new[] { "Id", "ProductId", "UserId" },
                values: new object[,]
                {
                    { new Guid("cf566828-49bf-4393-9e9d-d23f565f05d4"), new Guid("44a49261-e520-48e0-9b8f-32a3287ac366"), new Guid("2e5e7149-2410-4997-a4b0-e634b36039a0") },
                    { new Guid("2f3a757f-8e79-47cf-ad10-10180a4e66e2"), new Guid("7d16bcaf-37ac-4e42-8619-38d9afd2e798"), new Guid("2e5e7149-2410-4997-a4b0-e634b36039a0") },
                    { new Guid("24b0ca82-9591-43f9-a2cc-5f63af50db1a"), new Guid("7d16bcaf-37ac-4e42-8619-38d9afd2e798"), new Guid("84a6eda2-2ba2-43ed-8006-b07de7403e3d") }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetsType", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("3ee552e1-0e61-4f3a-b084-4873c96766b3"), 0, new Guid("44a49261-e520-48e0-9b8f-32a3287ac366"), "https://www.llbeanbusiness.com/static/cms-img/classic-oxford-shirts-f19.jpg" },
                    { new Guid("2708b6af-05bd-4618-86b3-e78f07091960"), 0, new Guid("44a49261-e520-48e0-9b8f-32a3287ac366"), "https://images-na.ssl-images-amazon.com/images/I/61TWxMB8LFL._AC_UX679_.jpg" },
                    { new Guid("61a1ab98-8a02-475c-a747-4cb09ef1ac8f"), 0, new Guid("7d16bcaf-37ac-4e42-8619-38d9afd2e798"), "https://i.ebayimg.com/images/g/RgUAAOSwatBb8s0m/s-l1600.jpg" },
                    { new Guid("4df146d0-f08e-4e71-a29e-a015ba268ad2"), 0, new Guid("7d16bcaf-37ac-4e42-8619-38d9afd2e798"), "https://i.ebayimg.com/images/g/op0AAOSwhnlb8s0f/s-l1600.jpg" },
                    { new Guid("f5fc548f-603a-4caf-86b9-f82c7aaae219"), 0, new Guid("5a0aefdb-46ae-4878-a539-0493a002fe51"), "https://i.ebayimg.com/images/g/fkUAAOSwG4pctJCS/s-l1600.jpg" },
                    { new Guid("776926e0-d6b2-498c-9fe9-7d1b49426797"), 0, new Guid("5a0aefdb-46ae-4878-a539-0493a002fe51"), "https://i.ebayimg.com/images/g/fkUAAOSwG4pctJCS/s-l1600.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("2708b6af-05bd-4618-86b3-e78f07091960"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("3ee552e1-0e61-4f3a-b084-4873c96766b3"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("4df146d0-f08e-4e71-a29e-a015ba268ad2"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("61a1ab98-8a02-475c-a747-4cb09ef1ac8f"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("776926e0-d6b2-498c-9fe9-7d1b49426797"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("f5fc548f-603a-4caf-86b9-f82c7aaae219"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12173eb7-78c8-43ac-a171-6ff8ed5b6c23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f708dd0c-781a-420c-bd09-404e9210d0a8"));

            migrationBuilder.DeleteData(
                table: "UserProducts",
                keyColumn: "Id",
                keyValue: new Guid("24b0ca82-9591-43f9-a2cc-5f63af50db1a"));

            migrationBuilder.DeleteData(
                table: "UserProducts",
                keyColumn: "Id",
                keyValue: new Guid("2f3a757f-8e79-47cf-ad10-10180a4e66e2"));

            migrationBuilder.DeleteData(
                table: "UserProducts",
                keyColumn: "Id",
                keyValue: new Guid("cf566828-49bf-4393-9e9d-d23f565f05d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44a49261-e520-48e0-9b8f-32a3287ac366"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a0aefdb-46ae-4878-a539-0493a002fe51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d16bcaf-37ac-4e42-8619-38d9afd2e798"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Clothes", "Color", "Date", "DiscountPercent", "DiscountPrice", "Gender", "Model", "Name", "Price", "Size" },
                values: new object[,]
                {
                    { new Guid("b94f2e29-4699-4aa7-8da7-0b493acf11b0"), 0, "White", new DateTime(2020, 6, 15, 1, 54, 19, 279, DateTimeKind.Local).AddTicks(9735), 0.0, 0.0, 1, "Nike", "Buisnes Shirt", 20.0, 32.0 },
                    { new Guid("3665ed66-c9be-4e7f-88c7-881fe37f5af2"), 1, "Black", new DateTime(2020, 6, 15, 1, 54, 19, 282, DateTimeKind.Local).AddTicks(330), 0.0, 0.0, 1, "Levis", "Buisnes Short", 25.0, 32.0 },
                    { new Guid("9ed5281e-ec55-41d0-9d4b-01899a11bff5"), 2, "Black", new DateTime(2020, 6, 15, 1, 54, 19, 282, DateTimeKind.Local).AddTicks(542), 0.0, 0.0, 2, "Adidas", "Sport Nice", 25.0, 32.0 },
                    { new Guid("7874d194-060f-4227-991b-ed4f7d6b9b98"), 3, "Blue", new DateTime(2020, 6, 15, 1, 54, 19, 282, DateTimeKind.Local).AddTicks(550), 0.0, 0.0, 2, "Hugo", "Hat", 12.5, 32.0 },
                    { new Guid("e8776cb0-c3a6-43f5-a024-01f11170feaf"), 3, "Blue", new DateTime(2020, 6, 15, 1, 54, 19, 282, DateTimeKind.Local).AddTicks(556), 0.0, 0.0, 2, "Diamond", "Earrings Golden", 200.5, 32.0 }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetsType", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("a05ee80d-1830-44db-b300-8fd1188ebbf0"), 0, new Guid("b94f2e29-4699-4aa7-8da7-0b493acf11b0"), "https://www.llbeanbusiness.com/static/cms-img/classic-oxford-shirts-f19.jpg" },
                    { new Guid("67a2668d-37be-4c18-ab70-92c9aaca23ff"), 0, new Guid("b94f2e29-4699-4aa7-8da7-0b493acf11b0"), "https://images-na.ssl-images-amazon.com/images/I/61TWxMB8LFL._AC_UX679_.jpg" },
                    { new Guid("9cc3989b-083b-45e6-95c0-01462eb35e39"), 0, new Guid("3665ed66-c9be-4e7f-88c7-881fe37f5af2"), "https://i.ebayimg.com/images/g/RgUAAOSwatBb8s0m/s-l1600.jpg" },
                    { new Guid("600ebb44-d93c-4d9e-b955-6b4ab0bd0bc3"), 0, new Guid("3665ed66-c9be-4e7f-88c7-881fe37f5af2"), "https://i.ebayimg.com/images/g/op0AAOSwhnlb8s0f/s-l1600.jpg" },
                    { new Guid("f4c69ad7-fa7d-4f2e-88b1-db10990d02d2"), 0, new Guid("7874d194-060f-4227-991b-ed4f7d6b9b98"), "https://i.ebayimg.com/images/g/fkUAAOSwG4pctJCS/s-l1600.jpg" },
                    { new Guid("24eb8030-fe45-4de5-acb2-9ee48f696653"), 0, new Guid("7874d194-060f-4227-991b-ed4f7d6b9b98"), "https://i.ebayimg.com/images/g/fkUAAOSwG4pctJCS/s-l1600.jpg" }
                });
        }
    }
}
