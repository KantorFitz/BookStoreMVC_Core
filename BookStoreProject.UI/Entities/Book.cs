using System;
using System.Collections.Generic;

namespace BookStoreProject.UI.Entities
{
	public class Book
	{
		public Guid Id { get; set; }

		public string Title { get; set; }
		public int ISBN { get; set; }
		public int Price { get; set; }
		
		public virtual ICollection<Author> Authors { get; set; }
		public virtual ICollection<Opinion> Opinions { get; set; }
		
		public Guid GenreId { get; set; }
		public virtual Genre BookGenre { get; set; }
	}
}