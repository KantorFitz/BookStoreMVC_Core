using System.Linq;
using System.Runtime.CompilerServices;
using BookStoreProject.UI.Extensions;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace BookStoreProject.UI.UseCases.AddImage
{
	public class AddImageCommandValidator : AbstractValidator<AddImageCommand>
	{
		public AddImageCommandValidator(BookStoreDbContext context)
		{
			RuleFor(x => x.Url).Must(x => x.IsUrlReachable()).WithMessage("Podany URL nie jest prawidłowy");
			RuleFor(x => x.BookId).Must((id) => context.Books.Any(x => x.Id == id))
				.WithMessage("Nie istnieje taka książka");
		}
	}
}