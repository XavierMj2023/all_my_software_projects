using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperators;

namespace LinqBasics.LinqStandardOperatorsClasses
{
    public class FootballClub
    {
        public int ClubId { get; set; }
        public string ClubName { get; set; }
        public char Grade { get; set; }
    }
    public class DefaultIfEmptyOpsClass
    {
       public static IList<FootballClub> foot = new List<FootballClub>();
    }
}
   
