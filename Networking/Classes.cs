using DNDHelper.Models.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Networking
{
    public class Classes
    {
        int Count { get; set; }
        public List<IndexNameUrlJosnType> Resulsts { get; set; }

        public Classes(int count, List<IndexNameUrlJosnType> results) { 
            Count = count;
            Resulsts = results;
        }
    }
}
