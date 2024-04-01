using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DNDHelper.Models.Monsters
{
    [Serializable()]
    internal class MonsterURLAndName
    {
        public string index;
        public string name;
        public string ResourcePath;

        public MonsterURLAndName(string index, string name, string ResourcePath)
        {
            this.index = index;
            this.name = name;
            this.ResourcePath = ResourcePath;
        }
    }
}
