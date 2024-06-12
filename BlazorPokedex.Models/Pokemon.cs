using System.Text.Json.Serialization;

namespace BlazorPokedex.Models
{
    public class Pokemon
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = "";
        [JsonPropertyName("height")]
        public int Height { get; set; }
        [JsonPropertyName("weight")]
        public int Weight { get; set; }
        [JsonPropertyName("base_experience")]
        public int Experience { get; set; }
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("types")]
        public List<Type> Types { get; set; }
        [JsonPropertyName("sprites")]
        public Sprite Sprite { get; set; }
    }
}