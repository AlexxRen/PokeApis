﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApis.Resources.models
{
    internal class ResourceList
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List <PokemonInfo> results { get; set; }
    }
}
