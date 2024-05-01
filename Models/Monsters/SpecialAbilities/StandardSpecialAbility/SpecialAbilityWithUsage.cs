using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Models.Monsters.SpecialAbilities.StandardSpecialAbility
{
    public class SpecialAbilityWithUsage: SpecialAbilitiesParent
    {
        public Usage Usage { get; set; }

        public SpecialAbilityWithUsage(string name, string desc, Usage usage): base(name,desc)
        {
            this.Usage = usage;

        }


    }
}
