using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetBinary.Data.Entities
{
	public class BlogCategoryEntity
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string DisplayName { get; set; }
		public string Description { get; set; }

		public virtual ICollection<BlogPostCategoryEntity> BlogPostCategory { get; set; }

		public BlogCategoryEntity()
		{
			var _BlogPostCategory = new HashSet<BlogPostCategoryEntity>();
			BlogPostCategory = _BlogPostCategory;
		}
	}
}
