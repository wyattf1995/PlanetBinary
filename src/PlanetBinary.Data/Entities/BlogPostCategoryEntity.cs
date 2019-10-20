using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetBinary.Data.Entities
{
	public class BlogPostCategoryEntity
	{
		public Guid PostId { get; set; }
		public Guid CategoryId { get; set; }

		public virtual BlogCategoryEntity BlogCategory { get; set; }
		public virtual BlogPostEntity BlogPost { get; set; }
	}
}
