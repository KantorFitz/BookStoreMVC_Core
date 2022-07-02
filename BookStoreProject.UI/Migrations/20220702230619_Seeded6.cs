using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreProject.UI.Migrations
{
    public partial class Seeded6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("1e7f46b8-d8d0-4362-8506-045d4bd173a4"), "Jesse", "Gomez" },
                    { new Guid("18bdadab-f8c7-44c4-8d38-4f952d769606"), "Anita", "Gonzalez" },
                    { new Guid("3aae689f-5273-45c9-856d-1f392042658e"), "Erik", "Edwards" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("f0571da6-29ae-4bf9-a528-c605cf2c9cee"), "A historical genre", "Historical" },
                    { new Guid("d8a9260d-18c5-435b-8a24-68b0521394b9"), "A Mystery genre", "Mystery" },
                    { new Guid("d9fd3975-fa8b-44bc-af80-91fb6d09c39b"), "A Comedy genre", "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "BookAuthorId", "BookGenreId", "GenreId", "ISBN", "Price", "Title" },
                values: new object[] { new Guid("d1e96948-3989-4d87-9858-2440ea8eda4e"), new Guid("1e7f46b8-d8d0-4362-8506-045d4bd173a4"), null, null, new Guid("f0571da6-29ae-4bf9-a528-c605cf2c9cee"), 1010, 40, "Miś uszatek" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "BookAuthorId", "BookGenreId", "GenreId", "ISBN", "Price", "Title" },
                values: new object[] { new Guid("257fcf9d-6a1c-4c94-91ef-9a5582be72c0"), new Guid("18bdadab-f8c7-44c4-8d38-4f952d769606"), null, null, new Guid("f0571da6-29ae-4bf9-a528-c605cf2c9cee"), 1020, 34, "Miś koralgor" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "BookAuthorId", "BookGenreId", "GenreId", "ISBN", "Price", "Title" },
                values: new object[] { new Guid("b46ebcb7-d459-43e6-8448-3f4eb912aa68"), new Guid("3aae689f-5273-45c9-856d-1f392042658e"), null, null, new Guid("f0571da6-29ae-4bf9-a528-c605cf2c9cee"), 1240, 10, "Miś jogi" });

            migrationBuilder.InsertData(
                table: "Opinion",
                columns: new[] { "Id", "BookId", "Content", "CreatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("f62fba10-9b59-41ab-a09d-dcebbc3c696a"), new Guid("d1e96948-3989-4d87-9858-2440ea8eda4e"), "Books are ALWAYS better then the movies.", "07.03.2022 01:06:18", "Lindsay Roberts" },
                    { new Guid("0dd4b6d0-76fe-43a5-8884-4c997ee4f4fe"), new Guid("d1e96948-3989-4d87-9858-2440ea8eda4e"), "Romeo and Juliet, The Notebook, and Titanic are extremely overrated.", "07.03.2022 01:06:18", "Leslie Erickson" },
                    { new Guid("1a21ce13-466c-47df-b54b-085adb90baa7"), new Guid("257fcf9d-6a1c-4c94-91ef-9a5582be72c0"), "Facebook, Twitter, Instagram, and all the other social media sites are destroying communication.", "07.03.2022 01:06:18", "Olga Hurley" },
                    { new Guid("40bef538-1917-442d-81aa-2db444d51246"), new Guid("257fcf9d-6a1c-4c94-91ef-9a5582be72c0"), "It’s fun and cute and literally what social media is for when friends post about their pets, babies, or what they ate for lunch on Facebook or Twitter.", "07.03.2022 01:06:18", "Heidi Saunders" },
                    { new Guid("446f8fb8-a3d9-4e3e-aa64-542f08137b62"), new Guid("b46ebcb7-d459-43e6-8448-3f4eb912aa68"), "White-collar hiring managers should worry less about finding someone with specific previous job experience.", "07.03.2022 01:06:18", "Jeannette Hayden" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("d8a9260d-18c5-435b-8a24-68b0521394b9"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("d9fd3975-fa8b-44bc-af80-91fb6d09c39b"));

            migrationBuilder.DeleteData(
                table: "Opinion",
                keyColumn: "Id",
                keyValue: new Guid("0dd4b6d0-76fe-43a5-8884-4c997ee4f4fe"));

            migrationBuilder.DeleteData(
                table: "Opinion",
                keyColumn: "Id",
                keyValue: new Guid("1a21ce13-466c-47df-b54b-085adb90baa7"));

            migrationBuilder.DeleteData(
                table: "Opinion",
                keyColumn: "Id",
                keyValue: new Guid("40bef538-1917-442d-81aa-2db444d51246"));

            migrationBuilder.DeleteData(
                table: "Opinion",
                keyColumn: "Id",
                keyValue: new Guid("446f8fb8-a3d9-4e3e-aa64-542f08137b62"));

            migrationBuilder.DeleteData(
                table: "Opinion",
                keyColumn: "Id",
                keyValue: new Guid("f62fba10-9b59-41ab-a09d-dcebbc3c696a"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("257fcf9d-6a1c-4c94-91ef-9a5582be72c0"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("b46ebcb7-d459-43e6-8448-3f4eb912aa68"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("d1e96948-3989-4d87-9858-2440ea8eda4e"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("18bdadab-f8c7-44c4-8d38-4f952d769606"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("1e7f46b8-d8d0-4362-8506-045d4bd173a4"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("3aae689f-5273-45c9-856d-1f392042658e"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("f0571da6-29ae-4bf9-a528-c605cf2c9cee"));

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
    }
}
