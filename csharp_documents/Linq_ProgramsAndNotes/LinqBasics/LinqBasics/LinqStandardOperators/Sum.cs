using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class Sum
    {
        public static void TotalSum()
        {
            var countnums = JoinPurposeClass.maxnums;
            var maxnum = countnums.Sum();
            var maxeve = countnums.Sum(maxeve =>
            {
                if (maxeve % 2 == 0)
                {
                    return maxeve;
                }
                return 0;
            });
            Console.Write("Total Sum : " + maxnum + "\n" + "Total Sum of Even Number : " + maxeve);
        }
        public static void CalculateAgeSum()
        {
            var countnums = Teenager.Teeages;
            var sumOfAge = countnums.Sum(sumag => sumag.Teeage);
            var howAdults = countnums.Sum(countadults =>
            {
                if(countadults.Teeage >= 21)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            );
            Console.Write("Sum Of Ages is : " + sumOfAge + "\n" + "How Many Adults? : " + howAdults);
        }
    }
}
