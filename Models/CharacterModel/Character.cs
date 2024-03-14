using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DNDHelper.Models.CharacterModel
{
    //In this class only variales that change because of player behavior should exist
    public class Character
    {
        public string Name { get; set; }
        public int Lvl { get; set; }
        public int Hp { get; set; }

        public int proficiencyBonus => calculateProficienyBonus();

        Stat STR;
        Stat DEX;
        Stat CON;
        Stat WIS;
        Stat INT;
        Stat CHA;

        List<string> equipment;

        Class Clas { get; set; }

        Armor armor { get; set; }

        int Ac => calculateAcc();

        private int calculateAcc()
        {
            int dexBonus() => armor.maxDexBonus < DEX.statModifier ? armor.maxDexBonus : DEX.statModifier;
            return armor.acc + dexBonus();


        }
        private int calculateProficienyBonus()
        {
            if (Lvl <= 4)
            {
                return 2;
            }
            else if (Lvl <= 8)
            {
                return 3;

            }
            else if (Lvl <= 12)
            {
                return 4;
            }
            else if (Lvl <= 16)
            {
                return 5;
            }
            else
            {
                return 6;
            }


        }




        public Character(string name, int lvl, int hp)
        {
            Name = name;
            Lvl = lvl;
            Hp = hp;

        }
    }

















}

