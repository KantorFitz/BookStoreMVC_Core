using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookStoreProject.UI.Models;
using BookStoreProject.UI.UseCases.GetAllBooks;
using MediatR;

namespace BookStoreProject.UI.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IMediator _mediator;

		public HomeController(ILogger<HomeController> logger, IMediator mediator)
		{
			_logger = logger;
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
			return RedirectToAction("Index", "Home");
		}
	}
}