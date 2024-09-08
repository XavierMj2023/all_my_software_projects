using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.BasicProgrammingPrograms
{
    public class PrintFriendsNames
    {
        public static void PrintFriendsNamesExe(string friend1, string friend2, string friend3)
        {
            // Concatenate the friends' names in reverse order with "and" before the last name
            string message = $"\"Hi {friend3}, {friend2} and {friend1}\"";
            Console.WriteLine(message);
        }
    }
}
