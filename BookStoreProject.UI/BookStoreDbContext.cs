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
				m.HasMany(x => x.Books).WithMany(x => x.Authors);
			});
			
			modelBuilder.Entity<Book>(m =>
			{
				m.ToTable("Book");
				m.HasKey(x => x.Id);
				m.Property(x => x.Id).ValueGeneratedOnAdd();
				m.HasMany(x => x.Authors).WithMany(x => x.Books);
				m.HasMany(x => x.Opinions).WithOne(x => x.BookOpinion).HasForeignKey(x=>x.BookId);
				m.HasOne(x => x.BookGenre).WithMany(x => x.Books);
			});

			modelBuilder.Entity<Genre>(m =>
			{
				m.ToTable("Genre");
				m.HasKey(x => x.Id);
				m.Property(x => x.Id).ValueGeneratedOnAdd();
				m.HasMany(x => x.Books).WithOne(x => x.BookGenre).HasForeignKey(x => x.GenreId);
			});

			modelBuilder.Entity<Opinion>(m =>
			{
				m.ToTable("Opinion");
				m.HasKey(x => x.Id);
				m.Property(x => x.Id).ValueGeneratedOnAdd();
				m.HasOne(x => x.BookOpinion).WithMany(x => x.Opinions);
			});

			var book1 = new Book(Guid.NewGuid(), "Miś uszatek", 1010, 40, new List<Author>(), new List<Opinion>(),
				null);
		}

		public DbSet<Author> Authors { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Opinion> Opinions { get; set; }
	}
}