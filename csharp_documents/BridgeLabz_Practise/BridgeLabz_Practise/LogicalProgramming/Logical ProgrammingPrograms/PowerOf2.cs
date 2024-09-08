using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.Logical_ProgrammingPrograms
{
    public class PowerOf2
    {
        public static void PrintPowersOf2(int n)
        {
            Console.WriteLine($"Powers of 2 less than or equal to 2^{n}:");

            for (int i = 0; i <= n; i++)
            {
                double powerOf2 = Math.Pow(2, i);
                Console.WriteLine($"2^{i} = {powerOf2}");
            }
        }
        public static void EnterInput()
        {
            Console.WriteLine("Enter the value of n:");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
            {
                Console.WriteLine("Invalid input. Please provide a valid non-negative integer " +
                                  "value for n.");
                return;
            }

            PrintPowersOf2(n);
        }
    }
}
