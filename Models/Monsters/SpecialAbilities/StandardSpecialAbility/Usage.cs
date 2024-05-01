using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Models.Monsters.SpecialAbilities
{
    public class Usage
    {
        public string Type { get; set; }
        public int Times { get; set; }

        public Usage(string type, int times) {
        this.Type = type;
        this.Times = times;
        }

        //If times is not relevant it is set to -1 since this makes senses in the business requirements meaning if times is -1 this constructor has been called. 
        public Usage(string type) {
            this.Type = type;
            this.Times = -1;
        }
    }
}
