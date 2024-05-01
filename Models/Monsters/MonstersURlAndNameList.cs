using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

//This class cannot get serialized if it has a constructor it makes little sense.
//So it does not have a constructor 
namespace DNDHelper.Models.Monsters
{
    public class MonstersURlAndNameList
    {
        public int Count { get; set;}
        public List<IndexNameUrlJosnType> Results { get; set; }

        public MonstersURlAndNameList(int count, List<IndexNameUrlJosnType> Results)
        {
            this.Count = count; 
            this.Results=Results;
        }

    }
}
