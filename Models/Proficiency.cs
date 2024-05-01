using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDHelper.Models
{

    public class ProficiencyWithValue
    {
        public int Value { get; set; }
        public Proficiency Proficiency { get; set; }

        public ProficiencyWithValue(int value, Proficiency proficiency)
        {
            this.Value = value;
            this.Proficiency = proficiency;

        }
        public string Pretty => ToString();
        public override string ToString()
        {
            return this.Proficiency.Name+ ": "+Value;
        }

    }

    public class Proficiency
    {
        public string Index {  get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public Proficiency(string index, string name, string url) { 
            this.Index = index;
            this.Name = name;
            this.Url = url;
        }

    }
}
