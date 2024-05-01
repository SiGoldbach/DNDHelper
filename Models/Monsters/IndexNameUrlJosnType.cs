using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DNDHelper.Models.Monsters
{
    public class IndexNameUrlJosnType
    {
        public string Index { get; set;}
        public string Name { get; set; }
        public string Url { get; set; }

        public IndexNameUrlJosnType(string index, string name, string url)
        {
            this.Index = index;
            this.Name = name;
            this.Url = url;

        }
    }
}
