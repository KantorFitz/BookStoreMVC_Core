using System;
using MediatR;

namespace BookStoreProject.UI.UseCases.DeleteBook
{
	public class DeleteBookCommand : IRequest
	{
		public Guid BookId { get; set; }
	}
}