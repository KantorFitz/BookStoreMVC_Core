using System;
using System.Collections.Generic;
using BookStoreProject.UI.Entities;

namespace BookStoreProject.UI.UseCases.Models
{
	public class BookDetailDto
	{
		public Guid Id { get; set; }

		public string Title { get; set; }
		public int ISBN { get; set; }
		public int Price { get; set; }

		public string AuthorFullName { get; set; }
		public List<OpinionDto> OpinionsDtos { get; set; }
	}
}