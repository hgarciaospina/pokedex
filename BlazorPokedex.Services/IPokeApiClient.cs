using BlazorPokedex.Models;

namespace BlazorPokedex.Services
{
    public interface IPokeApiClient
    {
        Task<IQueryable<Pokemon>> GetAllPokemons();
        Task<Pokemon> GetPokemon(string name);
    }
}