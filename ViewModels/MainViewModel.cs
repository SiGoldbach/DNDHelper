using DNDHelper.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.ViewModels
{
    public class MainViewModel
    {
        private readonly NavigationStore navigationStore;
        public ViewModelBase CurrentViewModel=>navigationStore.CurrentViewModel;
        public CharacterViewModel CharacterViewModel { get; set; }
        public HomeViewModel HomeViewModel { get; set; }
        public ItemsViewModel ItemsViewModel { get; set; }
        public MonstersViewModel MonstersViewModel { get; set; }



        public MainViewModel(NavigationStore navigationStore) { 
            this.navigationStore = navigationStore;
        }

    }
}
