using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EX01_Pokemon.Model;
using EX01_Pokemon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01_Pokemon.ViewModel
{
    public class OverViewVM: ObservableObject
    {
        public List<string> PokemonTypes { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        private string _selectedType;

        public string SelectedType
        {
            get { return _selectedType; }
            set 
            { 
                Pokemons = PokemonRepository.GetPokemons(value);
                OnPropertyChanged(nameof(Pokemons));

                _selectedType = value;
            }
        }

        private Pokemon _selectedPokemon;

        public Pokemon SelectedPokemon
        {
            get { return _selectedPokemon; }
            set { _selectedPokemon = value; }
        }

        public OverViewVM()
        {
            Pokemons = PokemonRepository.GetPokemons();
            PokemonTypes = PokemonRepository.GetPokemonTypes();
        }
    }
}
