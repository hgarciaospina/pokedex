using System.Text.Json.Serialization;

namespace BlazorPokedex.Models
{
    public class Pokemon
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("types")]
        public List<Type> Types { get; set; }
        [JsonPropertyName("sprites")]
        public List<Sprite> Sprites { get; set; }

    }
}