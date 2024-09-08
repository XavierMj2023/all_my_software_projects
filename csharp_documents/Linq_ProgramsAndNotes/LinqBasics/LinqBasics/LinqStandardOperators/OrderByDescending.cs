using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics.LinqStandardOperators
{
    public class UseRefer
    {
        public int ReferenceID { get; set; }
        public string ReferenceName { get; set; }
        public char ValidReference { get; set; }
    }
    public class OrderByDescendingOps
    {
        public static IList<UseRefer> users = new List<UseRefer>()
            {
                new UseRefer(){ReferenceID = 1001 , ReferenceName = "Abhi" ,
                                   ValidReference = 'B'},
                new UseRefer(){ReferenceID = 1002 , ReferenceName = "Abhjeeth" ,
                                   ValidReference = 'A'},
                new UseRefer(){ReferenceID = 1003 , ReferenceName = "Xavier" ,
                                   ValidReference = 'C'},
                new UseRefer(){ReferenceID = 1004 , ReferenceName = "Sangeetha" ,
                                   ValidReference = 'R'},
                new UseRefer(){ReferenceID = 1005 , ReferenceName = "Manoj" ,
                                   ValidReference = 'F'},
                new UseRefer(){ReferenceID = 1006 , ReferenceName = "Sangoku" ,
                                   ValidReference = 'O'},
            };
        public static void OrderByDescending()
        {
            //Method Syntax For OrderByDescending
            var orderbydesc = users.OrderByDescending(descusers => descusers.ValidReference);

            Console.WriteLine("Descending Order Using OrderByDescending");
            Console.WriteLine("----------------------------------------");
            foreach (var order in orderbydesc)
                Console.WriteLine("Name is " + order.ReferenceName + " \nValid Reference : " +
                                   order.ValidReference + "\n");
        }
    }
    public class OrderByDescending
    {
        public static void GetOrderByDescending()
        {
            OrderByDescendingOps.OrderByDescending();
        }
    }
}
