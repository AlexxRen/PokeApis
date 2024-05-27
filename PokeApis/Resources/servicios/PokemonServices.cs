using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApis.Resources.servicios
{
    internal class PokemonServices
    {
        public class PokemonAPIs
        {
            public async List<PokemonInfo> DevuelveListadoPokemones()
            {
                string url = "https://pokeapi.co/api/v2/evolution-chain?offset=20&limit=20";
                string json = await 
            }
        }
    }
}
