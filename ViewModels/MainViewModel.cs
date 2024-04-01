using DNDHelper.Commands;
using DNDHelper.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DNDHelper.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        public ViewModelBase CurrentViewModel=>_navigationStore.CurrentViewModel;
        public CharacterViewModel CharacterViewModel { get; set; }
        public HomeViewModel HomeViewModel { get; set; }
        public ItemsViewModel ItemsViewModel { get; set; }
        public MonstersViewModel MonstersViewModel { get; set; }

        public ICommand NavigateToMonsterTab {  get; }



        public MainViewModel(NavigationStore navigationStore) { 
            this._navigationStore = navigationStore;
            this._navigationStore.CurrentViewModelChanged += OnCurrentViewModelChange;

            this.CharacterViewModel = new CharacterViewModel();
            this.HomeViewModel = new HomeViewModel();
            this.ItemsViewModel = new ItemsViewModel();
            this.MonstersViewModel = new MonstersViewModel();


            this.NavigateToMonsterTab = new NavigateMonsterCommand(this._navigationStore,this);

        }
        private void OnCurrentViewModelChange()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }


    }
}
