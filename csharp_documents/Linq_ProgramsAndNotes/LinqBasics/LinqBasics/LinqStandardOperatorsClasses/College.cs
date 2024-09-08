using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics.LinqStandardOperatorsClasses
{
    public class College
    {
        public int CollegeId { get; set; }
        public string CollegeName { get; set; }

        public static IList<College> collegelist = new List<College>() {
                    new College() { 
                        CollegeId = 1601,
                        CollegeName = "ACST",
                    } ,
                    new College() {
                        CollegeId = 1602,
                        CollegeName = "ACSB",
                    } ,
                    new College() {
                        CollegeId = 1003,
                        CollegeName = "BERA",
                    } 
         };
    }
}
