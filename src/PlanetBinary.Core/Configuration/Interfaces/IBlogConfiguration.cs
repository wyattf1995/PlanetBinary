using Edi.Practice.RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlanetBinary.Core.Configuration.Interfaces
{
	public interface IBlogConfiguration
	{
		BlogSettings BlogSettings { get; set;}

		Task<Response> SaveConfigurationAsync<T>(T planetbinarySettings) where T : IPlanetBinarySettings;
	}
}
