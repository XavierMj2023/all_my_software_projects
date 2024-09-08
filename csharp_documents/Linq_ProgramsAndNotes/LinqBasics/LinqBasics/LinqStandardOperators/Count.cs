using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class Count
    {
        public static void CountNums()
        {
            var countnums = JoinPurposeClass.tnums;
            var multipleof5 = countnums.Count(five => five % 5 == 0);
            var multipleof2 = countnums.Count(two => two % 2 == 0);
            Console.Write("Multiple of 2 : "+multipleof2+"\n"+"Multiple of 5 is : "+multipleof5);
        }
        public static void CountTeens()
        {
            var coteens = Teenager.Teeages;
            var count_teens = coteens.Count();
            var countteens_young = coteens.Count(countyoung => countyoung.Teeage >= 15);
            Console.WriteLine("Number of Teenagers : "+count_teens+"\n"+"Number of Young Teenagers : " +
                +countteens_young);
        }
        public static void CountTeensWrapQuerySyntax()
        {
            var coteens = Teenager.Teeages;
            var countteens = (from te in coteens
                                    select te.Teeage).Count();
            Console.WriteLine("Number of Teenagers : " + countteens);
        }
    }
}
