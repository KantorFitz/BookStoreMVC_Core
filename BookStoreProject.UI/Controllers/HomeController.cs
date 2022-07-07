using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
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
		private readonly IMediator _mediator;

		public HomeController(IMediator mediator)
		{
			_mediator = mediator;
		}

		public async Task<IActionResult> Index()
		{
			var response = await _mediator.Send(new GetAllBooksQuery());
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
		public async Task<IActionResult> Add(AddBookCommand command)
		{
			var response = await _mediator.Send(command);
			if (!response.IsFailure) return RedirectToAction("Index", "Home");
			
			ModelState.PopulateValidation(response.Errors);
				return View(command);
		}
	}
}