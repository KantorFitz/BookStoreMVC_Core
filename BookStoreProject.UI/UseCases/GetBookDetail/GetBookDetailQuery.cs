using System;
using BookStoreProject.UI.UseCases.Models;
using MediatR;

namespace BookStoreProject.UI.UseCases.GetBookDetail
{
	public class GetBookDetailQuery : IRequest<BookDetailDto>
	{
		public Guid Id { get; set; }
	}
}