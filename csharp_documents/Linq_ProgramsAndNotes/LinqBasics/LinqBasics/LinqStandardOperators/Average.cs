using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class Average
    {
        public static void AverageExe()
        {
            var evs = JoinPurposeClass.evenmums;
            var avgevs = evs.Average();
            Console.WriteLine("Average of Numbers are:" + avgevs);
        }
        public static void AverageAgeOfTeenager()
        {
            var tvs = Teenager.Teeages;
            var avgevs = tvs.Average(teeag => teeag.Teeage);
            Console.WriteLine("Average of Teenagers age is : " + avgevs);
        }
    }
}
