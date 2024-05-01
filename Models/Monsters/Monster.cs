using DNDHelper.Models.Monsters.SpecialAbilities;
using DNDHelper.Models.Monsters.SpecialAbilities.StandardSpecialAbility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Models.Monsters
{
    //This class should is the class that i deserialze a monster down to so it should uphold the standard that is given from a monster gotten from the DND api used for this project
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

        public double Challenge_rating { get; set; }

        public int Proficiency_bonus { get; set; }

        public int Xp {  get; set; }

        public ObservableCollection<ProficiencyWithValue> Proficiencies { get; set; }

        public string Languages { get; set; }

        public ObservableCollection<SpecialAbilitiesParent> Special_abilities { get; set; }


        public Monster(string index, string name, string size,
                       string type, string desc, string alignment,
                       int strength, int dexterity, int constitution, int intelligence, 
                       int wisdom, int charisma, int hit_points, string hit_dice, ObservableCollection<ProficiencyWithValue> proficiencies,
                       double challenge_rating, int proficiency_bonus, int xp, string languages, ObservableCollection<SpecialAbilitiesParent> special_abilities)
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
            this.Challenge_rating = challenge_rating;
            this.Proficiency_bonus = proficiency_bonus;
            this.Xp = xp;
            this.Languages = languages;
            this.Special_abilities = special_abilities;
        }

        //Variables calculated afterwards that are therfore not in the constructor 

        public string  StrengthMod => CalculateModifierToString(Strength);
        public string DexterityMod => CalculateModifierToString(Dexterity);

        public string ConstitutionMod => CalculateModifierToString(Constitution);

        public string IntelligenceMod => CalculateModifierToString(Intelligence);

        public string WisdomMod => CalculateModifierToString(Wisdom);

        public string CharismaMod => CalculateModifierToString(Charisma);

        //Needs fix 
        private static string CalculateModifierToString(int statValue)
        {
            int modifier = ((statValue - 10) / 2);
            if (modifier > 0 ) {
                return "+" + modifier.ToString();
            }
            else
            {
                return modifier.ToString();
            }
        }
        public string ChallengeRatingAndEXPText => "Challenge rating: " + this.Challenge_rating + "; Xp: " + this.Xp;

        public string PrettyLanguages => LanguagePretty();

        public string LanguagePretty()
        {
            if (this.Languages.Equals(""))
            {
                return "Langauges: None";
            }
            else
            {
                return "Languages: " + this.Languages;

            }
        }
        
        


        //This method returns a "Mock" of a monster since when the application needs to start the initial monster cannot be null. 
        //This will not be a UX problem since there should always be a real monster when the user navigates to the site.
        //Getting a list of monsters and getting a monster from the api is part of what happens when the app initially starts 
        public static Monster MockMonster()
        {
            return new Monster("", "", "", "", "", "", 1, 1, 1, 1, 1, 1, 1, "", [], 0, 0, 0, "", []);
        }







    }

}
 

