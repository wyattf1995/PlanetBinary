using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanetBinary.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetBinary.Data.Configuration
{
	public class BlogPostConfiguration : IEntityTypeConfiguration<BlogPostEntity>
	{
		public void Configure(EntityTypeBuilder<BlogPostEntity> builder)
		{
			throw new NotImplementedException();
		}
	}
}
