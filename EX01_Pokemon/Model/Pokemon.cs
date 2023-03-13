using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace EX01_Pokemon.Model
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public string ImageUrl 
        {
            get
            {
                return $"http://static.pokemonpets.com/images/monsters-images-800-800/{Id}-{Name}.png";
            }
        }
    }
}
