using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NasaPicOfDay
{
	public static class NetworkHelper
	{
		private static readonly HttpClient HttpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };

		public static bool InternetAccessIsAvailable()
		{
			const string url = "https://www.nasa.gov";
			try
			{
				if (GlobalVariables.LoggingEnabled) ExceptionManager.WriteInformation("Building internet connectivity request.");
				if (GlobalVariables.LoggingEnabled) ExceptionManager.WriteInformation("Starting request.");
				
				var task = Task.Run(async () => await HttpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead));
				task.Wait();
				var response = task.Result;
				
				if (GlobalVariables.LoggingEnabled) ExceptionManager.WriteInformation(response.ToString());
				response.Dispose();
				if (GlobalVariables.LoggingEnabled) ExceptionManager.WriteInformation("Request completed.");
				return response.IsSuccessStatusCode;
			}
			catch (Exception ex)
			{
				if (GlobalVariables.LoggingEnabled) ExceptionManager.WriteInformation(string.Format("Error occurred checking internet connection:\t{0}", ex.Message));
				ExceptionManager.WriteException(ex);
				return false;
			}
		}
	}
}
