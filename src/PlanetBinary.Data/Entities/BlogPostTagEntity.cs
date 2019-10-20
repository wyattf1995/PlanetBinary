using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetBinary.Data.Entities
{
	public class BlogPostTagEntity
	{
		public Guid PostId { get; set; }
		public int TagId { get; set; }

		public virtual BlogPostEntity Post { get; set; }
		public virtual BlogTagEntity Tag { get; set; }
	}
}
