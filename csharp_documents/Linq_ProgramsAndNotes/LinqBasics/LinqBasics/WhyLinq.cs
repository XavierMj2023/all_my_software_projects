using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics
{
    public class Student
    {
        public int StudId { get; set; }
        public String StudName { get; set; }
        public int StudAge { get; set; }
    }
    public class WithoutLinq
    {
        public static void DemoWithoutLinq()
        {
            List<int>numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10};
            List<int> evennumbers = new List<int>();
            foreach(var num in numbers)
            {
                if(num % 2 == 0)
                {
                    evennumbers.Add(num);
                }
            }
            foreach (var num in evennumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
    public class WithLinq
    {
        public static void DemoWithLinq()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evennumbers = numbers.Where(num => num% 2 == 0);    
            /*
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evennumbers.Add(num);
                }
            }
            */
            foreach (var num in evennumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
    public class WhyLinq
    {
        public static void GetResultForWithoutLinq()
        {
            WithoutLinq.DemoWithoutLinq();
        }
        public static void GetResultForWithLinq()
        {
            WithLinq.DemoWithLinq();
        }
    }
}
