using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NasaPicOfDay
{
   public static class DownloadHelper
   {
      private static readonly HttpClient HttpClient = new HttpClient();

      public static bool DownloadImage(string targetDirectory, string sourceUrl)
      {
         if (targetDirectory == null) throw new ArgumentNullException("targetDirectory");
         if (sourceUrl == null) throw new ArgumentNullException("sourceUrl");
         try
         {
            var task = Task.Run(async () => await DownloadImageAsync(targetDirectory, sourceUrl));
            task.Wait();
            return task.Result;
         }
         catch (Exception ex)
         {
            ExceptionManager.WriteException(ex);
            return false;
         }
      }

      private static async Task<bool> DownloadImageAsync(string targetDirectory, string sourceUrl)
      {
         try
         {
            var response = await HttpClient.GetAsync(sourceUrl);
            response.EnsureSuccessStatusCode();
            var bytes = await response.Content.ReadAsByteArrayAsync();
            await System.IO.File.WriteAllBytesAsync(targetDirectory, bytes);
            if (GlobalVariables.LoggingEnabled) ExceptionManager.WriteInformation("Image download completed");
            return true;
         }
         catch (Exception ex)
         {
            ExceptionManager.WriteException(ex);
            return false;
         }
      }
   }
}
