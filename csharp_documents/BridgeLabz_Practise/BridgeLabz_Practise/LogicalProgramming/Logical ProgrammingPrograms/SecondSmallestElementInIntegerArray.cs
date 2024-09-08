using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.Logical_ProgrammingPrograms
{
    public class SecondSmallestElementInIntegerArray
    {
        public static void ExecuteSmall()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("The array should contain at least two elements.");
                return;
            }

            int[] arr = new int[n];

            // Input array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int firstMin = int.MaxValue;
            int secondMin = int.MaxValue;

            foreach (int num in arr)
            {
                if (num < firstMin)
                {
                    secondMin = firstMin;
                    firstMin = num;
                }
                else if (num < secondMin && num != firstMin)
                {
                    secondMin = num;
                }
            }

            Console.WriteLine("Second Smallest Element: " + secondMin);
        }
    }
}
