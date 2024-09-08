using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics.LinqStandardOperatorsClasses
{
    public class Teenager
    {
        public string Teename { get; set; }
        public int Teeage { get; set; }
        public static IList<Teenager> Teeages = new List<Teenager>()
        {
            new Teenager(){Teeage = 21,Teename = "Gourav"},
            new Teenager(){Teeage = 20,Teename = "Ganesh"},
            new Teenager(){Teeage = 21,Teename = "Miller"},
            new Teenager(){Teeage = 13,Teename = "Sourav"},
            new Teenager(){Teeage = 10,Teename = "Keerthi"},
            new Teenager(){Teeage = 11,Teename = "Leon"}
        };
    }
}
