using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.BasicProgrammingPrograms
{
    public class Quadratic
    {
        public static void QuadsCalculation()
        {
            Console.Write("Enter the value of 'a': ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of 'b': ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of 'c': ");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Root 1 of x: {root1}");
                Console.WriteLine($"Root 2 of x: {root2}");
            }
            else if (delta == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"Both roots are equal: {root}");
            }
            else
            {
                Console.WriteLine("No real roots exist for the given coefficients.");
            }
        }
    }
}
