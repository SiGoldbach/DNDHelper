using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Models.Monsters
{
    public class SpecialAbilityWithDCheck: SpecialAbilitiesParent
    {
        public DC Dc { get; set; }

        public SpecialAbilityWithDCheck(string name,string desc,DC dc): base(name,desc)
        {
            Dc = dc;
        }
    }
}
