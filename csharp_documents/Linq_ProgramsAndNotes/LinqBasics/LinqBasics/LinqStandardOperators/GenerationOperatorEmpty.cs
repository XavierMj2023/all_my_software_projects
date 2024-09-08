using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class GenerationOperatorEmpty
    {
        public static void EmptyOp()
        {
           //primitive data type
           var coll1 = Enumerable.Empty<int>();
           var coll2 = Enumerable.Empty<string>();
           var coll3 = Enumerable.Empty<double>();

           //object
           var collobj = Enumerable.Empty<JoinPurposeClass>();

           //Int :EmptyPartition`1 Count : 0
           //String Interpolation
           Console.WriteLine($"Int :{coll1.GetType().Name} Count : {coll1.Count()}");
           Console.WriteLine($"String :{coll2.GetType().Name} Count : {coll2.Count()}");
           Console.WriteLine($"Double :{coll3.GetType().Name} Count : {coll3.Count()}");
           Console.WriteLine($"Object :{collobj.GetType().Name} Count : {collobj.Count()}");
        }
    }
}
