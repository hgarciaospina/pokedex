using BlazorPokedex.Models;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace BlazorPokedex.Services
{
    public class PokeApiClient : IPokeApiClient
    {
        private readonly HttpClient _httpClient;
        public PokeApiClient(HttpClient httpClient)
        {
         _httpClient = httpClient;   
        }
        public async Task<IEnumerable<Pokemon>> GetAllPokemons()
        {
            var pokemonList = JsonConvert.DeserializeObject<ResultObject>(
                await _httpClient.GetStringAsync($"pokemon?limit=24&ioffset=24"));

            var resultList = new List<Pokemon>();

            foreach (var poke in pokemonList.Pokemons)
                resultList.Add(await GetPokemon(poke.Name));

            return resultList;
        }

        public async Task<Pokemon> GetPokemon(string name)
        {
            return JsonConvert.DeserializeObject<Pokemon>(
                await _httpClient.GetStringAsync($"pokemon/{name}"));
        }
    }
}