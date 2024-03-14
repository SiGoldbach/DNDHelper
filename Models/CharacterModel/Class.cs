using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Models.CharacterModel
{
    public class Class
    {
        int hitDie;
        List<String> Itemproficiencies;
        List<String> Skills;
        int speedFT;
        List<String> savingThrows;
        string spellCastingAbility;
        int[][] spellslots;
        Lazy<List<String>> spells;


    }
}
