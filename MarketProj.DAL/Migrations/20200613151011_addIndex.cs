using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketProj.DAL.Migrations
{
    public partial class addIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_Clothes",
                table: "Products",
                column: "Clothes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_Clothes",
                table: "Products");
        }
    }
}
