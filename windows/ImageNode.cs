using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NasaPicOfDay
{
   public class ImageNode
   {
      [JsonPropertyName("images")]
      public List<ImageNodeImage> ImageData { get; set; }

      [JsonPropertyName("ubernode")]
      public ImageNodeUber UberData { get; set; }
   }
}
