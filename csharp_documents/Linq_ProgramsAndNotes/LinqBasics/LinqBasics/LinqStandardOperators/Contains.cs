using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class StudentComparer : IEqualityComparer<College>
    {
        public bool Equals(College x, College y)
        {
            if (x.CollegeId == y.CollegeId && x.CollegeName.ToLower() == y.CollegeName.ToLower());
                return true;

            return false;
        }

        public int GetHashCode(College cl)
        {
           return cl.GetHashCode();
        }
    }
    public class ContainsOps
    {
        public static void ContainsMethodSyntax()
        {
            var geteves = JoinPurposeClass.evenmums;
            bool getNum1 = geteves.Contains(12);
            bool getNum2 = geteves.Contains(13);
            Console.WriteLine("12 is present or not : " + getNum1 + "\n" + "13 is present or not : "
                               + getNum2);
        }
        public static void ContainsError()
        {
            var geteves = College.collegelist;
          
            College col = new College()
            {
                CollegeId = 1789,
                CollegeName = "ACST",
            };
            bool colbool = geteves.Contains(col);
            Console.WriteLine("Error status : " + colbool);
        }
        public static void ContainsIEqualityComperer_For_SecondOverload()
        {
            var geteves = College.collegelist;

            College col = new College()
            {
                CollegeId = 1789,
                CollegeName = "ACST",
            };
            bool colbool = geteves.Contains(col,new StudentComparer());
            Console.WriteLine("Error status : " + colbool);
        }
    }
    public class Contains
    {
        public static void GetResultOfNumberPresentOrNot()
        {
            ContainsOps.ContainsMethodSyntax();
        }
        public static void ContainsShowError()
        {
            ContainsOps.ContainsError();
        }
        public static void GetContainsIEqualityComperer_For_SecondOverload()
        {
            ContainsOps.ContainsIEqualityComperer_For_SecondOverload();
        }
    }
}
