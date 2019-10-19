using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using PlanetBinary.Core.Configuration.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using PlanetBinary.Common.Models;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using Edi.Practice.RequestResponseModel;
using System.Linq;

namespace PlanetBinary.Core.Configuration
{
	public class BlogConfiguration : IBlogConfiguration
	{
		private readonly ILogger<BlogConfiguration> _logger;
		private readonly IConfiguration _configuration;
		public BlogSettings BlogSettings { get; set; }
		private bool HasBeenInitialized { get; set; }

		public BlogConfiguration(ILogger<BlogConfiguration> logger, IConfiguration configuration)
		{
			_logger = logger;
			_configuration = configuration;
		}

		public async Task<Response> SaveConfigurationsAsync<T>(T planetbinarySettings) where T : IPlanetBinarySettings
		{
			async Task<int> SetConfiguration(string key, string value)
			{
				var connectionString = _configuration.GetConnectionString(Constants.DatabaseConnectionName);
				using (var connection = new SqlConnection(connectionString))
				{
					string sql = $"UPDATE {nameof(BlogDatabaseSettings)}" +
								 $"SET {nameof(BlogDatabaseSettings.ConfigurationValue)} = @value, {nameof(BlogDatabaseSettings.TimeLastModified)} = @TimeLastModified " +
								 $"WHERE {nameof(BlogDatabaseSettings.ConfigurationKey)} = @key";

					return await connection.ExecuteAsync(sql, new { key, value, TimeLastModified = DateTime.UtcNow });
				}
			}

			try
			{
				var json = planetbinarySettings.GetJson();
				int rows = await SetConfiguration(typeof(T).Name, json);
				return new Response(rows > 0);
			}
			catch (Exception e)
			{
				_logger.LogError(e, e.Message);
				throw;
			}
		}

		private IDictionary<string, string> GetConfigurations()
		{
			try
			{
				var connectionString = _configuration.GetConnectionString(Constants.DatabaseConnectionName);
				using (var connection = new SqlConnection(connectionString))
				{
					string sql = $"SELECT ConfigurationKey, ConfigurationValue FROM {nameof(BlogDatabaseSettings)}";
					var data = connection.Query<(string ConfigurationKey, string ConfigurationValue)>(sql);
					var dictionary = data.ToDictionary(x => x.ConfigurationKey, x => x.ConfigurationValue);
					return dictionary;
				}
			}
			catch (Exception e)
			{
				_logger.LogCritical(e, $"Error {nameof(GetConfigurations)}");
				throw;
			}
		}



	}
}
