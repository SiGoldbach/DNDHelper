using DNDHelper.Stores;
using DNDHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Commands
{
    public class NavigateHomeCommand : CommandBase
    {
        private readonly NavigationStore navigationStore;

        public NavigateHomeCommand(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;

        }
        public override void Execute(object? parameter)
        {
            navigationStore.CurrentViewModel = new MonstersViewModel();
        }
    }
}
