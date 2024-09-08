using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class Concat
    {
        public static void ExecuteConcat()
        {
            //integer
            var i1 = JoinPurposeClass.single_num;
            var i2 = JoinPurposeClass.single_num2;

            var concatint = i1.Concat(i2);
            Console.WriteLine("After Concatenation : The Result for integer collection is ");
            foreach (var cint in concatint)
                Console.WriteLine(cint+"  ");

            //string
            var i3 = JoinPurposeClass.areaban4;
            var i4 = JoinPurposeClass.areaban5;

            var concatstr = i3.Concat(i4);
            Console.WriteLine("After Concatenation : The Result for string collection is ");
            foreach (var cstr in concatstr)
                Console.WriteLine(cstr + "  ");
        }
    }
}
