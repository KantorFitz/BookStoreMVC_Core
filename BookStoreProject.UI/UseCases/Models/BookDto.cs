using System;

namespace BookStoreProject.UI.UseCases.Models
{
	public class BookDto
	{
		public Guid BookId { get; set; }
		public string Title { get; set; }
		public string ImageName { get; set; }
	}
}