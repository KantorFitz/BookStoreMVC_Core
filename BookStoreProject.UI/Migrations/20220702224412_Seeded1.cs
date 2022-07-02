using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreProject.UI.Migrations
{
    public partial class Seeded1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { new Guid("141264d9-19f9-4167-94e9-3b7e2bd473e1"), "Jesse", "Gomez" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { new Guid("2dcd5724-c755-45bd-9aa0-abefe1b73049"), "Anita", "Gonzalez" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { new Guid("efacdfa1-585d-4471-9163-5ce9942a428b"), "Erik", "Edwards" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("141264d9-19f9-4167-94e9-3b7e2bd473e1"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("2dcd5724-c755-45bd-9aa0-abefe1b73049"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("efacdfa1-585d-4471-9163-5ce9942a428b"));
        }
    }
}
