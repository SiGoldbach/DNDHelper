using DNDHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Commands.NavigationCommands
{
    internal class SearchForMonsterCommand : CommandBase
    {
        public MonstersViewModel MonstersViewModel { get; set; }

        public SearchForMonsterCommand(MonstersViewModel monstersViewModel) { 
            this.MonstersViewModel = monstersViewModel;
        }
        public override void Execute(object? parameter)
        {
            MonstersViewModel.MonsterUrlAndNames = MonstersViewModel.SearchInMonsterList(MonstersViewModel.MonsterTabModel.SearchVal);

        }
    }
}
