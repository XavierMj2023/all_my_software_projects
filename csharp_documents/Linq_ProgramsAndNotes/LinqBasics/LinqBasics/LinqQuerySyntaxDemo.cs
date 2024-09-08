using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics
{
    public class LinqQuerySyntaxDemo
    {
        public static void LinqQuerySyntax()
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
            var queryres = from items in listofitems
                           where items.Contains("Item")
                           select items;
            foreach (var str in queryres)
            {
                Console.WriteLine(str);
            }
        } 
    }
}
