using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketProj.DAL.Migrations
{
    public partial class addProductListItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Size",
                table: "Products",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.CreateTable(
                name: "ProductListItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    MainImgUrl = table.Column<string>(nullable: true),
                    ProductId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductListItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Clothes", "Color", "Date", "DiscountPercent", "DiscountPrice", "Gender", "Model", "Name", "Price", "Size" },
                values: new object[,]
                {
                    { new Guid("677b49b2-4c2d-449b-b594-4ac74f579e9c"), 0, "White", new DateTime(2020, 6, 23, 19, 53, 16, 179, DateTimeKind.Local).AddTicks(2153), 0.0, 0.0, 1, "Nike", "Buisnes Shirt", 20.0, "32" },
                    { new Guid("2204b450-63ca-405e-89b6-841bd0ee1d11"), 1, "Black", new DateTime(2020, 6, 23, 19, 53, 16, 182, DateTimeKind.Local).AddTicks(7036), 0.0, 0.0, 1, "Levis", "Buisnes Short", 25.0, "32" },
                    { new Guid("2dd74da6-fbe0-4fe9-ba21-6414893d8b26"), 2, "Black", new DateTime(2020, 6, 23, 19, 53, 16, 182, DateTimeKind.Local).AddTicks(7309), 0.0, 0.0, 2, "Adidas", "Sport Nice", 25.0, "32" },
                    { new Guid("7a3fc065-6d68-4290-92a1-c08bcb99453c"), 3, "Blue", new DateTime(2020, 6, 23, 19, 53, 16, 182, DateTimeKind.Local).AddTicks(7331), 0.0, 0.0, 2, "Hugo", "Hat", 12.5, "32" },
                    { new Guid("05f5d799-1738-4f7c-bdba-533231a70df8"), 3, "Blue", new DateTime(2020, 6, 23, 19, 53, 16, 182, DateTimeKind.Local).AddTicks(7336), 0.0, 0.0, 2, "Diamond", "Earrings Golden", 200.5, "32" }
                });

            migrationBuilder.InsertData(
                table: "UserProducts",
                columns: new[] { "Id", "ProductId", "UserId" },
                values: new object[,]
                {
                    { new Guid("c58f744c-2f1c-4b34-87d9-7ac10020a0e3"), new Guid("677b49b2-4c2d-449b-b594-4ac74f579e9c"), new Guid("2e5e7149-2410-4997-a4b0-e634b36039a0") },
                    { new Guid("55f90b69-3b6b-47cc-9a54-2b27be95eaae"), new Guid("2204b450-63ca-405e-89b6-841bd0ee1d11"), new Guid("2e5e7149-2410-4997-a4b0-e634b36039a0") },
                    { new Guid("d6c8d439-577c-449c-bf06-1c399aaa0c1a"), new Guid("2204b450-63ca-405e-89b6-841bd0ee1d11"), new Guid("84a6eda2-2ba2-43ed-8006-b07de7403e3d") }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetsType", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("99575665-6fb0-4dc0-84c9-73bffc5e2890"), 0, new Guid("677b49b2-4c2d-449b-b594-4ac74f579e9c"), "https://www.llbeanbusiness.com/static/cms-img/classic-oxford-shirts-f19.jpg" },
                    { new Guid("b7e99648-1dd1-4112-86a0-2f1c411513a4"), 0, new Guid("677b49b2-4c2d-449b-b594-4ac74f579e9c"), "https://images-na.ssl-images-amazon.com/images/I/61TWxMB8LFL._AC_UX679_.jpg" },
                    { new Guid("60ab9937-3696-4d72-bad9-51e3d7a96f2c"), 0, new Guid("2204b450-63ca-405e-89b6-841bd0ee1d11"), "https://i.ebayimg.com/images/g/RgUAAOSwatBb8s0m/s-l1600.jpg" },
                    { new Guid("4aad7156-a52e-448a-8d75-cacff1aed5c3"), 0, new Guid("2204b450-63ca-405e-89b6-841bd0ee1d11"), "https://i.ebayimg.com/images/g/op0AAOSwhnlb8s0f/s-l1600.jpg" },
                    { new Guid("89b90fbf-da31-4d13-ad2e-f19a4d283888"), 0, new Guid("7a3fc065-6d68-4290-92a1-c08bcb99453c"), "https://i.ebayimg.com/images/g/fkUAAOSwG4pctJCS/s-l1600.jpg" },
                    { new Guid("dbe6de55-16a2-48e0-9ae1-bc66e8191b0b"), 0, new Guid("7a3fc065-6d68-4290-92a1-c08bcb99453c"), "https://i.ebayimg.com/images/g/fkUAAOSwG4pctJCS/s-l1600.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductListItems");

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("4aad7156-a52e-448a-8d75-cacff1aed5c3"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("60ab9937-3696-4d72-bad9-51e3d7a96f2c"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("89b90fbf-da31-4d13-ad2e-f19a4d283888"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("99575665-6fb0-4dc0-84c9-73bffc5e2890"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("b7e99648-1dd1-4112-86a0-2f1c411513a4"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("dbe6de55-16a2-48e0-9ae1-bc66e8191b0b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05f5d799-1738-4f7c-bdba-533231a70df8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2dd74da6-fbe0-4fe9-ba21-6414893d8b26"));

            migrationBuilder.DeleteData(
                table: "UserProducts",
                keyColumn: "Id",
                keyValue: new Guid("55f90b69-3b6b-47cc-9a54-2b27be95eaae"));

            migrationBuilder.DeleteData(
                table: "UserProducts",
                keyColumn: "Id",
                keyValue: new Guid("c58f744c-2f1c-4b34-87d9-7ac10020a0e3"));

            migrationBuilder.DeleteData(
                table: "UserProducts",
                keyColumn: "Id",
                keyValue: new Guid("d6c8d439-577c-449c-bf06-1c399aaa0c1a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2204b450-63ca-405e-89b6-841bd0ee1d11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("677b49b2-4c2d-449b-b594-4ac74f579e9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a3fc065-6d68-4290-92a1-c08bcb99453c"));

            migrationBuilder.AlterColumn<double>(
                name: "Size",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
