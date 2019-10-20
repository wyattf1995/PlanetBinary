using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetBinary.Data.Entities
{
	public class BlogPostEntity
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Slug { get; set; }
		public DateTime CreatedOn { get; set; }
	}
}
