using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreProject.UI;
using BookStoreProject.UI.Controllers;
using BookStoreProject.UI.UseCases.AddBook;
using BookStoreProject.UI.UseCases.GetAllBooks;
using BookStoreProject.UI.UseCases.Models;
using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using NSubstitute;

namespace BookStoreProjectTests.UI
{
	public class HomeControllerTests
	{
		private IMediator _mediator { get; set; }

		private readonly List<BookDto> _mockedBookDto = new()
		{
			new BookDto
			{
				Title = "Test Title",
				BookId = Guid.Parse("765CF35E-F49A-44AC-8B14-85ECCBA66FB8"),
				ImageName = "Test Image"
			}
		};

		public HomeControllerTests()
		{
			_mediator = Substitute.For<IMediator>();
			_mediator.Send(Arg.Any<GetAllBooksQuery>()).Returns(_mockedBookDto);
		}

		[Fact]
		public async Task HomeControllerTest_ReturnsCorrectViewData()
		{
			//Arrange
			var controller = new HomeController();

			// Act
			var result = await controller.Index(_mediator) as ViewResult;
			var bookDtos = (List<BookDto>)result.Model;

			//assert
			bookDtos.Should().ContainSingle().Which.Should().BeEquivalentTo(_mockedBookDto.Single());
		}

		[Fact]
		public async Task HomeControllerTest_ResultIsFailure_RedirectsCorrectly()
		{
			//Arrange
			_mediator.Send(Arg.Any<AddBookCommand>()).Returns(Result.Ok());
			var controller = new HomeController();

			// Act
			var result = (RedirectToActionResult)await controller.Add(new AddBookCommand(), _mediator);

			//assert
			result.ActionName.Should().Be("Index");
			result.ControllerName.Should().Be("Home");
		}
	}
}