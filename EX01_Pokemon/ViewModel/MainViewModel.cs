using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EX01_Pokemon.Model;
using EX01_Pokemon.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EX01_Pokemon.ViewModel
{
    public class MainViewModel: ObservableObject
    {
        public string CommandText 
        { 
            get
            {
                if (CurrentPage is OverViewPage)
                {
                    return "SHOW DETAILS";
                }
                else
                {
                    return "GO BACK";
                }
            } 
        }

        public OverViewPage MainPage { get; } = new OverViewPage();
        public DetailPage PokePage { get; } = new DetailPage();
        public Page CurrentPage { get; set; }

        public RelayCommand SwitchPageCommand { get; private set; }

        public void SwitchPage()
        {
            if(CurrentPage is OverViewPage)
            {
                Pokemon selectedPokemon = (MainPage.DataContext as OverViewVM).SelectedPokemon;
                if (selectedPokemon == null) return;

                (PokePage.DataContext as DetailPageVM).CurrentPokemon = selectedPokemon;

                CurrentPage = PokePage;
            }
            else
            {
                CurrentPage = MainPage;
            }

            OnPropertyChanged(nameof(CurrentPage));
            OnPropertyChanged(nameof(CommandText));
        }

        public MainViewModel()
        {
            CurrentPage = MainPage;
            SwitchPageCommand = new RelayCommand(SwitchPage);
        }

    }
}
