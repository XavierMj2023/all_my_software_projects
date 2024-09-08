using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.BasicProgrammingPrograms
{
    public class PrintIntials
    {
        public static void PrintInitialsExe(string initials)
        {
            string[] alphabet = {
            "*********",
            "*********",
            "*********",
            "*********",
            "*********",
            "*********",
            "*********",
            "*********",
            "*********",
        };

            foreach (char initialChar in initials)
            {
                if (char.IsLetter(initialChar))
                {
                    int charIndex = char.ToUpper(initialChar) - 'A';
                    if (charIndex >= 0 && charIndex < alphabet.Length)
                    {
                        string row = alphabet[charIndex];
                        Console.WriteLine(row);
                    }
                }
            }
        }
    }
}
