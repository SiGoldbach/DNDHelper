using DNDHelper.Stores;
using DNDHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Commands.NavigationCommands
{
    public class NavigateMonsterCommand : NavigateCommandBase
    {


        public NavigateMonsterCommand(NavigationStore navigationStore, MainViewModel mainViewModel) : base(navigationStore, mainViewModel)
        {

        }

        public override void Execute(object? parameter)
        {
            navigationStore.CurrentViewModel = mainViewModel.MonstersViewModel;
        }
    }
}
