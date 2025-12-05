using System.Text.Json.Serialization;

namespace NasaPicOfDay
{
   public class UberMeta
   {
      [JsonPropertyName("total_rows")]
      public string TotalRows { get; set; }
   }
}
