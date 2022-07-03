using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BookStoreProject.UI.UseCases.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookStoreProject.UI.UseCases.GetAllBooks
{
	public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<BookDto>>
	{
		private readonly BookStoreDbContext _context;

		public GetAllBooksQueryHandler(BookStoreDbContext context)
		{
			_context = context;
		}
		
		public async Task<List<BookDto>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
		{
			return await _context.Books.Select(x => new BookDto{BookId = x.Id, Title = x.Title, ImageName = x.ImageName}).ToListAsync(cancellationToken);
		}
	}
}