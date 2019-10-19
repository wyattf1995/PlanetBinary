using Edi.Practice.RequestResponseModel;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PlanetBinary.Common.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlanetBinary.Services
{
	public class PlanetBinaryService
	{
		protected readonly ILogger<PlanetBinaryService> Logger;
		protected readonly BlogAppSettings BlogAppSettings;

		public PlanetBinaryService(ILogger<PlanetBinaryService> logger = null,
			IOptions<BlogAppSettings> settings = null)
		{
			if (null != settings) BlogAppSettings = settings.Value;
			if (null != logger) Logger = logger;
		}

		public Response TryExecute(Func<Response> func, [CallerMemberName] string callerMemberName = "", object keyParameter = null)
		{
			try
			{
				return func();
			}
			catch (Exception e)
			{
				Logger.LogError(e, $"Error executing {callerMemberName}({keyParameter})");
				throw;
			}
		}
		public Response<T> TryExecute<T>(Func<Response<T>> func, [CallerMemberName] string callerMemberName = "", object keyParameter = null)
		{
			try
			{
				return func();
			}
			catch (Exception e)
			{
				Logger.LogError(e, $"Error executing {callerMemberName}({keyParameter})");
				throw;
			}
		}
		public async Task<Response> TryExecuteAsync(Func<Task<Response>> func, [CallerMemberName] string callerMemberName = "", object keyParameter = null)
		{
			try
			{
				return await func();
			}
			catch (Exception e)
			{
				Logger.LogError(e, $"Error executing {callerMemberName}({keyParameter})");
				throw;
			}
		}
		public async Task<Response<T>> TryExecuteAsync<T>(Func<Task<Response<T>>> func,
			[CallerMemberName] string callerMemberName = "", object keyParameter = null)
		{
			try
			{
				return await func();
			}
			catch (Exception e)
			{
				Logger.LogError(e, $"Error executing {callerMemberName}({keyParameter})");
				throw;
			}
		}
	}
}
