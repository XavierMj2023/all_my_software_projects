using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics.LinqStandardOperatorsClasses
{
    public class Teenager2:IComparable<Teenager2>
    {
        public string Teename { get; set; }
        public int Teeage { get; set; }
        public static IList<Teenager2> Teeages = new List<Teenager2>()
        {
            new Teenager2(){Teeage = 21,Teename = "Gourav"},
            new Teenager2(){Teeage = 20,Teename = "Ganesh"},
            new Teenager2(){Teeage = 21,Teename = "Miller"},
            new Teenager2(){Teeage = 13,Teename = "Sourav"},
            new Teenager2(){Teeage = 10,Teename = "Keerthi"},
            new Teenager2(){Teeage = 11,Teename = "Leon"}
        };

        public int CompareTo(Teenager2 other)
        {
            if(this.Teename.Length >= other.Teename.Length)
                return 1;

            return 0;
        }
    }
}
