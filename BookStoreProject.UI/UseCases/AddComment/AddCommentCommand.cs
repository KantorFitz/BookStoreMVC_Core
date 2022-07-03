using System;
using MediatR;

namespace BookStoreProject.UI.UseCases.AddComment
{
	public class AddCommentCommand : IRequest<Result>
	{
		public Guid BookId { get; set; }
		public string Author { get; set; }
		public string Content { get; set; }
	}
}