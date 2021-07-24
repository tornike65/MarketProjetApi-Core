using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketProj.DAL.Migrations.UsersDBMigrations
{
    public partial class dataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Role", "Username" },
                values: new object[] { new Guid("84a6eda2-2ba2-43ed-8006-b07de7403e3d"), "levandoliashvili1@gmail.com", "admin123", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Role", "Username" },
                values: new object[] { new Guid("2e5e7149-2410-4997-a4b0-e634b36039a0"), "levandoliashvili2@gmail.com", "user123", "User", "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e5e7149-2410-4997-a4b0-e634b36039a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84a6eda2-2ba2-43ed-8006-b07de7403e3d"));
        }
    }
}
