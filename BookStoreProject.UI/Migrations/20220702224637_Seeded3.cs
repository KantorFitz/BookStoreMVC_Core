using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreProject.UI.Migrations
{
    public partial class Seeded3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("4eb704ce-d1be-4e1e-8be7-adb51e1a4eca"), "Jesse", "Gomez" },
                    { new Guid("3f94c937-82a7-4015-a553-cf4068390f80"), "Anita", "Gonzalez" },
                    { new Guid("d78fca12-6e6b-497f-88cc-1dfccc674bf9"), "Erik", "Edwards" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("e8535de2-9c48-4b1b-9aac-e895c8ad7a18"), "A historical genre", "Historical" },
                    { new Guid("779f36aa-0236-4323-b810-b012a3264289"), "A Mystery genre", "Mystery" },
                    { new Guid("823cfe90-e616-4004-bd11-1d91a1111e1d"), "A Comedy genre", "Comedy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("3f94c937-82a7-4015-a553-cf4068390f80"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("4eb704ce-d1be-4e1e-8be7-adb51e1a4eca"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("d78fca12-6e6b-497f-88cc-1dfccc674bf9"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("779f36aa-0236-4323-b810-b012a3264289"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("823cfe90-e616-4004-bd11-1d91a1111e1d"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("e8535de2-9c48-4b1b-9aac-e895c8ad7a18"));

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
    }
}
