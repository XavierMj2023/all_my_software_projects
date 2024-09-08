using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.BasicProgrammingPrograms
{
    public class TemperatureOps
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
    public class TemperatureOperations
    {
        public static void Temper()
        {
            Console.Write("Enter the temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the unit (F or C): ");
            string unit = Console.ReadLine();

            if (unit.Equals("F", StringComparison.OrdinalIgnoreCase))
            {
                double celsius = TemperatureOps.FahrenheitToCelsius(temperature);
                Console.WriteLine($"Temperature in Celsius: {celsius} °C");
            }
            else if (unit.Equals("C", StringComparison.OrdinalIgnoreCase))
            {
                double fahrenheit = TemperatureOps.CelsiusToFahrenheit(temperature);
                Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit} °F");
            }
            else
            {
                Console.WriteLine("Invalid unit. Please enter 'F' for Fahrenheit or 'C' for Celsius.");
            }
        }
    }
    public class Temparture
    {
        public static void GetTemperature()
        {
            TemperatureOperations.Temper();
        }
    }
}
