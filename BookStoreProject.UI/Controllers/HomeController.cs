using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookStoreProject.UI.Models;
using BookStoreProject.UI.UseCases.AddBook;
using BookStoreProject.UI.UseCases.GetAllBooks;
using MediatR;

namespace BookStoreProject.UI.Controllers
{
	public class HomeController : Controller
	{
		public async Task<IActionResult> Index(
			[FromServices] IMediator mediator)
		{
			var response = await mediator.Send(new GetAllBooksQuery());
			return View(response);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Add(AddBookCommand command,
			[FromServices] IMediator mediator)
		{
			var response = await mediator.Send(command);
			if (!response.IsFailure) return RedirectToAction("Index", "Home");

			ModelState.PopulateValidation(response.Errors);
			return View(command);
		}
	}
}