using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetBinary.Data.Entities
{
	public class BlogCommentEntity
	{
		public Guid Id { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public string IPAddress { get; set; }
		public DateTime CreatedOn { get; set; }
		public string CommentContent { get; set; }
		public Guid BlogPostId { get; set; }
		public bool IsApproved { get; set; }
		public string UserAgent { get; set; }

		public virtual BlogPostEntity BlogPost { get; set; }
		public virtual ICollection<BlogCommentReplyEntity> BlogCommentReply { get; set; }

		public BlogCommentEntity()
		{
			var _BlogCommentReply = new HashSet<BlogCommentReplyEntity>();
			BlogCommentReply = _BlogCommentReply;
		}
	}
}
