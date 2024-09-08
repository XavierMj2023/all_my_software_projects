using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics.LinqStandardOperators
{
    public class GenerationOperatorsRepeat
    {
        public static void RepeatOps()
        {
            var colrange = Enumerable.Repeat(5, 7);
            Console.WriteLine("The Numbers starting from 5 repeats 7 times are : ");

            for (int i = 0; i < colrange.Count(); i++)
            {
                Console.WriteLine($"Index : {i} ; Value : {colrange.ElementAt(i)}");
            }
            Console.WriteLine("---------------------");

            //For Total Use Count()
            Console.WriteLine($"Total Count : {colrange.Count()}");
        }
    }
}
