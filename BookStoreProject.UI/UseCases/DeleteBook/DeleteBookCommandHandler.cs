using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookStoreProject.UI.UseCases.DeleteBook
{
	public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand>
	{
		private readonly BookStoreDbContext _context;

		public DeleteBookCommandHandler(BookStoreDbContext context)
		{
			_context = context;
		}

		public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
		{
			var book = await _context.Books.SingleOrDefaultAsync(x => x.Id == request.BookId, cancellationToken);

			_context.Books.Remove(book);
			await _context.SaveChangesAsync(cancellationToken);
			
			return Unit.Value;
		}
	}
}