using DNDHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Commands
{
    internal class GetMonsterCommand : CommandBase
    {
        MonstersViewModel MonstersViewModel;
        public GetMonsterCommand(MonstersViewModel monstersViewModel) {
            this.MonstersViewModel = monstersViewModel;

        }

        public override void Execute(object? parameter)
        {
            if (parameter == null)
            {

            }else
            {
                MonstersViewModel.DisplaySpecificMonster((string)parameter);

            }
        }
    }
}
