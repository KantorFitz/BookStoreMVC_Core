using FluentValidation;

namespace BookStoreProject.UI.UseCases.GetBookDetail
{
	public class GetBookDetailQueryValidator : AbstractValidator<GetBookDetailQuery>
	{
		public GetBookDetailQueryValidator()
		{
			RuleFor(x => x.Id).NotEmpty();
		}
	}
}