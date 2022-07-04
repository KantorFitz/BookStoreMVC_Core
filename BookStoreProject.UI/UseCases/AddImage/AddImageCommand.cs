using System;
using MediatR;

namespace BookStoreProject.UI.UseCases.AddImage
{
	public class AddImageCommand : IRequest<Result>
	{
		public Guid BookId { get; set; }
		public string Url { get; set; }
	}
}