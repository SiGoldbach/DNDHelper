using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Models.Monsters.SpecialAbilities
{
    public class SpecialAbilityHolder
    {
        public ObservableCollection<SpecialAbilitiesParent> Special_abilities {  get; set; }

        public SpecialAbilityHolder(ObservableCollection<SpecialAbilitiesParent> special_abilities) {
            this.Special_abilities = special_abilities;

        }
    }
}
