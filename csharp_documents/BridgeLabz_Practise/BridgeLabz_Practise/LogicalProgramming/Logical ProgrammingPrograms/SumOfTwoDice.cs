using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.Logical_ProgrammingPrograms
{
    public class SumOfTwoDice
    {
        public static void RandomNoGenerator()
        {
            // Create a random number generator
            Random rand = new Random();

            // Generate two random numbers between 1 and 6 to simulate rolling two dice
            int dice1 = rand.Next(1,6);
            int dice2 = rand.Next(1,6);

            // Calculate the sum of the two dice
            int dicesum = dice1 + dice2;

            // Print the results
            Console.WriteLine("Result of rolling two dice:");
            Console.WriteLine($"Die 1: {dice1}");
            Console.WriteLine($"Die 2: {dice2}");
            Console.WriteLine($"Sum of two dice: {dicesum}");
        }
    }
}
