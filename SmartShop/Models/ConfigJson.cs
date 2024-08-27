using System.Text.Json.Serialization;

namespace SmartShop.Models
{
    public class ConfigJson
    {
        [JsonPropertyName("ConnectionString")]
        public string? ConnectionString { get; set; }
    }
}
