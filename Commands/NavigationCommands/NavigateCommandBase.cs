using DNDHelper.Stores;
using DNDHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Commands.NavigationCommands
{
    public abstract class NavigateCommandBase : CommandBase
    {
        protected readonly NavigationStore navigationStore;
        protected readonly MainViewModel mainViewModel;

        public NavigateCommandBase(NavigationStore navigationStore, MainViewModel mainViewModel)
        {
            this.navigationStore = navigationStore;
            this.mainViewModel = mainViewModel;
        }
        public override void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
