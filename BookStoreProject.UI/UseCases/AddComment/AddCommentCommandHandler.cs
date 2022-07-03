using System;
using System.Threading;
using System.Threading.Tasks;
using BookStoreProject.UI.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookStoreProject.UI.UseCases.AddComment
{
	public class AddCommentCommandHandler : IRequestHandler<AddCommentCommand>
	{
		private readonly BookStoreDbContext _context;

		public AddCommentCommandHandler(BookStoreDbContext context)
		{
			_context = context;
		}
		
		public async Task<Unit> Handle(AddCommentCommand request, CancellationToken cancellationToken)
		{
			var book = await _context.Books.SingleOrDefaultAsync(x => x.Id == request.BookId, cancellationToken: cancellationToken);

			if (book is null)
				return Unit.Value;

			var newComment = new Opinion
			{
				Content = request.Content,
				BookId = book.Id,
				CreatedAt = $"{DateTime.Now:MM/dd/yyyy HH:mm:ss}",
				UserName = request.Author,
			};

			_context.Opinions.Add(newComment);
			await _context.SaveChangesAsync(cancellationToken);
			
			return Unit.Value;
		}
	}
}