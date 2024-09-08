using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class GenerationOperatorsDefaultIfEmpty
    {
        public static void DefaultIfEmptyOps()
        {
            var defaultifempt = JoinPurposeClass.emplist;

            var defempt1 = defaultifempt.DefaultIfEmpty();
            var defempt2 = defaultifempt.DefaultIfEmpty("None");

            Console.WriteLine($"Count {defempt1.Count()} ; Value : {defempt1.ElementAt(0)}");
            Console.WriteLine($"Count {defempt2.Count()} ; Value : {defempt2.ElementAt(0)}");
        }
        public static void DefaultIfEmptyForObjectOps()
        {
            var assignfootclass = DefaultIfEmptyOpsClass.foot;
            
            var deffootclass1 = assignfootclass.DefaultIfEmpty();
            var deffootclass2 = assignfootclass.DefaultIfEmpty(new FootballClub()
            {
                ClubId = 121,
                ClubName = "Club Not Specified",
            });
            Console.WriteLine($"Count : {deffootclass1.Count()} ; ClubId : {deffootclass1.ElementAt(0)} ; ClubName : {deffootclass1.ElementAt(0)}\n\n");
            Console.WriteLine($"Count : {deffootclass2.Count()} ; ClubId : {deffootclass2.ElementAt(0).ClubId} ; ClubName : {deffootclass2.ElementAt(0).ClubName}");
        }
    }
}
