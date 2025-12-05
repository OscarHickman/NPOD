using System.Text.Json.Serialization;

namespace NasaPicOfDay
{
   public class ImageNodeUber
   {
      [JsonPropertyName("title")]
      public string Title { get; set; }
      [JsonPropertyName("nid")]
      public string NId { get; set; }
      [JsonPropertyName("type")]
      public string Type { get; set; }
      [JsonPropertyName("changed")]
      public string Changed { get; set; }
      [JsonPropertyName("uuid")]
      public string UuId { get; set; }
      [JsonPropertyName("body")]
      public string Body { get; set; }
      [JsonPropertyName("name")]
      public string Name { get; set; }
      [JsonPropertyName("uri")]
      public string Uri { get; set; }
      [JsonPropertyName("collections")]
      public object[] Collections { get; set; }
      [JsonPropertyName("enableComments")]
      public string EnableComments { get; set; }
      [JsonPropertyName("linkOrAttachment")]
      public string LinkOrAttachment { get; set; }
      [JsonPropertyName("masterImage")]
      public string MasterImage { get; set; }
      [JsonPropertyName("missions")]
      public object[] Missions { get; set; }
      [JsonPropertyName("primaryTag")]
      public string PrimaryTag { get; set; }
      [JsonPropertyName("promoDateTime")]
      public string PromoDateTime { get; set; }
      [JsonPropertyName("routes")]
      public object[] Routes { get; set; }
      [JsonPropertyName("secondaryTag")]
      public string SecondaryTag { get; set; }
      [JsonPropertyName("topics")]
      public object[] Topics { get; set; }
      [JsonPropertyName("ubernodeImage")]
      public string UberNodeImage { get; set; }
      [JsonPropertyName("ubernodeType")]
      public string UberNodeType { get; set; }
      [JsonPropertyName("imageFeatureCaption")]
      public string ImageFeatureCaption { get; set; }
      [JsonPropertyName("cardfeedTitle")]
      public string CardFeedTitle { get; set; }
      [JsonPropertyName("onS3")]
      public string OnS3 { get; set; }
   }
}
