using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Models
{
    public sealed class DiceRoller
    {
        private readonly Random rand = new();

        public DiceRoller() { }

        public int RollPercentage()
        {
            return rand.Next(1, 101);

        }
        public int rollDice(int dx, int diceAmount, int modifier)
        {
            int rollValue = 0;
            for (int i = 0; i < diceAmount; i++)
            {
                rollValue += rand.Next(1, dx + 1);
            }
            return rollValue + modifier;


        }



    }
}
