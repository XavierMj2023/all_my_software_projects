using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics
{
    public class LinqMethodSyntaxDemo
    {
        public static void ExecuteMethodSyntax()
        {
            IList<string> listofitems = new List<string>() {
                "ItemForMaple",
                "ItemForMaples",
                "ItemForApples",
                "MVC" ,
                "Java",
                "C#",
                "F#",
                "Item2"
            };
            var methres = listofitems.Where(item => item.Contains("Item"))
                         .Select(item => item);
            foreach(var metitem in methres)
            {
                Console.WriteLine(metitem); 
            }    
        }
        public static void ExecuteMethodSyntax_SecondExample()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numfilter = numbers.Where(num => num % 2 == 0).Select(num => num * 2);
            foreach(var filterno in numfilter)
            {
                Console.WriteLine(filterno);
            }
        }
    }
}
