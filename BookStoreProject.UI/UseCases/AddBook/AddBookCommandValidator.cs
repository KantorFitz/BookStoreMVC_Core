using FluentValidation;

namespace BookStoreProject.UI.UseCases.AddBook
{
	public class AddBookCommandValidator : AbstractValidator<AddBookCommand>
	{
		public AddBookCommandValidator()
		{
			RuleFor(x => x.Title).NotEmpty().MaximumLength(150);
			RuleFor(x => x.Genre).NotEmpty().MaximumLength(20);
			RuleFor(x => x.Price).NotEmpty().GreaterThan(1);
			RuleFor(x => x.ISBN).NotEmpty();
			RuleFor(x => x.AuthorName).NotEmpty().MaximumLength(30);
			RuleFor(x => x.AuthorSurname).NotEmpty().MaximumLength(30);
		}
	}
}