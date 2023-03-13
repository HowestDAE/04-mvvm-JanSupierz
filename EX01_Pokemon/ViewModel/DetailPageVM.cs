﻿using CommunityToolkit.Mvvm.ComponentModel;
using EX01_Pokemon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using System.Xml.Linq;

namespace EX01_Pokemon.ViewModel
{
    internal class DetailPageVM: ObservableObject
    {
        public Pokemon CurrentPokemon { get; set; }
        = new Pokemon() 
        {
            Id = 136,
            Name = "Flareon",
            Type = "Fire",
            Height = 136,
            Weight = 9
        };
    }
}
