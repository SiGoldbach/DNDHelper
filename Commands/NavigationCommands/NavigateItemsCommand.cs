using DNDHelper.Stores;
using DNDHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Commands.NavigationCommands
{
    internal class NavigateItemsCommand: NavigateCommandBase
    {
        public NavigateItemsCommand(NavigationStore navigationStore, MainViewModel mainViewModel) : base(navigationStore, mainViewModel)
        {

        }

        public override void Execute(object? parameter)
        {
            navigationStore.CurrentViewModel = mainViewModel.ItemsViewModel;
        }
    }
}
