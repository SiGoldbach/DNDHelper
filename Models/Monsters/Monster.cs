using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Models.Monsters
{
    public class Monster
    {
        //Variables gotten from the API
        public string Index { get; set; }
        public string Name { get; set;  }
        public string Size { get; set;  }
        public string Type { get; set;  }
        public string Desc { get; set; }

        public string Alignment { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }

        public int Constitution { get; set; }

        public int Intelligence { get; set; }

        public int Wisdom { get; set; }

        public int Charisma { get; set; }

        public int Hit_points {  get; set; }

        public string Hit_dice {  get; set; }

        public List<ProficiencyWithValue> Proficiencies { get; set; }


        public Monster(string index, string name, string size,
                       string type, string desc, string alignment,
                       int strength, int dexterity, int constitution, int intelligence, 
                       int wisdom, int charisma, int hit_points, string hit_dice, List<ProficiencyWithValue> proficiencies)
        {
            this.Index = index;
            this.Name = name;
            this.Size = size;
            this.Type = type;
            this.Desc = desc;
            this.Alignment = alignment;
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Constitution = constitution;
            this.Intelligence = intelligence;
            this.Wisdom = wisdom; 
            this.Charisma = charisma;
            this.Hit_points = hit_points;
            this.Hit_dice = hit_dice;
            this.Proficiencies = proficiencies;
        }

        //Variables calculated afterwards that are therfore not in the constructor 

        public string  StrengthMod => CalculateModifierToString(Strength);
        public string DexterityMod => CalculateModifierToString(Dexterity);

        public string ConstitutionMod => CalculateModifierToString(Constitution);

        public string IntelligenceMod => CalculateModifierToString(Intelligence);

        public string WisdomMod => CalculateModifierToString(Wisdom);

        public string CharismaMod => CalculateModifierToString(Charisma);


        private static string CalculateModifierToString(int statValue)
        {
            return "+" + ((statValue - 10) / 2).ToString();
        }


        //This method returns a "Mock" of a monster since when the application needs to start the initial monster cannot be null. 
        //This will not be a UX problem since there should always be a real monster when the user navigates to the site.
        //Getting a list of monsters and getting a monster from the api is part of what happens when the app initially starts 
        public static Monster MockMonster()
        {
            return new Monster("", "", "", "", "", "", 1, 1, 1, 1, 1, 1, 1, "", []);
        }







    }

}
 

