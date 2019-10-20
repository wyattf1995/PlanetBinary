using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetBinary.Common.Models
{
	public class BlogPost
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public DateTime CreatedOn { get; set; }
		public bool IsPublished { get; set; }
	}
}
