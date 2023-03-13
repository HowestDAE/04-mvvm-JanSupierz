using EX01_Pokemon.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01_Pokemon.Repository
{
    public class PokemonRepository
    {
        private static List<Pokemon> _pokemons;

        public static List<Pokemon> GetPokemons()
        {
            if( _pokemons != null )
            {
                return _pokemons;
            }

            //Read only once
            string json = File.ReadAllText("../../Resources/Data/pokemons.json");
            _pokemons = JToken.Parse(json).ToObject<List<Pokemon>>();

            return _pokemons;
        }

        public static List<string> GetPokemonTypes()
        {
            if( _pokemons == null )
            {
                GetPokemons();
            }

            List<string> types = _pokemons.Select(pokemon => pokemon.Type).Distinct().ToList();
            types.Add("All types");

            return types;
        }

        public static List<Pokemon> GetPokemons(string type) 
        {
            if( _pokemons == null ) 
            {
                GetPokemons();
            }

            if(type.Equals("All types"))
            {
                return GetPokemons();
            }

            return _pokemons.Where(pokemon => pokemon.Type.Equals(type)).ToList();
        }
    }
}
