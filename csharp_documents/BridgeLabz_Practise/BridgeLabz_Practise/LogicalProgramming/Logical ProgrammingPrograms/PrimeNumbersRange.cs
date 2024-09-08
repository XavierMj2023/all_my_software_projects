using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.Logical_ProgrammingPrograms
{
    public class PrimeNumRangeOps
    {
        public static bool IsPrimeBackup(int number)
        {
            if (number <= 1)
            {
                return false; // 0 and 1 are not prime
            }
            if (number <= 3)
            {
                return true; // 2 and 3 are prime
            }
            if (number % 2 == 0)
            {
                return false; // Even numbers greater than 2 are not prime
            }

            // Check for divisibility starting from 5 and incrementing by 2
            for (int i = 5; i * i <= number; i += 2)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static bool IsPrime(int number)
        {
            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            //This is for Checking Big Numbers
            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }
        public static void FindPrimesInRange(int start, int end)
        {
            // Reason of this if condition its because it helps IsPrime() for second condition
            // if (number <= 3)
            // return true;
            if (start < 2)
                start = 2;

            Console.WriteLine($"Prime numbers between {start} and {end}:");
            for (int num = start; num <= end; num++)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                }
            }
        }
        public static void RangeData()
        {
            Console.Write("Enter the starting number: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending number: ");
            int end = int.Parse(Console.ReadLine());

            FindPrimesInRange(start, end);
        }
    }
    public class PrimeNumbersRange
    {
        public static void ExecutePrimey()
        {
            PrimeNumRangeOps.RangeData();
        }
    }
}
