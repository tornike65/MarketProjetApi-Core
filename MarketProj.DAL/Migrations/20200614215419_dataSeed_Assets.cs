using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketProj.DAL.Migrations
{
    public partial class dataSeed_Assets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("04b28c9b-0944-4b34-a933-410e2f265f1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e1e4375-43fc-4c82-9ebd-63f8e916af3b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75f79c22-4141-43d5-a619-3efdef1feae6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e04b5142-e8cf-436f-86b1-ff35243306cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7acc7af-3c20-483d-a235-55a6938b7643"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("04b28c9b-0944-4b34-a933-410e2f265f1e"), 0, "White", new DateTime(2020, 6, 15, 1, 24, 29, 926, DateTimeKind.Local).AddTicks(3288), 0.0, 0.0, 1, "Nike", "Buisnes Shirt", 20.0, 32.0 },
                    { new Guid("e04b5142-e8cf-436f-86b1-ff35243306cf"), 1, "Black", new DateTime(2020, 6, 15, 1, 24, 29, 928, DateTimeKind.Local).AddTicks(4939), 0.0, 0.0, 1, "Levis", "Buisnes Short", 25.0, 32.0 },
                    { new Guid("2e1e4375-43fc-4c82-9ebd-63f8e916af3b"), 2, "Black", new DateTime(2020, 6, 15, 1, 24, 29, 928, DateTimeKind.Local).AddTicks(5151), 0.0, 0.0, 2, "Adidas", "Sport Nice", 25.0, 32.0 },
                    { new Guid("f7acc7af-3c20-483d-a235-55a6938b7643"), 3, "Blue", new DateTime(2020, 6, 15, 1, 24, 29, 928, DateTimeKind.Local).AddTicks(5172), 0.0, 0.0, 2, "Hugo", "Hat", 12.5, 32.0 },
                    { new Guid("75f79c22-4141-43d5-a619-3efdef1feae6"), 3, "Blue", new DateTime(2020, 6, 15, 1, 24, 29, 928, DateTimeKind.Local).AddTicks(5256), 0.0, 0.0, 2, "Diamond", "Earrings Golden", 200.5, 32.0 }
                });
        }
    }
}
