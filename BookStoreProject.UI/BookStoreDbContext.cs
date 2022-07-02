using System;
using System.Collections.Generic;
using BookStoreProject.UI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStoreProject.UI
{
	public class BookStoreDbContext : DbContext
	{
		public BookStoreDbContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.EnableSensitiveDataLogging();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Author>(m =>
			{
				m.ToTable("Author");
				m.HasKey(x => x.Id);
				m.Property(x => x.Id).ValueGeneratedOnAdd();
				m.HasMany(x => x.Books).WithOne().HasForeignKey(x=>x.AuthorId);
			});
			
			modelBuilder.Entity<Book>(m =>
			{
				m.ToTable("Book");
				m.HasKey(x => x.Id);
				m.Property(x => x.Id).ValueGeneratedOnAdd();
				m.HasOne(x => x.BookAuthor).WithMany();
				m.HasOne(x => x.BookGenre).WithMany();
				m.HasMany(x => x.Opinions).WithOne().HasForeignKey(x => x.BookId);
			});

			modelBuilder.Entity<Genre>(m =>
			{
				m.ToTable("Genre");
				m.HasKey(x => x.Id);
				m.Property(x => x.Id).ValueGeneratedOnAdd();
				m.HasMany(x => x.Books).WithOne().HasForeignKey(x => x.GenreId);
			});

			modelBuilder.Entity<Opinion>(m =>
			{
				m.ToTable("Opinion");
				m.HasKey(x => x.Id);
				m.Property(x => x.Id).ValueGeneratedOnAdd();
				m.HasOne(x => x.BookOpinion).WithMany(x => x.Opinions).HasForeignKey(x=>x.BookId);
			});

			var book1 = new Book(Guid.NewGuid(), "Miś uszatek", 1010, 40, null, new List<Opinion>(), null);
			var book2 = new Book(Guid.NewGuid(), "Miś koralgor", 1020, 34, null, new List<Opinion>(), null);
			var book3 = new Book(Guid.NewGuid(), "Miś jogi", 1240, 10, null, new List<Opinion>(), null);
			
			var author1 = new Author { Id = Guid.NewGuid(), Name = "Jesse", Surname = "Gomez", Books = new List<Book>() };
			var author2 = new Author { Id = Guid.NewGuid(), Name = "Anita" , Surname = "Gonzalez", Books = new List<Book>() };
			var author3 = new Author { Id = Guid.NewGuid(), Name = "Erik" , Surname = "Edwards", Books = new List<Book>() };

			var genre1 = new Genre { Id = Guid.NewGuid(), Name = "Historical", Description = "A historical genre", Books = new List<Book>() };
			var genre2 = new Genre { Id = Guid.NewGuid(), Name = "Mystery", Description = "A Mystery genre", Books = new List<Book>() };
			var genre3 = new Genre { Id = Guid.NewGuid(), Name = "Comedy", Description = "A Comedy genre", Books = new List<Book>() };

			var opinion1 = new Opinion
			{
				Id = Guid.NewGuid(), Content = "Books are ALWAYS better then the movies.",
				CreatedAt = $"{DateTime.Now:MM/dd/yyyy HH:mm:ss}", UserName = "Lindsay Roberts"
			};
			var opinion2 = new Opinion
			{
				Id = Guid.NewGuid(),
				Content =
					"Facebook, Twitter, Instagram, and all the other social media sites are destroying communication.",
				CreatedAt = $"{DateTime.Now:MM/dd/yyyy HH:mm:ss}", UserName = "Olga Hurley"
			};
			var opinion3 = new Opinion
			{
				Id = Guid.NewGuid(), Content = "Romeo and Juliet, The Notebook, and Titanic are extremely overrated.",
				CreatedAt = $"{DateTime.Now:MM/dd/yyyy HH:mm:ss}", UserName = "Leslie Erickson"
			};
			var opinion4 = new Opinion
			{
				Id = Guid.NewGuid(),
				Content =
					"It’s fun and cute and literally what social media is for when friends post about their pets, babies, or what they ate for lunch on Facebook or Twitter.",
				CreatedAt = $"{DateTime.Now:MM/dd/yyyy HH:mm:ss}", UserName = "Heidi Saunders"
			};
			var opinion5 = new Opinion
			{
				Id = Guid.NewGuid(),
				Content =
					"White-collar hiring managers should worry less about finding someone with specific previous job experience.",
				CreatedAt = $"{DateTime.Now:MM/dd/yyyy HH:mm:ss}", UserName = "Jeannette Hayden"
			};


			modelBuilder.Entity<Author>().HasData(author1, author2, author3);
			book1.AuthorId = author1.Id;
			book2.AuthorId = author2.Id;
			book3.AuthorId = author3.Id;
			
			modelBuilder.Entity<Genre>().HasData(genre1, genre2, genre3);
			book1.GenreId = genre1.Id;
			book2.GenreId = genre1.Id;
			book3.GenreId = genre1.Id;
			
			modelBuilder.Entity<Book>().HasData(book1, book2, book3);

			opinion1.BookId = book1.Id;
			opinion2.BookId = book2.Id;
			opinion3.BookId = book1.Id;
			opinion4.BookId = book2.Id;
			opinion5.BookId = book3.Id;
			modelBuilder.Entity<Opinion>().HasData(opinion1, opinion2, opinion3, opinion4, opinion5);
			
		}

		public DbSet<Author> Authors { get; set; }
		public DbSet<Opinion> Opinions { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<Genre> Genres { get; set; }
	}
}