﻿// <auto-generated />
using System;
using BookStoreProject.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStoreProject.UI.Migrations
{
    [DbContext(typeof(BookStoreDbContext))]
    [Migration("20220703145827_ImagesSupport")]
    partial class ImagesSupport
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("f788728d-2c25-4c02-80f9-3ca4fc9cd418"),
                            Name = "Jesse",
                            Surname = "Gomez"
                        },
                        new
                        {
                            Id = new Guid("32fa20ee-f665-414a-bf9f-721778a55d13"),
                            Name = "Anita",
                            Surname = "Gonzalez"
                        },
                        new
                        {
                            Id = new Guid("8d885c13-6d5b-4763-b3f3-29ba3c1311b1"),
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

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

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
                            Id = new Guid("28158b5e-33e1-4fa2-b5a2-c4f3f98f07bd"),
                            AuthorId = new Guid("f788728d-2c25-4c02-80f9-3ca4fc9cd418"),
                            GenreId = new Guid("1f0dab6a-de36-4966-86a6-f85cb39d345a"),
                            ISBN = 1010,
                            ImageName = "uszatek.jpg",
                            Price = 40,
                            Title = "Miś uszatek"
                        },
                        new
                        {
                            Id = new Guid("233f806d-9f0a-43c6-9360-9d8bb52a5bf5"),
                            AuthorId = new Guid("32fa20ee-f665-414a-bf9f-721778a55d13"),
                            GenreId = new Guid("1f0dab6a-de36-4966-86a6-f85cb39d345a"),
                            ISBN = 1020,
                            ImageName = "Colargol.jpg",
                            Price = 34,
                            Title = "Miś koralgor"
                        },
                        new
                        {
                            Id = new Guid("d9e6e045-4539-4422-ab2c-a5475108ffb5"),
                            AuthorId = new Guid("8d885c13-6d5b-4763-b3f3-29ba3c1311b1"),
                            GenreId = new Guid("1f0dab6a-de36-4966-86a6-f85cb39d345a"),
                            ISBN = 1240,
                            ImageName = "yogi.png",
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
                            Id = new Guid("1f0dab6a-de36-4966-86a6-f85cb39d345a"),
                            Description = "A historical genre",
                            Name = "Historical"
                        },
                        new
                        {
                            Id = new Guid("0c2e75d5-eddd-4b58-b5ee-444eea008baf"),
                            Description = "A Mystery genre",
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = new Guid("2eb3b7d0-4b0d-4356-970a-739f630ee720"),
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
                            Id = new Guid("dca08642-cdb8-4c46-a6b3-39d3b65547dc"),
                            BookId = new Guid("28158b5e-33e1-4fa2-b5a2-c4f3f98f07bd"),
                            Content = "Books are ALWAYS better then the movies.",
                            CreatedAt = "07.03.2022 16:58:27",
                            UserName = "Lindsay Roberts"
                        },
                        new
                        {
                            Id = new Guid("1ee649c4-de25-4cc1-a0d4-968fa2eb6a75"),
                            BookId = new Guid("233f806d-9f0a-43c6-9360-9d8bb52a5bf5"),
                            Content = "Facebook, Twitter, Instagram, and all the other social media sites are destroying communication.",
                            CreatedAt = "07.03.2022 16:58:27",
                            UserName = "Olga Hurley"
                        },
                        new
                        {
                            Id = new Guid("99fb5f52-caba-43ab-8ebf-8a1a9a22c257"),
                            BookId = new Guid("28158b5e-33e1-4fa2-b5a2-c4f3f98f07bd"),
                            Content = "Romeo and Juliet, The Notebook, and Titanic are extremely overrated.",
                            CreatedAt = "07.03.2022 16:58:27",
                            UserName = "Leslie Erickson"
                        },
                        new
                        {
                            Id = new Guid("05e5393e-c476-435a-beb0-baefce30ee1e"),
                            BookId = new Guid("233f806d-9f0a-43c6-9360-9d8bb52a5bf5"),
                            Content = "It’s fun and cute and literally what social media is for when friends post about their pets, babies, or what they ate for lunch on Facebook or Twitter.",
                            CreatedAt = "07.03.2022 16:58:27",
                            UserName = "Heidi Saunders"
                        },
                        new
                        {
                            Id = new Guid("2df4ba21-b88a-456f-a7ef-ef84f55f5e5a"),
                            BookId = new Guid("d9e6e045-4539-4422-ab2c-a5475108ffb5"),
                            Content = "White-collar hiring managers should worry less about finding someone with specific previous job experience.",
                            CreatedAt = "07.03.2022 16:58:27",
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
