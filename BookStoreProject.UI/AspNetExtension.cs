using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BookStoreProject.UI
{
	public static class AspNetExtension
	{
		public static void PopulateValidation(this ModelStateDictionary modelState, IEnumerable<Result.Error> errors)
		{
			foreach (var error in errors) modelState.AddModelError(error.PropertyName, error.Message);
		}
	}
}