using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Models.Monsters
{
    public class ProficiencyRoll
    {
        public string Name {  get; set; }
        public int Value { get; set; }
        readonly private DiceRoller? Dice;

        public int NatValue { get; set; }

        public ProficiencyRoll(string name, int bonus)
        {
            Dice = new DiceRoller();
            this.Name = name;
            this.NatValue = Dice.rollDice(20, 1, 0);
            this.Value = this.NatValue + bonus;
        }

        //The next constructor and static method is to make a mock in the viewmodel to avoid dealing with null or late init. 
        private ProficiencyRoll()
        {
            this.Name = "";
            this.Value = 0;
            this.NatValue = 0;

        }
        public static ProficiencyRoll MockProficiencyRoll()
        {
            return new ProficiencyRoll();

        }
        public string Pretty => ToString();
        public override string ToString()
        {
            return "Last skill roll: \n"+"("+Name+")"+", Natural: "+this.NatValue+ " Value: "+this.Value;
        }




    }
}
