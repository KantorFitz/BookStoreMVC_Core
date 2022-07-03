using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreProject.UI.Migrations
{
    public partial class ImagesSupport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[,]
                {
                    { new Guid("f788728d-2c25-4c02-80f9-3ca4fc9cd418"), "Jesse", "Gomez" },
                    { new Guid("32fa20ee-f665-414a-bf9f-721778a55d13"), "Anita", "Gonzalez" },
                    { new Guid("8d885c13-6d5b-4763-b3f3-29ba3c1311b1"), "Erik", "Edwards" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1f0dab6a-de36-4966-86a6-f85cb39d345a"), "A historical genre", "Historical" },
                    { new Guid("0c2e75d5-eddd-4b58-b5ee-444eea008baf"), "A Mystery genre", "Mystery" },
                    { new Guid("2eb3b7d0-4b0d-4356-970a-739f630ee720"), "A Comedy genre", "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "BookAuthorId", "BookGenreId", "GenreId", "ISBN", "ImageName", "Price", "Title" },
                values: new object[] { new Guid("28158b5e-33e1-4fa2-b5a2-c4f3f98f07bd"), new Guid("f788728d-2c25-4c02-80f9-3ca4fc9cd418"), null, null, new Guid("1f0dab6a-de36-4966-86a6-f85cb39d345a"), 1010, "uszatek.jpg", 40, "Miś uszatek" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "BookAuthorId", "BookGenreId", "GenreId", "ISBN", "ImageName", "Price", "Title" },
                values: new object[] { new Guid("233f806d-9f0a-43c6-9360-9d8bb52a5bf5"), new Guid("32fa20ee-f665-414a-bf9f-721778a55d13"), null, null, new Guid("1f0dab6a-de36-4966-86a6-f85cb39d345a"), 1020, "Colargol.jpg", 34, "Miś koralgor" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "BookAuthorId", "BookGenreId", "GenreId", "ISBN", "ImageName", "Price", "Title" },
                values: new object[] { new Guid("d9e6e045-4539-4422-ab2c-a5475108ffb5"), new Guid("8d885c13-6d5b-4763-b3f3-29ba3c1311b1"), null, null, new Guid("1f0dab6a-de36-4966-86a6-f85cb39d345a"), 1240, "yogi.png", 10, "Miś jogi" });

            migrationBuilder.InsertData(
                table: "Opinion",
                columns: new[] { "Id", "BookId", "Content", "CreatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("dca08642-cdb8-4c46-a6b3-39d3b65547dc"), new Guid("28158b5e-33e1-4fa2-b5a2-c4f3f98f07bd"), "Books are ALWAYS better then the movies.", "07.03.2022 16:58:27", "Lindsay Roberts" },
                    { new Guid("99fb5f52-caba-43ab-8ebf-8a1a9a22c257"), new Guid("28158b5e-33e1-4fa2-b5a2-c4f3f98f07bd"), "Romeo and Juliet, The Notebook, and Titanic are extremely overrated.", "07.03.2022 16:58:27", "Leslie Erickson" },
                    { new Guid("1ee649c4-de25-4cc1-a0d4-968fa2eb6a75"), new Guid("233f806d-9f0a-43c6-9360-9d8bb52a5bf5"), "Facebook, Twitter, Instagram, and all the other social media sites are destroying communication.", "07.03.2022 16:58:27", "Olga Hurley" },
                    { new Guid("05e5393e-c476-435a-beb0-baefce30ee1e"), new Guid("233f806d-9f0a-43c6-9360-9d8bb52a5bf5"), "It’s fun and cute and literally what social media is for when friends post about their pets, babies, or what they ate for lunch on Facebook or Twitter.", "07.03.2022 16:58:27", "Heidi Saunders" },
                    { new Guid("2df4ba21-b88a-456f-a7ef-ef84f55f5e5a"), new Guid("d9e6e045-4539-4422-ab2c-a5475108ffb5"), "White-collar hiring managers should worry less about finding someone with specific previous job experience.", "07.03.2022 16:58:27", "Jeannette Hayden" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("0c2e75d5-eddd-4b58-b5ee-444eea008baf"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("2eb3b7d0-4b0d-4356-970a-739f630ee720"));

            migrationBuilder.DeleteData(
                table: "Opinion",
                keyColumn: "Id",
                keyValue: new Guid("05e5393e-c476-435a-beb0-baefce30ee1e"));

            migrationBuilder.DeleteData(
                table: "Opinion",
                keyColumn: "Id",
                keyValue: new Guid("1ee649c4-de25-4cc1-a0d4-968fa2eb6a75"));

            migrationBuilder.DeleteData(
                table: "Opinion",
                keyColumn: "Id",
                keyValue: new Guid("2df4ba21-b88a-456f-a7ef-ef84f55f5e5a"));

            migrationBuilder.DeleteData(
                table: "Opinion",
                keyColumn: "Id",
                keyValue: new Guid("99fb5f52-caba-43ab-8ebf-8a1a9a22c257"));

            migrationBuilder.DeleteData(
                table: "Opinion",
                keyColumn: "Id",
                keyValue: new Guid("dca08642-cdb8-4c46-a6b3-39d3b65547dc"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("233f806d-9f0a-43c6-9360-9d8bb52a5bf5"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("28158b5e-33e1-4fa2-b5a2-c4f3f98f07bd"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: new Guid("d9e6e045-4539-4422-ab2c-a5475108ffb5"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("32fa20ee-f665-414a-bf9f-721778a55d13"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("8d885c13-6d5b-4763-b3f3-29ba3c1311b1"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("f788728d-2c25-4c02-80f9-3ca4fc9cd418"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("1f0dab6a-de36-4966-86a6-f85cb39d345a"));

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Book");

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
    }
}
