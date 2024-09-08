using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics.LinqStandardOperators
{
    public class MultipleSorting
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
                new UseRefer(){ReferenceID = 1007 , ReferenceName = "Abhi" ,
                                   ValidReference = 'B'},
            };
        public static void MultipleSort()
        {
            var mulsort = from multsort in users
                          orderby multsort.ValidReference, multsort.ReferenceName
                          select multsort;

            Console.WriteLine("Mutliple Sorting Fields Sepearted By Comma");
            Console.WriteLine("------------------------------------------");

            foreach(var msort in mulsort)
                Console.WriteLine("Id is : "  +msort.ReferenceID+
                                  "\nName is " + msort.ReferenceName + 
                                  "\nValid Reference : " +msort.ValidReference + "\n");
        }
        public static void MultipleSortWithCurlyBraces()
        {
            var mulsort = from multsort in users
                          orderby multsort.ValidReference, multsort.ReferenceName
                          select new {multsort.ValidReference,multsort.ReferenceName,
                                      multsort.ReferenceID};

            Console.WriteLine("Mutliple Sorting Fields Using Curly Braces");
            Console.WriteLine("------------------------------------------");

            foreach (var msort in mulsort)
                Console.WriteLine("Id is : " + msort.ReferenceID+
                                  "\nName is " + msort.ReferenceName +
                                  "\nValid Reference : " + msort.ValidReference + "\n");
        }
    }
}
