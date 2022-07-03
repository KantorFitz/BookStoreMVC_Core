﻿using System;
using System.Threading;
using System.Threading.Tasks;
using BookStoreProject.UI.Entities;
using BookStoreProject.UI.UseCases.AddComment;
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
			await _mediator.Send(command);

			return RedirectToAction("Index", new {id = command.BookId});
		}
	}
}