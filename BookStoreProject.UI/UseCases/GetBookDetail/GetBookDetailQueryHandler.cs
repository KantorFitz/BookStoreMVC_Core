using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BookStoreProject.UI.UseCases.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookStoreProject.UI.UseCases.GetBookDetail
{
	public class GetBookDetailQueryHandler : IRequestHandler<GetBookDetailQuery, BookDetailDto>
	{
		private readonly BookStoreDbContext _context;

		public GetBookDetailQueryHandler(BookStoreDbContext context)
		{
			_context = context;
		}
		
		public async Task<BookDetailDto> Handle(GetBookDetailQuery request, CancellationToken cancellationToken)
		{
			var book = await _context.Books./*Include(x=>x.Opinions).*//*Include(x=>x.BookAuthor).*//*Include(x=>x.BookGenre).*/SingleAsync(x => x.Id == request.Id, cancellationToken);
			
			return new BookDetailDto
			{
				Price = book.Price,
				Id = book.Id,
				Title = book.Title,
				AuthorFullName = $"{book?.BookAuthor?.Name} {book?.BookAuthor?.Surname}",
				ISBN = book.ISBN,
				ImagePath = book.ImageName,
				Genre = book.BookGenre?.Name ?? "Komiks",
				GenreDescription = book.BookGenre?.Description ?? "Prosty komiks",
				OpinionsDtos = _context.Opinions.Where(x => x.BookId == request.Id).Select(x => new OpinionDto
				{
					Author = x.UserName,
					Content = x.Content,
					CreatedAt = x.CreatedAt
				}).ToList()
			};
		}
	}
}