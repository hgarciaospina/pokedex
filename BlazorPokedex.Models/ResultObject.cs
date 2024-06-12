using System.Text.Json.Serialization;

namespace BlazorPokedex.Models
{
    public class ResultObject
    {
        [JsonPropertyName("results")]
        public IEnumerable<Pokemon> Pokemons { get; set; }
    }
}
