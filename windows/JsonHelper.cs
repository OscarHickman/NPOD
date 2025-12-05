using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace NasaPicOfDay
{
   public static class JsonHelper
   {
      private static readonly HttpClient HttpClient = new HttpClient();
      private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
      {
         PropertyNameCaseInsensitive = true,
         DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
      };

      public static NasaImages DownloadSerializedJsonData(string nasaUrl)
      {
         try
         {
            var task = Task.Run(async () => await HttpClient.GetStringAsync(nasaUrl));
            task.Wait();
            var jsonData = task.Result;

            if (!string.IsNullOrEmpty(jsonData))
            {
               var images = JsonSerializer.Deserialize<NasaImages>(jsonData, JsonOptions);
               return images;
            }

            throw new Exception("Unable to retrieve JSON data");
         }
         catch (Exception ex)
         {
            ExceptionManager.WriteException(ex);
            return null;
         }
      }

      public static ImageNode DownloadImageData(string imageUrl)
      {
         try
         {
            var task = Task.Run(async () => await HttpClient.GetStringAsync(imageUrl));
            task.Wait();
            var jsonData = task.Result;

            if (!string.IsNullOrEmpty(jsonData))
            {
               var image = JsonSerializer.Deserialize<ImageNode>(jsonData, JsonOptions);
               return image;
            }

            throw new Exception("Unable to retrieve JSON data for image.");
         }
         catch (Exception ex)
         {
            ExceptionManager.WriteException(ex);
            return null;
         }
      }

      public static ApodImage DownloadApodData(string apodUrl)
      {
         try
         {
            var task = Task.Run(async () => await HttpClient.GetStringAsync(apodUrl));
            task.Wait();
            var jsonData = task.Result;

            if (!string.IsNullOrEmpty(jsonData))
            {
               var apodImage = JsonSerializer.Deserialize<ApodImage>(jsonData, JsonOptions);
               return apodImage;
            }

            throw new Exception("Unable to retrieve APOD JSON data.");
         }
         catch (Exception ex)
         {
            ExceptionManager.WriteException(ex);
            return null;
         }
      }
   }
}
