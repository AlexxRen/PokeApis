using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApis.Resources.servicios
{
    internal class PokemonServices
    {
        public httpClient _httpClient;
        public PokeApis() 
        { 
            _httpClient = new httpClient();
        }
        public class PokemonAPIs
        {
            public async List<PokemonInfo> DevuelveListadoPokemones()
            {
                
                string url = "https://pokeapi.co/api/v2/evolution-chain?offset=0&limit=40";
                string json = await _httpClient.GetStringAsync(url);
            }
        }
    }
}
