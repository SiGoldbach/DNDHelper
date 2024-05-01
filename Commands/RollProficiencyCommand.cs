using DNDHelper.Models;
using DNDHelper.Models.Monsters;
using DNDHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Commands
{
    class RollProficiencyCommand : CommandBase
    {
        MonstersViewModel monstersViewModel;
        public RollProficiencyCommand(MonstersViewModel monstersViewModel) {
            this.monstersViewModel= monstersViewModel;
        }
        public override void Execute(object? parameter)
        {
            if (parameter is ProficiencyWithValue proficiencyWithValue)
            {
                monstersViewModel.ProficiencyRoll = new ProficiencyRoll(proficiencyWithValue.Proficiency.Name, proficiencyWithValue.Value);

            }
            else
            {
                Console.WriteLine("parameter was null");
            }
        }
    }
}
