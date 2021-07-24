using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketProj.DAL.Migrations
{
    public partial class dataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
