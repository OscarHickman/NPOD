using System.Text.Json.Serialization;

namespace NasaPicOfDay
{
   public class ImageNodeImage
   {
      [JsonPropertyName("fid")]
      public string FId { get; set; }
      [JsonPropertyName("uid")]
      public string UId { get; set; }
      [JsonPropertyName("filename")]
      public string FileName { get; set; }
      [JsonPropertyName("uri")]
      public string Uri { get; set; }
      [JsonPropertyName("filemime")]
      public string FileMime { get; set; }
      [JsonPropertyName("filesize")]
      public string FileSize { get; set; }
      [JsonPropertyName("status")]
      public string Status { get; set; }
      [JsonPropertyName("timestamp")]
      public string TimeStamp { get; set; }
      [JsonPropertyName("uuid")]
      public string UuId { get; set; }
      [JsonPropertyName("alt")]
      public string Alt { get; set; }
      [JsonPropertyName("title")]
      public string Title { get; set; }
      [JsonPropertyName("width")]
      public string Width { get; set; }
      [JsonPropertyName("height")]
      public string Height { get; set; }
      [JsonPropertyName("crop1x1")]
      public string Crop1X1 { get; set; }
      [JsonPropertyName("crop2x1")]
      public string Crop2X1 { get; set; }
      [JsonPropertyName("crop2x2")]
      public string Crop2X2 { get; set; }
      [JsonPropertyName("crop3x1")]
      public string Crop3X1 { get; set; }
      [JsonPropertyName("crop1x2")]
      public string Crop1X2 { get; set; }
      [JsonPropertyName("crop4x3ratio")]
      public string Crop4X3Ratio { get; set; }
      [JsonPropertyName("cropHumongo")]
      public string CropHumongo { get; set; }
      [JsonPropertyName("cropBanner")]
      public string CropBanner { get; set; }
      [JsonPropertyName("cropUnHoriz")]
      public string CropUnHoriz { get; set; }
      [JsonPropertyName("cropUnVert")]
      public string CropUnVert { get; set; }
      [JsonPropertyName("fullWidthFeature")]
      public string FullWidthFeature { get; set; }
      [JsonPropertyName("lrThumbnail")]
      public string LrThumbnail { get; set; }
   }
}
