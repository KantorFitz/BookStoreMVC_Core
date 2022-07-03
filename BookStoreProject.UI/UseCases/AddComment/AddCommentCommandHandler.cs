using System;
using System.Threading;
using System.Threading.Tasks;
using BookStoreProject.UI.Entities;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookStoreProject.UI.UseCases.AddComment
{
	public class AddCommentCommandHandler : IRequestHandler<AddCommentCommand, Result>
	{
		private readonly BookStoreDbContext _context;

		public AddCommentCommandHandler(BookStoreDbContext context)
		{
			_context = context;
		}
		
		public async Task<Result> Handle(AddCommentCommand request, CancellationToken cancellationToken)
		{
			var valRes = await new AddCommentCommandValidator().ValidateAsync(request, cancellationToken);
			if (!valRes.IsValid)
			{
				return Result.Fail(valRes);
			}
			
			var book = await _context.Books.SingleOrDefaultAsync(x => x.Id == request.BookId, cancellationToken);

			if (book is null)
				return Result.Fail("Nie ma takiej książki");

			var newComment = new Opinion
			{
				Content = request.Content,
				BookId = book.Id,
				CreatedAt = $"{DateTime.Now:MM/dd/yyyy HH:mm:ss}",
				UserName = request.Author,
			};

			_context.Opinions.Add(newComment);
			await _context.SaveChangesAsync(cancellationToken);
			
			return Result.Ok();
		}
	}
}