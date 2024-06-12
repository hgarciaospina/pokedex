using System.Text.Json.Serialization;

namespace BlazorPokedex.Models
{
    public class Sprite
    {
        [JsonPropertyName("front_default")]
        public string Front { get; set; }
        [JsonPropertyName("back_default")]
        public string Back { get; set; }
    }
}