using System;
using System.Threading.Tasks;
using BookStoreProject.UI.UseCases.AddComment;
using BookStoreProject.UI.UseCases.AddImage;
using BookStoreProject.UI.UseCases.DeleteBook;
using BookStoreProject.UI.UseCases.GetBookDetail;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreProject.UI.Controllers
{
	public class BookController : Controller
	{
		private readonly IMediator _mediator;

		public BookController(IMediator mediator)
		{
			_mediator = mediator;
		}
		
		public async Task<IActionResult> Index(Guid id)
		{
			var response = await _mediator.Send(new GetBookDetailQuery
			{
				Id = id
			});

			return View(response);
		}

		public IActionResult AddComment(Guid id)
		{
			var newOpinion = new AddCommentCommand
			{
				BookId = id
			};
			
			return View(newOpinion);
		}

		[HttpPost]
		public async Task<IActionResult> AddComment(AddCommentCommand command)
		{
			var results = await _mediator.Send(command);
			if (!results.IsFailure) return RedirectToAction("Index", new { id = command.BookId });
			
			ModelState.PopulateValidation(results.Errors);
			return View(command);
		}


		public IActionResult AddImage(Guid id)
		{
			var newImage = new AddImageCommand
			{
				BookId = id
			};

			return View(newImage);
		}

		[HttpPost]
		public async Task<IActionResult> AddImage(AddImageCommand command)
		{
			var result = await _mediator.Send(command);
			if (!result.IsFailure) return RedirectToAction("Index", new { id = command.BookId });
			
			ModelState.PopulateValidation(result.Errors);
			return View(command);
		}
		
		public async Task<IActionResult> DeleteBook(Guid id)
		{
			await _mediator.Send(new DeleteBookCommand
			{
				BookId = id
			});

			return RedirectToAction("Index", "Home");
		}
	}
}