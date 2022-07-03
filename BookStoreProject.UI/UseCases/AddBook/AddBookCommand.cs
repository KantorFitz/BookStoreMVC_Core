using MediatR;

namespace BookStoreProject.UI.UseCases.AddBook
{
	public class AddBookCommand : IRequest<Result>
	{
		public string Title { get; set; }
		public string AuthorName { get; set; }
		public string AuthorSurname { get; set; }
		public int Price { get; set; }
		public int ISBN { get; set; }
		public string Genre { get; set; }
	}
}