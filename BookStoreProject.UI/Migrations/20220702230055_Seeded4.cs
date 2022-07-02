using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreProject.UI.Migrations
{
    public partial class Seeded4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("67ef5edb-9ad1-44d0-8969-c119df2f6859"), "Jesse", "Gomez" },
                    { new Guid("86ce989a-adf1-4e69-b7bc-0b4f8ed1935f"), "Anita", "Gonzalez" },
                    { new Guid("71e43125-e630-4a12-bce7-c3e96f1e6b23"), "Erik", "Edwards" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0df49f69-e27c-441e-843a-2c955e8059bd"), "A historical genre", "Historical" },
                    { new Guid("677a0b1c-f42c-432d-90c3-76190d5ba2d7"), "A Mystery genre", "Mystery" },
                    { new Guid("4a290e00-2906-4470-8f0e-f68caae35bae"), "A Comedy genre", "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "BookAuthorId", "BookGenreId", "GenreId", "ISBN", "Price", "Title" },
                values: new object[] { new Guid("ab0dbdc4-aa4b-4e5c-aa5a-9115072db7f6"), new Guid("67ef5edb-9ad1-44d0-8969-c119df2f6859"), null, null, new Guid("0df49f69-e27c-441e-843a-2c955e8059bd"), 1010, 40, "Miś uszatek" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "BookAuthorId", "BookGenreId", "GenreId", "ISBN", "Price", "Title" },
                values: new object[] { new Guid("f02f706d-5043-4c7d-b35f-2757d99097f1"), new Guid("86ce989a-adf1-4e69-b7bc-0b4f8ed1935f"), null, null, new Guid("0df49f69-e27c-441e-843a-2c955e8059bd"), 1020, 34, "Miś koralgor" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "BookAuthorId", "BookGenreId", "GenreId", "ISBN", "Price", "Title" },
                values: new object[] { new Guid("0e4e3fb5-912c-4356-b708-2f7d1c6aebcd"), new Guid("71e43125-e630-4a12-bce7-c3e96f1e6b23"), null, null, new Guid("0df49f69-e27c-441e-843a-2c955e8059bd"), 1240, 10, "Miś jogi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("0e4e3fb5-912c-4356-b708-2f7d1c6aebcd"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("ab0dbdc4-aa4b-4e5c-aa5a-9115072db7f6"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("f02f706d-5043-4c7d-b35f-2757d99097f1"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("4a290e00-2906-4470-8f0e-f68caae35bae"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("677a0b1c-f42c-432d-90c3-76190d5ba2d7"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("67ef5edb-9ad1-44d0-8969-c119df2f6859"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("71e43125-e630-4a12-bce7-c3e96f1e6b23"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("86ce989a-adf1-4e69-b7bc-0b4f8ed1935f"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("0df49f69-e27c-441e-843a-2c955e8059bd"));

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
    }
}
