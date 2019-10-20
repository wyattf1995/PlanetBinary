using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetBinary.Data.Entities
{
	public class BlogPostPublishEntity
	{
		public Guid PostId { get; set; }
		public bool IsPublished { get; set; }
		public DateTime? TimeLastModified { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime? PublishDate { get; set; }
		public int? Revision { get; set; }

		public virtual BlogPostEntity BlogPost { get; set; }
	}
}
