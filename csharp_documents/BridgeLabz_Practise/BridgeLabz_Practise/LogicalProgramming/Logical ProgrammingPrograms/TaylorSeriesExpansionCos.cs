using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.Logical_ProgrammingPrograms
{
    public class TaylorSeriesExpansionCos
    {
        public static double TaySeriesCos(double x, int n)
        {
            x = x % (2 * Math.PI);
            double result = 0;
            for (int i = 0; i < n; i++)
            {
                int exponent = 2 * i;
                double term = Math.Pow(-1, i) * Math.Pow(x, exponent) / TaySeriesCosFactorial(exponent);
                result += term;
            }
            return result;
        }
        public static double TaySeriesCosFactorial(int n)
        {
            if (n == 0)
                return 1;
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public static void EnterInput()
        {
            Console.WriteLine("Enter the angle x in radians:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of terms in the Taylor series:");
            int n = int.Parse(Console.ReadLine());

            double cosX = TaySeriesCos(x, n);
            Console.WriteLine($"cos({x}) = {cosX}");
        }
    }
}
