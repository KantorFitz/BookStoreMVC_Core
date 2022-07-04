using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace BookStoreProject.UI.UseCases.AddImage
{
	public class AddImageCommandHandler : IRequestHandler<AddImageCommand, Result>
	{
		private readonly BookStoreDbContext _context;
		private readonly IHostEnvironment _env;

		public AddImageCommandHandler(BookStoreDbContext context, IHostEnvironment env)
		{
			_context = context;
			_env = env;
		}

		public async Task<Result> Handle(AddImageCommand request, CancellationToken cancellationToken)
		{
			var valRes = await new AddImageCommandValidator(_context).ValidateAsync(request, cancellationToken);
			if (!valRes.IsValid)
				return Result.Fail(valRes);


			var randomFileName = $"{Path.GetFileNameWithoutExtension(Path.GetRandomFileName())}.png";
			var rootPath = _env.ContentRootPath;
			var downloadFolder = Path.Combine(rootPath, "wwwroot", "Images", randomFileName);

			SaveImage(request.Url, downloadFolder, ImageFormat.Png);
			
			var book = await _context.Books.SingleOrDefaultAsync(x => x.Id == request.BookId, cancellationToken);
			book.ImageName = randomFileName;

			_context.Books.Update(book);
			await _context.SaveChangesAsync(cancellationToken);

			return Result.Ok();
		}

		private static void SaveImage(string imageUrl, string filename, ImageFormat format)
		{
			var client = new WebClient();
			var stream = client.OpenRead(imageUrl);
			var bitmap = new Bitmap(stream);

			if (bitmap != null)
			{
				bitmap.Save(filename, format);
			}

			stream.Flush();
			stream.Close();
			client.Dispose();
		}
	}
}