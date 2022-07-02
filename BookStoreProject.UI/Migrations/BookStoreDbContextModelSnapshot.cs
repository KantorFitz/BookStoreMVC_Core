﻿// <auto-generated />
using System;
using BookStoreProject.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStoreProject.UI.Migrations
{
    [DbContext(typeof(BookStoreDbContext))]
    partial class BookStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookStoreProject.UI.Entities.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1e7f46b8-d8d0-4362-8506-045d4bd173a4"),
                            Name = "Jesse",
                            Surname = "Gomez"
                        },
                        new
                        {
                            Id = new Guid("18bdadab-f8c7-44c4-8d38-4f952d769606"),
                            Name = "Anita",
                            Surname = "Gonzalez"
                        },
                        new
                        {
                            Id = new Guid("3aae689f-5273-45c9-856d-1f392042658e"),
                            Name = "Erik",
                            Surname = "Edwards"
                        });
                });

            modelBuilder.Entity("BookStoreProject.UI.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BookAuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BookGenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ISBN")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookAuthorId");

                    b.HasIndex("BookGenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d1e96948-3989-4d87-9858-2440ea8eda4e"),
                            AuthorId = new Guid("1e7f46b8-d8d0-4362-8506-045d4bd173a4"),
                            GenreId = new Guid("f0571da6-29ae-4bf9-a528-c605cf2c9cee"),
                            ISBN = 1010,
                            Price = 40,
                            Title = "Miś uszatek"
                        },
                        new
                        {
                            Id = new Guid("257fcf9d-6a1c-4c94-91ef-9a5582be72c0"),
                            AuthorId = new Guid("18bdadab-f8c7-44c4-8d38-4f952d769606"),
                            GenreId = new Guid("f0571da6-29ae-4bf9-a528-c605cf2c9cee"),
                            ISBN = 1020,
                            Price = 34,
                            Title = "Miś koralgor"
                        },
                        new
                        {
                            Id = new Guid("b46ebcb7-d459-43e6-8448-3f4eb912aa68"),
                            AuthorId = new Guid("3aae689f-5273-45c9-856d-1f392042658e"),
                            GenreId = new Guid("f0571da6-29ae-4bf9-a528-c605cf2c9cee"),
                            ISBN = 1240,
                            Price = 10,
                            Title = "Miś jogi"
                        });
                });

            modelBuilder.Entity("BookStoreProject.UI.Entities.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f0571da6-29ae-4bf9-a528-c605cf2c9cee"),
                            Description = "A historical genre",
                            Name = "Historical"
                        },
                        new
                        {
                            Id = new Guid("d8a9260d-18c5-435b-8a24-68b0521394b9"),
                            Description = "A Mystery genre",
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = new Guid("d9fd3975-fa8b-44bc-af80-91fb6d09c39b"),
                            Description = "A Comedy genre",
                            Name = "Comedy"
                        });
                });

            modelBuilder.Entity("BookStoreProject.UI.Entities.Opinion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Opinion");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f62fba10-9b59-41ab-a09d-dcebbc3c696a"),
                            BookId = new Guid("d1e96948-3989-4d87-9858-2440ea8eda4e"),
                            Content = "Books are ALWAYS better then the movies.",
                            CreatedAt = "07.03.2022 01:06:18",
                            UserName = "Lindsay Roberts"
                        },
                        new
                        {
                            Id = new Guid("1a21ce13-466c-47df-b54b-085adb90baa7"),
                            BookId = new Guid("257fcf9d-6a1c-4c94-91ef-9a5582be72c0"),
                            Content = "Facebook, Twitter, Instagram, and all the other social media sites are destroying communication.",
                            CreatedAt = "07.03.2022 01:06:18",
                            UserName = "Olga Hurley"
                        },
                        new
                        {
                            Id = new Guid("0dd4b6d0-76fe-43a5-8884-4c997ee4f4fe"),
                            BookId = new Guid("d1e96948-3989-4d87-9858-2440ea8eda4e"),
                            Content = "Romeo and Juliet, The Notebook, and Titanic are extremely overrated.",
                            CreatedAt = "07.03.2022 01:06:18",
                            UserName = "Leslie Erickson"
                        },
                        new
                        {
                            Id = new Guid("40bef538-1917-442d-81aa-2db444d51246"),
                            BookId = new Guid("257fcf9d-6a1c-4c94-91ef-9a5582be72c0"),
                            Content = "It’s fun and cute and literally what social media is for when friends post about their pets, babies, or what they ate for lunch on Facebook or Twitter.",
                            CreatedAt = "07.03.2022 01:06:18",
                            UserName = "Heidi Saunders"
                        },
                        new
                        {
                            Id = new Guid("446f8fb8-a3d9-4e3e-aa64-542f08137b62"),
                            BookId = new Guid("b46ebcb7-d459-43e6-8448-3f4eb912aa68"),
                            Content = "White-collar hiring managers should worry less about finding someone with specific previous job experience.",
                            CreatedAt = "07.03.2022 01:06:18",
                            UserName = "Jeannette Hayden"
                        });
                });

            modelBuilder.Entity("BookStoreProject.UI.Entities.Book", b =>
                {
                    b.HasOne("BookStoreProject.UI.Entities.Author", null)
                        .WithMany("Books")
                        .HasForeignKey("AuthorId");

                    b.HasOne("BookStoreProject.UI.Entities.Author", "BookAuthor")
                        .WithMany()
                        .HasForeignKey("BookAuthorId");

                    b.HasOne("BookStoreProject.UI.Entities.Genre", "BookGenre")
                        .WithMany()
                        .HasForeignKey("BookGenreId");

                    b.HasOne("BookStoreProject.UI.Entities.Genre", null)
                        .WithMany("Books")
                        .HasForeignKey("GenreId");

                    b.Navigation("BookAuthor");

                    b.Navigation("BookGenre");
                });

            modelBuilder.Entity("BookStoreProject.UI.Entities.Opinion", b =>
                {
                    b.HasOne("BookStoreProject.UI.Entities.Book", "BookOpinion")
                        .WithMany("Opinions")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookOpinion");
                });

            modelBuilder.Entity("BookStoreProject.UI.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookStoreProject.UI.Entities.Book", b =>
                {
                    b.Navigation("Opinions");
                });

            modelBuilder.Entity("BookStoreProject.UI.Entities.Genre", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
