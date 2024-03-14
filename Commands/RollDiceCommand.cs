using DNDHelper.Model;
using DNDHelper.Models;
using DNDHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Commands
{
    internal class RollDiceCommand : CommandBase
    {
        CharacterViewModel characterViewModel;
        public RollDiceCommand(CharacterViewModel characterViewModel) { 
            this.characterViewModel = characterViewModel;
        }
        public override void Execute(object? parameter)
        {
            int roll = new DiceRoller().rollDice(20, 1, 0);
            characterViewModel.Dice_Roll = roll;


        }
    }
}
