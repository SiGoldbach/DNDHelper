using DNDHelper.Stores;
using DNDHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Commands
{
    public class NavigateMonsterCommand : CommandBase
    {
        private readonly NavigationStore navigationStore;
        private readonly MainViewModel mainViewModel;

        public NavigateMonsterCommand(NavigationStore navigationStore, MainViewModel mainViewModel)
        {
            this.navigationStore = navigationStore;
            this.mainViewModel = mainViewModel;
        }
        public override void Execute(object? parameter)
        {
            navigationStore.CurrentViewModel = mainViewModel.MonstersViewModel;
        }
    }
}
