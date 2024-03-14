using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Models.CharacterModel
{
    internal class Stat
    {
        public int statValue { get; set; }
        public int statModifier => calculateModifier();

        statTypes statType;

        public Stat(int statValue, statTypes statType)
        {
            this.statValue = statValue;
            this.statType = statType;
        }


        private int calculateModifier()
        {
            return (statValue - 10) / 2;
        }





    }
}
