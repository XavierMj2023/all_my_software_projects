using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperators;

namespace LinqBasics.LinqStandardOperatorsClasses
{

    public class TravelTourism
    {
        public int Id { get; set; }
        public string TravelllerName{ get; set; }
        public int Age { get; set; }
        public char IsVisa{ get; set; }
        public string Place { get; set; }
        public DateTime Dob { get; set; }
        public double CostOfDestination { get; set; }
        public int DaysOfTravelling { get; set; }
        public string Gender { get; set; }
        public string Reference { get; set; }
        public int Members{ get; set; }
        public int Ratings { get; set; }

        public static IList<TravelTourism> travels_thenby = new List<TravelTourism>()
        {
            new TravelTourism()
            {
                Id = 1201,
                TravelllerName = "Manoj",
                Age = 20,
                IsVisa = 'Y',
                Place = "Goa",
                // 2015 is year, 12 is month, 25 is day
                Dob = new DateTime(2023, 12, 25),
                CostOfDestination = 902.86,
                DaysOfTravelling = 5,
                Gender = "Male",
                Reference = "Magzine",
                Members = 6,
                Ratings = 4
            },
            new TravelTourism()
            {
                Id = 1202,
                TravelllerName = "Xavier",
                Age= 18,
                IsVisa = 'N',
                Place = "Goa",
                // 2015 is year, 12 is month, 25 is day
                Dob = new DateTime(2023, 12, 14),
                CostOfDestination = 902.85,
                DaysOfTravelling = 5,
                Gender = "Male",
                Reference = "Magzine",
                Members = 5,
                Ratings = 8
            },
            new TravelTourism()
            {
                Id = 1203,
                TravelllerName = "Manish",
                Age = 26,
                IsVisa = 'Y',
                Place = "Las Vegas",
                // 2015 is year, 12 is month, 25 is day
                Dob = new DateTime(2023, 12, 26),
                CostOfDestination = 900.86,
                DaysOfTravelling = 10,
                Gender = "Male",
                Reference = "Magzine",
                Members = 4,
                Ratings = 4
            },
        };
    }
}
