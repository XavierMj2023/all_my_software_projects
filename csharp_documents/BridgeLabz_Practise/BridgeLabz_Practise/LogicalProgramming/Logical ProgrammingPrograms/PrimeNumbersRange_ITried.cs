using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.Logical_ProgrammingPrograms
{
    public class PrimeNoOps
    {
        public static List<int> numlist = new List<int>();

        public static List<int> primenumlist = new List<int>();
        public static void GetRangeNums(int start,int end)
        {
            for(int i = start; i <= end; i++)
            {
                numlist.Add(i);
            }
            int[] convToArray = numlist.ToArray();
            GetPrimeInArray(convToArray);
        }
        public static void GetPrimeInArray(int[] getNums)
        {
            int start = getNums[0];
            int end = getNums[getNums.Length-1];

            for(int i = start; i <= end; i++)
            {
                for(int j = 0;j<9;j++)
                {
                        if(i % j == 0)
                    {
                        primenumlist.Add(i);
                    }
                }
            }
            int[] primearray = primenumlist.ToArray();
            PrintArrayNums(primearray);
        }
        public static void PrintArrayNums(int[] printmodarray)
        {
            Console.WriteLine("The Length of the prime number of a given range is : "
                              + printmodarray.Length);
        }
        public static void EnterNums()
        {
            int start,end;

            Console.WriteLine("Enter the Start Range Number : ");
            start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the End Range Number : ");
            end = int.Parse(Console.ReadLine());

            GetRangeNums(start,end);
        }
    }
    public class PrimeNumbersRange_ITried
    {
        public static void ExecutePrimey()
        {
            PrimeNoOps.EnterNums();
        }
    }
}
