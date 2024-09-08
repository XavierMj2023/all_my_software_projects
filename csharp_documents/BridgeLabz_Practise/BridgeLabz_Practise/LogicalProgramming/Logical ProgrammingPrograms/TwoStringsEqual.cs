using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.Logical_ProgrammingPrograms
{
    public class TwoStringsEqualOps2
    {
        public int ExecuteStringResult(string st1, string st2)
        {
           //Storing the length of string 1 and 2
           int lengthOfString1 = st1.Length;
           int lengthOfString2 = st2.Length;

           //Minimum length between the two input strings
           int minLength = Math.Min(lengthOfString1, lengthOfString2);

           //If the second string’s size is more than the first it returns -1. 
            if (lengthOfString2 < lengthOfString1)
            {
                return -1;
            }

            //It compares character by character.
            for (int i = 0; i < minLength; i++)
            {
                if (st1[i] != st2[i])
                {
                    Console.WriteLine($"The first difference is at position {i}");
                    return i;
                }
            }

            //If equals it returns 0.
            if (lengthOfString1 == lengthOfString2)
            {
                Console.WriteLine("The strings are equal.");
                return 0;
            }
            else
            {
                Console.WriteLine($"The first difference is at position {lengthOfString2}");
                return lengthOfString2;
            }
        }
        public void OutputResult(string st1, string st2)
        {
            int result = ExecuteStringResult(st1, st2);

            if (result == -1)
            {
                Console.WriteLine("String 2 is longer than String 1.");
            }
        }
        public void Input2Strings()
        {
            Console.WriteLine("Enter The 1st string : ");
            string st1 = Console.ReadLine();

            Console.WriteLine("Enter The 2nd string : ");
            string st2 = Console.ReadLine();

            OutputResult(st1, st2);
        }
    }
    public class TwoStringsEqual
    {
        public static void ExecuteStringOps()
        {
            TwoStringsEqualOps twostringops = new TwoStringsEqualOps();
            twostringops.Input2Strings();
        }
    }
}
