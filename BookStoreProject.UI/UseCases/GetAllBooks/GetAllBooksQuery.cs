using System.Collections.Generic;
using BookStoreProject.UI.UseCases.Models;
using MediatR;

namespace BookStoreProject.UI.UseCases.GetAllBooks
{
	public class GetAllBooksQuery : IRequest<List<BookDto>>
	{
		
	}
}