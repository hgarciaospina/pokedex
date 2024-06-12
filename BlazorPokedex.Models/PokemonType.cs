using System.Text.Json.Serialization;

namespace BlazorPokedex.Models
{
    public class PokemonType
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}