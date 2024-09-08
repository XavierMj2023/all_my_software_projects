using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.BasicProgrammingPrograms
{
    public class CheckSeason
    {
        public static string GetSeason(int month)
        {
            switch (month)
            {
                case 2:
                case 3:
                    return "Vasanta";
                case 4:
                case 5:
                    return "Grishma / Summer";
                case 6:
                case 7:
                    return "Monsoon / Rainy";
                case 8:
                case 9:
                    return "Sharada";
                case 10:
                case 11:
                    return "Hemanta";
                case 12:
                case 1:
                    return "Shishira / Winter";
                default:
                    return "Invalid month number";
            }
        }
        public static void ResSeason()
        {
            int month;

            //Infinity Loop
            while (true)
            {
                Console.Write("Enter a month number (1 to 12): ");
                if (int.TryParse(Console.ReadLine(), out month) && month >= 1 && month <= 12)
                {
                    string season = GetSeason(month);
                    Console.WriteLine($"The season for month {month} is {season}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid month number between 1 and 12.");
                }
            }
        }
    }
    public class CheckSeasons
    {
        public static void CheckSes()
        {
            CheckSeason.ResSeason();
        }
    }
}
