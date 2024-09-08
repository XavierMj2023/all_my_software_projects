using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.BasicProgrammingPrograms
{
    public class AsciiArray
    {
        public static void GetAscii()
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            int[] asciiArray = new int[inputString.Length];

            for (int i = 0; i < inputString.Length; i++)
            {
                char character = inputString[i];
                int asciiValue = (int)character;
                asciiArray[i] = asciiValue;
            }

            Console.WriteLine("ASCII values of the characters in the input string:");

            foreach (int asciiValue in asciiArray)
            {
                Console.Write(asciiValue + " ");
            }
        }
    }
}
