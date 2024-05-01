using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DNDHelper.Models.Monsters.SpecialAbilities
{
    public class SpecialAbilityTemplateSelector: DataTemplateSelector
    {
        public override DataTemplate
            SelectTemplate(object item, DependencyObject container)
        {
            if (container is FrameworkElement element && item != null && item is SpecialAbilitiesParent)
            {
                SpecialAbilitiesParent taskitem = item as SpecialAbilitiesParent;

                if (taskitem.DataTemplate == 0)
                    return
                        element.FindResource("BasicSpecialAbility") as DataTemplate;
                else
                    return
                        element.FindResource("SpecialAbilityWithDc") as DataTemplate;
            }

            return null;
        }
    }
}
