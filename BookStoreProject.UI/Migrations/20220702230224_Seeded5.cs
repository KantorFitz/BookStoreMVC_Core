using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreProject.UI.Migrations
{
    public partial class Seeded5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("1fd5f55e-a9dd-49e1-982f-1d5075ba2f33"), "Jesse", "Gomez" },
                    { new Guid("46eb33c7-a0e2-4c9c-9c64-db0ea936238d"), "Anita", "Gonzalez" },
                    { new Guid("9b27ae4c-7e74-40da-b05a-39369d02104d"), "Erik", "Edwards" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("5b73643d-4bbf-4b2c-978a-775ffcd2804f"), "A historical genre", "Historical" },
                    { new Guid("859cd3e9-d967-4f4a-80c7-986329ad5241"), "A Mystery genre", "Mystery" },
                    { new Guid("fd830861-0ca9-4f7d-9092-8be94ace624b"), "A Comedy genre", "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "BookAuthorId", "BookGenreId", "GenreId", "ISBN", "Price", "Title" },
                values: new object[] { new Guid("c1d83acf-01f2-4f45-b3d4-5666b62a6f21"), new Guid("1fd5f55e-a9dd-49e1-982f-1d5075ba2f33"), null, null, new Guid("5b73643d-4bbf-4b2c-978a-775ffcd2804f"), 1010, 40, "Miś uszatek" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "BookAuthorId", "BookGenreId", "GenreId", "ISBN", "Price", "Title" },
                values: new object[] { new Guid("59d3f929-2f74-4922-87d0-87baa448d570"), new Guid("46eb33c7-a0e2-4c9c-9c64-db0ea936238d"), null, null, new Guid("5b73643d-4bbf-4b2c-978a-775ffcd2804f"), 1020, 34, "Miś koralgor" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "BookAuthorId", "BookGenreId", "GenreId", "ISBN", "Price", "Title" },
                values: new object[] { new Guid("7dd2aed8-2e07-409b-b354-e1bc056e519c"), new Guid("9b27ae4c-7e74-40da-b05a-39369d02104d"), null, null, new Guid("5b73643d-4bbf-4b2c-978a-775ffcd2804f"), 1240, 10, "Miś jogi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("59d3f929-2f74-4922-87d0-87baa448d570"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("7dd2aed8-2e07-409b-b354-e1bc056e519c"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("c1d83acf-01f2-4f45-b3d4-5666b62a6f21"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("859cd3e9-d967-4f4a-80c7-986329ad5241"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("fd830861-0ca9-4f7d-9092-8be94ace624b"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("1fd5f55e-a9dd-49e1-982f-1d5075ba2f33"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("46eb33c7-a0e2-4c9c-9c64-db0ea936238d"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("9b27ae4c-7e74-40da-b05a-39369d02104d"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("5b73643d-4bbf-4b2c-978a-775ffcd2804f"));

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
    }
}
