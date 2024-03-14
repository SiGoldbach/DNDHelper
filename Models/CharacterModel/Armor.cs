using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Models.CharacterModel
{
    public class Armor
    {

        string Name { get; set; }
        string Description { get; set; }
        public int acc { get; set; }
        int dexLimit {  get; set; }
        int strMinimum {  get; set; }

        bool dexBonus {  get; set; }

        public int maxDexBonus {  get; set; }
        ArmorType armorType { get; set; }



    }
}
