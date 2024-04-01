using DNDHelper.Stores;
using DNDHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Commands.NavigationCommands
{
    internal class NavigateHomeCommand:NavigateCommandBase
    {
        public NavigateHomeCommand(NavigationStore navigationStore, MainViewModel mainViewModel) : base(navigationStore, mainViewModel)
        {

        }

        public override void Execute(object? parameter)
        {
            navigationStore.CurrentViewModel = mainViewModel.HomeViewModel;
        }
    }
}
