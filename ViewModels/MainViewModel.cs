﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.ViewModels
{
    public class MainViewModel
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel() { 
            CurrentViewModel = new CharacterViewModel();
        }

    }
}
