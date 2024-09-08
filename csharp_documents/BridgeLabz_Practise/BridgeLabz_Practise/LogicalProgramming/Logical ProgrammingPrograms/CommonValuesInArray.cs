using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.Logical_ProgrammingPrograms
{
    public class CommonValuesInArray
    {
        public static void FindCommonBetween2Arrays()
        {
            // Define two arrays of string value
            string[] array1 = { "apple", "banana", "cherry", "date" };
            string[] array2 = { "cherry", "date", "fig", "grape" };

            // Find common elements using LINQ
            string[] comarray = array1.Intersect(array2).ToArray();

            // Check if there are common elements
            if(comarray.Length > 0)
            {
                Console.WriteLine("Common elements between the two arrays:");
                foreach(string com in comarray)
                {
                    Console.Write(com+" ");
                }
            }
            else
            {
                Console.WriteLine("No Elements Found");
            }
        }
    }
}
