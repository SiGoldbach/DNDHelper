using DNDHelper.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DNDHelper.ViewModels
{
    public class CharacterViewModel: ViewModelBase
    {
        private int DiceRoll;

        public int Dice_Roll
        {
            get { return DiceRoll;  }
            set { 
                DiceRoll = value;
                OnPropertyChanged(nameof(Dice_Roll));

            }
        }


        public ICommand RollD20 { get; }
        public CharacterViewModel() {
            RollD20 = new RollDiceCommand(this);
        
        }
       

    }
}
