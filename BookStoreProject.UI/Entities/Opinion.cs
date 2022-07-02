using System;

namespace BookStoreProject.UI.Entities
{
	public class Opinion
	{
		public Guid Id { get; set; }

		public string UserName { get; set; }
		public string Content { get; set; }
		public string CreatedAt { get; set; }

		public Guid BookId { get; set; }
		public virtual Book BookOpinion { get; set; }
	}
}