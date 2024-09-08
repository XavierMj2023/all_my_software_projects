using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class AggregateOps
    {
        public static void AggregateMethodSyntax()
        {
            var aggareas = JoinPurposeClass.areaban3;
            var comparestr = aggareas.Aggregate((s1, s2) => s1 + "," + s2);
            Console.WriteLine(comparestr);
        }
        public static void AggregateSeedValue()
        {
            var aggareas = Teenager.Teeages;
            var comparestr = aggareas.Aggregate<Teenager, string>(
                                      "Teenager Names : ",//Seed Value
                                      (area, s) => area += s.Teename + ",");
            Console.WriteLine(comparestr);
        }
        public static void AggregateResultSelector()
        {
            var aggareas = Teenager.Teeages;
            var comparestr = aggareas.Aggregate<Teenager, string, string>(
                                      String.Empty, //Seed Value
                                                    //returns result using seed value, String.Empty goes to 
                                                    //lambda expression as area
                                      (area, s) => area += s.Teename + ",",
                                                    //result selector that removes last comma
                                      str => str.Substring(0, str.Length - 1));
            Console.WriteLine(comparestr);
        }
    }
    public class Aggregate
    {
        public static void GetAggregateMethodSyntax()
        {
            AggregateOps.AggregateMethodSyntax();
        }
        public static void GetAggregateSeedValue()
        {
            AggregateOps.AggregateSeedValue();
        }
        public static void GetAggregateResultSelector()
        {
            AggregateOps.AggregateResultSelector();
        }
    }
}
