using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Models.Monsters
{
    public class DC
    {
        public int Dc_value { get; set; }
        public string Succes_type { get; set; }

        public IndexNameUrlJosnType Dc_type { get; set;}

        public DC(int dc_value, string succes_type, IndexNameUrlJosnType dc_type)
        {
            this.Dc_value = dc_value;
            this.Succes_type = succes_type;
            this.Dc_type = dc_type;
        }
    }
}
