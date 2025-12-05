using System.Text.Json.Serialization;

namespace NasaPicOfDay
{
	public class NasaImages
	{
		[JsonPropertyName("ubernodes")]
		public UberNode[] UberNodes { get; set; }

		[JsonPropertyName("meta")]
		public UberMeta Meta { get; set; }
	}
}
