using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetBinary.Data.Entities
{
	public class BlogTagEntity
	{
		public int Id { get; set; }
		public string DisplayName { get; set; }
		public string NormalizedName { get; set; }

		public virtual ICollection<BlogPostTagEntity> BlogPostTag { get; set; }

		public BlogTagEntity()
		{
			var _BlogPostTag = new HashSet<BlogPostTagEntity>();
			BlogPostTag = _BlogPostTag;
		}
	}
}
