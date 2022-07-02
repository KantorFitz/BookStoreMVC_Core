using System;
using System.Collections.Generic;

namespace BookStoreProject.UI.Entities
{
	public class Book
	{
		public Book(Guid id, string title, int isbn, int price, Author authors,
			ICollection<Opinion> opinions, Guid? genreId)
		{
			Id = id;
			Title = title;
			ISBN = isbn;
			Price = price;
			AuthorId = authors?.Id;
			Opinions = opinions;
			GenreId = genreId;
		}

		public Book()
		{
			
		}

		public Guid Id { get; set; }

		public string Title { get; set; }
		public int ISBN { get; set; }
		public int Price { get; set; }

		public Guid? AuthorId { get; set; }
		public virtual Author BookAuthor { get; set; }
		public virtual ICollection<Opinion> Opinions { get; set; }
		
		public Guid? GenreId { get; set; }
		public virtual Genre BookGenre { get; set; }
	}
}