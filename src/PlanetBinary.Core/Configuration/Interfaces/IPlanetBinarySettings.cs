using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
namespace PlanetBinary.Core.Configuration.Interfaces
{
	public interface IPlanetBinarySettings
	{
		string GetJson();
	}

	public class PlanetBinarySettings : IPlanetBinarySettings
	{
		public string GetJson()
		{
			return JsonSerializer.Serialize(this);
		}
	}

}
