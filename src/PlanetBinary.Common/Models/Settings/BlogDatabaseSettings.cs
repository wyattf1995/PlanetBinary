using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetBinary.Core.Configuration
{
	public class BlogDatabaseSettings
	{
		public int Id { get; set; }
		public string ConfigurationKey { get; set; }
		public string ConfigurationValue { get; set; }
		public DateTime? TimeLastModified { get; set; }
	}
}
