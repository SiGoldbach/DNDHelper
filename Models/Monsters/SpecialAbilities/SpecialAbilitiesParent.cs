using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Models.Monsters
{
    //This is the base class for a special ability this is not abstract since some special ability has this structure and has atleast this structure to be a special ability. 
    public class SpecialAbilitiesParent
    {
        public string Name { get; set; }
        public string Desc { get; set; }

        public int DataTemplate {  get; set; }




        public SpecialAbilitiesParent(string name, string desc)
        {
            this.Name = name;
            this.Desc = desc;
            this.DataTemplate = 0;
        }





    }
}
