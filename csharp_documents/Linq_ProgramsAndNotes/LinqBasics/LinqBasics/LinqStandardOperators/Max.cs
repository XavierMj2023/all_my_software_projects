using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class Max
    {
        public static void MaxNumber()
        {
            var countnums = JoinPurposeClass.maxnums;
            var maxnum = countnums.Max();
            var maxeve = countnums.Max(maxeve =>
            {
                if(maxeve % 2 == 0)
                {
                    return maxeve;
                }
                return 0;
            });
            Console.Write("Max Number : " + maxnum + "\n" + "Max Even Number : " + maxeve);
        }
        public static void FindLargest()
        {
            var countnums = Teenager2.Teeages;
            var maxnum = countnums.Max();
            Console.Write("Teenager Name : " + maxnum.Teename + "\n" + "Teenager Age : " + maxnum.Teeage);
        }
    }
}
