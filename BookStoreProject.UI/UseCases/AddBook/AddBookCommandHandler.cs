using System.Threading;
using System.Threading.Tasks;
using BookStoreProject.UI.Entities;
using BookStoreProject.UI.UseCases.AddComment;
using FluentValidation.Results;
using MediatR;

namespace BookStoreProject.UI.UseCases.AddBook
{
	public class AddBookCommandHandler : IRequestHandler<AddBookCommand, Result>
	{
		private readonly BookStoreDbContext _context;

		public AddBookCommandHandler(BookStoreDbContext context)
		{
			_context = context;
		}

		public async Task<Result> Handle(AddBookCommand request, CancellationToken cancellationToken)
		{
			var valRes = await new AddBookCommandValidator().ValidateAsync(request, cancellationToken);
			if (!valRes.IsValid)
			{
				return Result.Fail(valRes);
			}

			var newBook = new Book
			{
				Title = request.Title,
				ISBN = request.ISBN,
				Price = request.Price,
			};

			_context.Books.Add(newBook);
			await _context.SaveChangesAsync(cancellationToken);

			return Result.Ok();
		}
	}
}