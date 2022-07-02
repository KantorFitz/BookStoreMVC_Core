using System;
using System.Collections.Generic;

namespace BookStoreProject.UI.Entities
{
	public class Book
	{
		public Book(Guid id, string title, int isbn, int price, ICollection<Author> authors,
			ICollection<Opinion> opinions, Guid? genreId)
		{
			Id = id;
			Title = title;
			ISBN = isbn;
			Price = price;
			Authors = authors;
			Opinions = opinions;
			GenreId = genreId;
		}

		public Guid Id { get; set; }

		public string Title { get; set; }
		public int ISBN { get; set; }
		public int Price { get; set; }
		
		public virtual ICollection<Author> Authors { get; set; }
		public virtual ICollection<Opinion> Opinions { get; set; }
		
		public Guid? GenreId { get; set; }
		public virtual Genre BookGenre { get; set; }
	}
}