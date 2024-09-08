using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class ThenByDescending
    {
        public static void ThenByDescendingOps()
        {
            var storethenbyobj = TravelTourism.travels_thenby;

            var thebyres = storethenbyobj.OrderBy(trusers => trusers.Place);

            Console.WriteLine("Elements Sorted Using Place Fields");
            Console.WriteLine("-----------------------------------");

            foreach (var placeres in thebyres)
                Console.WriteLine("Id is " + placeres.Id
                                  + "\nTraveller Name is : " + placeres.TravelllerName
                                  + "\nAge : " + placeres.Age
                                  + "\nPlace :" + placeres.Place + "\n");

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Elements Sorted Using Place and Members With ThenByDescending");
            Console.WriteLine("-----------------------------------------------------------");

            var orderthenby = storethenbyobj
                             .OrderBy(trusers => trusers.Place)
                             .ThenByDescending(trusers => trusers.Members);

            foreach (var placeres in orderthenby)
                Console.WriteLine("Id is " + placeres.Id
                                + "\nTraveller Name is : " + placeres.TravelllerName
                                + "\nAge : " + placeres.Age
                                + "\nPlace :" + placeres.Place
                                + "\nMembers :" + placeres.Members + "\n");
        }
    }
}
