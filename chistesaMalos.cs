// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System.Text.Json.Serialization;
namespace Chistes;
    
    public class Flags
    {
        [JsonPropertyName("nsfw")]
        public bool nsfw { get; set; }

        [JsonPropertyName("religious")]
        public bool religious { get; set; }

        [JsonPropertyName("political")]
        public bool political { get; set; }

        [JsonPropertyName("racist")]
        public bool racist { get; set; }

        [JsonPropertyName("sexist")]
        public bool sexist { get; set; }

        [JsonPropertyName("explicit")]
        public bool @explicit { get; set; }
    }

    public class unChiste
    {
        [JsonPropertyName("error")]
        public bool error { get; set; }

        [JsonPropertyName("category")]
        public string category { get; set; }

        [JsonPropertyName("type")]
        public string type { get; set; }

        [JsonPropertyName("joke")]
        public string joke { get; set; }

        [JsonPropertyName("flags")]
        public Flags flags { get; set; }

        [JsonPropertyName("safe")]
        public bool safe { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("lang")]
        public string lang { get; set; }
    }
