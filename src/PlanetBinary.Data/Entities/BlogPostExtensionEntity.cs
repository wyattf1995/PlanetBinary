using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetBinary.Data.Entities
{
	public class BlogPostExtensionEntity
	{
		public Guid PostId { get; set; }
		public int Hits { get; set; }
		public int Likes { get; set; }

		public virtual BlogPostEntity BlogPost { get; set; }
	}
}
