using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics
{
    public class LinqQuery
    {
        string[] names = { "Bill", "Steve", "James", "Mohan" };
        public void LinqQueryExecutation()
        {
            var mylinq = from name in names
                         where name.Contains('a')
                         select name;

            foreach (var name in mylinq)
            {
                Console.WriteLine(name + "");
            }
        }
    }
    public class SimpleLINQ_Query
    {
        public static void ExecuteQuery()
        {
            LinqQuery lq = new LinqQuery();
            lq.LinqQueryExecutation();
        }
    }
}
