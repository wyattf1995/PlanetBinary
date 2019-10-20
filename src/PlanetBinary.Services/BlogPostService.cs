using PlanetBinary.Data.BaseStructure;
using PlanetBinary.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetBinary.Services
{
	public class BlogPostService : PlanetBinaryService
	{
		private readonly IBlogRepository<BlogPostEntity> _postRepository;
		private readonly IBlogRepository<BlogPostExtensionEntity> _postExtensionRepository;
		private readonly IBlogRepository<BlogPostPublishEntity> _postPublishRepository;
		private readonly IBlogRepository<BlogTagEntity> _tagRepository;
		private readonly IBlogRepository<BlogPostTagEntity> _postTagRepository;
		private readonly IBlogRepository<BlogCategoryEntity> _categoryRepository;
		private readonly IBlogRepository<BlogPostCategoryEntity> _postCategoryRepository;
	}
}
