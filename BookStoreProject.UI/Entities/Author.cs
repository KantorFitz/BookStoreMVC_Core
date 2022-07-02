using System;
using System.Collections.Generic;

namespace BookStoreProject.UI.Entities
{
	public class Author
	{
		public Guid Id { get; set; }
		
		public string Name { get; set; }
		public string Surname { get; set; }
		
		public virtual ICollection<Book> Books { get; set; }
	}
}