using System.Text.Json.Serialization;

namespace BlazorPokedex.Models
{
    public class Type
    {
        [JsonPropertyName("slot")]
        public int Slot { get; set; }
        [JsonPropertyName("type")]
        public PokemonType PokemonType { get; set; } 
    }
}