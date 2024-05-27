using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApis.Resources.models
{
    internal class PokemonApis
    {
        public HttpClient _HttpClient;
        public PokemonApis() 
        {
            _HttpClient = new HttpClient();
        
        }
    }
}
