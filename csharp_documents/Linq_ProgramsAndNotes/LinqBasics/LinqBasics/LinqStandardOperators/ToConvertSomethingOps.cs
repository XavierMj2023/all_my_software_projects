using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class ToConvertSomethingOps
    {
        public static void ToArrayToListOps()
        {
            var toArrayVar = ToConvertSomething.strList;
            
            // Convert List to Array
            string[] makearray = toArrayVar.ToArray<string>();

            //Convert Array into List
            IList<string> tolist = makearray.ToList<string>();

            Console.WriteLine("Actual Type is : " + toArrayVar.GetType().Name);

            Console.WriteLine("Actual Type is : " + makearray.GetType().Name);

            Console.WriteLine("Actual Type is : " + tolist.GetType().Name);
        }
    }
}
