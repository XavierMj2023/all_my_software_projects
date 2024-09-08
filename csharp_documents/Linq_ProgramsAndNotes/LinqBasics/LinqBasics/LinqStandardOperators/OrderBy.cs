using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics.LinqStandardOperators
{
    public class UseReference
    {
        public int ReferenceID { get; set; }
        public string ReferenceName { get; set; }
        public char ValidReference { get; set; }
    }
    public class OrderByInQuerySyntax
    {
        //Object and Collection Intializer Synatx
        public static IList<UseReference> users = new List<UseReference>()
            {
                new UseReference(){ReferenceID = 1001 , ReferenceName = "Abhi" ,
                                   ValidReference = 'B'},
                new UseReference(){ReferenceID = 1002 , ReferenceName = "Abhjeeth" ,
                                   ValidReference = 'A'},
                new UseReference(){ReferenceID = 1003 , ReferenceName = "Xavier" ,
                                   ValidReference = 'C'},
                new UseReference(){ReferenceID = 1004 , ReferenceName = "Sangeetha" ,
                                   ValidReference = 'R'},
                new UseReference(){ReferenceID = 1005 , ReferenceName = "Manoj" ,
                                   ValidReference = 'F'},
                new UseReference(){ReferenceID = 1006 , ReferenceName = "Sangoku" ,
                                   ValidReference = 'O'},
            };
        public static void OrderByQuerySyntax()
        {
            //Order By in Query Synatx in Ascending Order
            var orderqueryres = from useref in users
                                orderby useref.ValidReference
                                select useref;

            Console.WriteLine("Ascending Order");
            Console.WriteLine("-----------------");
            foreach(var order in orderqueryres) 
                Console.WriteLine("Name is "+order.ReferenceName + " \nValid Reference : "+
                                   order.ValidReference+"\n");
        }
        public static void OrderByQuerySyntaxInAscendingOrder_UsingAscendingKeyword()
        {
            //Order By in Query Synatx in Ascending Order Using Ascending Keyword
            var orderqueryres = from useref in users
                                orderby useref.ValidReference ascending
                                select useref;

            Console.WriteLine("Ascending Order By using Ascending Keyword");
            Console.WriteLine("-------------------------------------------");
            foreach (var order in orderqueryres)
                Console.WriteLine("Name is " + order.ReferenceName + " \nValid Reference : " +
                                   order.ValidReference + "\n");
        }
        public static void OrderByQuerySyntaxInDescendingOrder()
        {
            //Order By in Query Synatx in Descending Order
            var orderqueryres = from useref in users
                                orderby useref.ValidReference descending
                                select useref;

            Console.WriteLine("Descending Order");
            Console.WriteLine("-----------------");
            foreach (var order in orderqueryres)
                Console.WriteLine("Name is " + order.ReferenceName + " \nValid Reference : " +
                                   order.ValidReference + "\n");
        }
        public static void OrderByMethodSyntax()
        {
            //Order By in Method Synatx in Ascending Order
            var orderqueryres = users.OrderBy(user => user.ValidReference);

            Console.WriteLine("Ascending Order");
            Console.WriteLine("-----------------");
            foreach (var order in orderqueryres)
                Console.WriteLine("Name is " + order.ReferenceName + " \nValid Reference : " +
                                   order.ValidReference + "\n");
        }
    }
    public class OrderBy
    {
        public static void GetQuerySyntaxOrderBy()
        {
            OrderByInQuerySyntax.OrderByQuerySyntax();
        }
        public static void GetQuerySyntaxOrderByDescendingOrder()
        {
            OrderByInQuerySyntax.OrderByQuerySyntaxInDescendingOrder();
        }
        public static void GetQuerySyntaxOrderByAscendingOrder_UsingAscendingKeyword()
        {
            OrderByInQuerySyntax.OrderByQuerySyntaxInAscendingOrder_UsingAscendingKeyword();
        }
        public static void GetMethodSyntaxOrderBy()
        {
            OrderByInQuerySyntax.OrderByQuerySyntaxInAscendingOrder_UsingAscendingKeyword();
        }
    }
}
