using FluentValidation;

namespace BookStoreProject.UI.UseCases.AddComment
{
	public class AddCommentCommandValidator : AbstractValidator<AddCommentCommand>
	{
		public AddCommentCommandValidator()
		{
			RuleFor(x => x.Author).Must(s => !string.IsNullOrWhiteSpace(s));
			RuleFor(x => x.Content).Must(s => !string.IsNullOrWhiteSpace(s));
			RuleFor(x => x.BookId).NotEmpty();
		}
	}
}