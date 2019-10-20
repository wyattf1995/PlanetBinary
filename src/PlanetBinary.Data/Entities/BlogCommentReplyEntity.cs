using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetBinary.Data.Entities
{
	public class BlogCommentReplyEntity
	{
		public Guid Id { get; set; }
		public string ReplyContent { get; set; }
		public DateTime ReplyTime { get; set; }
		public string UserAgent { get; set; }
		public string IpAddress { get; set; }
		public Guid? CommentId { get; set; }

		public virtual BlogCommentEntity Comment { get; set; }
	}
}
