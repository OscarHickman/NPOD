using System.Text.Json.Serialization;

namespace NasaPicOfDay
{
    public class UberNode
    {
        [JsonPropertyName("type")]
        public string UberNodeType { get; set; }

        [JsonPropertyName("nid")]
        public string UberNodeId { get; set; }

        [JsonPropertyName("promoDateTime")]
        public string UberPromoData { get; set; }
    }
}
