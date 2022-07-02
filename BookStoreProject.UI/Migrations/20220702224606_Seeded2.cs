using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreProject.UI.Migrations
{
    public partial class Seeded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { new Guid("95698799-da26-4923-b09a-1d2fb1afd6cd"), "Jesse", "Gomez" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { new Guid("505d4768-57ac-487c-b230-4155878c0519"), "Anita", "Gonzalez" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { new Guid("f90a1335-d376-416a-8fd5-418731c86df0"), "Erik", "Edwards" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("505d4768-57ac-487c-b230-4155878c0519"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("95698799-da26-4923-b09a-1d2fb1afd6cd"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("f90a1335-d376-416a-8fd5-418731c86df0"));

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
    }
}
