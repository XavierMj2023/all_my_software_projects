using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics.LinqStandardOperators
{
    public class StudentSeqEq
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    public class Passport
    {
        public int PassportID { get; set; }
        public string PassportType { get; set; }
        public string PassportName { get; set; }
        public string ValidVisa { get; set; }
    }
    public class UsingWhereOperator
    {
        public static void WhereOperator_UsingQuerySyntax()
        {
            IList<StudentSeqEq> studlist = new List<StudentSeqEq>() {
                new StudentSeqEq() { StudentID = 1, StudentName = "Mohan", Age = 13} ,
                new StudentSeqEq() { StudentID = 2, StudentName = "Xavier",  Age = 14 } ,
                new StudentSeqEq() { StudentID = 3, StudentName = "Shawn",  Age = 18 } ,
                new StudentSeqEq() { StudentID = 4, StudentName = "Ram" , Age = 22} ,
                new StudentSeqEq() { StudentID = 5, StudentName = "Manoj" , Age = 15 }
            };
            var queryres = from stuitem in studlist
                           where stuitem.Age > 12 && stuitem.Age < 15
                           select stuitem;

            Console.WriteLine("Students Filtered");

            foreach (StudentSeqEq st in queryres)
            {
                Console.WriteLine(st.StudentName);
            }
        }
        public static void WhereOperator_UsingMethodSyntax()
        {
            IList<StudentSeqEq> studlist = new List<StudentSeqEq>() {
                new StudentSeqEq() { StudentID = 1, StudentName = "Mohan", Age = 13} ,
                new StudentSeqEq() { StudentID = 2, StudentName = "Xavier",  Age = 14 } ,
                new StudentSeqEq() { StudentID = 3, StudentName = "Shawn",  Age = 18 } ,
                new StudentSeqEq() { StudentID = 4, StudentName = "Ram" , Age = 22} ,
                new StudentSeqEq() { StudentID = 5, StudentName = "Manoj" , Age = 15 }
            };
            var queryres = studlist.Where(studname => studname.Age > 12 && 
                                          studname.Age < 15);

            Console.WriteLine("Students Filtered");

            foreach (StudentSeqEq st in queryres)
            {
                Console.WriteLine(st.StudentName);
            }
        }
        public static void SecondOverload()
        {
            IList<StudentSeqEq> studlist = new List<StudentSeqEq>() {
                new StudentSeqEq() { StudentID = 1, StudentName = "Mohan", Age = 13} ,
                new StudentSeqEq() { StudentID = 2, StudentName = "Xavier",  Age = 14 } ,
                new StudentSeqEq() { StudentID = 3, StudentName = "Shawn",  Age = 18 } ,
                new StudentSeqEq() { StudentID = 4, StudentName = "Ram" , Age = 22} ,
                new StudentSeqEq() { StudentID = 5, StudentName = "Manoj" , Age = 15 }
            };
            var filterres = studlist.Where((s, i) =>
            {
                if (i % 2 == 0)
                    return true;
                else
                    return false;
            });
            foreach(var std in filterres)
            {
                Console.WriteLine(std.StudentName);
            }
        }
        public static void MultipleWhereUsingQuerySyntax()
        {
            IList<StudentSeqEq> studlist = new List<StudentSeqEq>() {
                new StudentSeqEq() { StudentID = 1, StudentName = "Mohan", Age = 13} ,
                new StudentSeqEq() { StudentID = 2, StudentName = "Xavier",  Age = 14 } ,
                new StudentSeqEq() { StudentID = 3, StudentName = "Shawn",  Age = 18 } ,
                new StudentSeqEq() { StudentID = 4, StudentName = "Ram" , Age = 22} ,
                new StudentSeqEq() { StudentID = 5, StudentName = "Manoj" , Age = 15 }
            };
            //Multiple Where Clause Query Syntax
            var queryres = from stuitem in studlist
                           where stuitem.Age > 12 
                           where stuitem.Age < 15
                           select stuitem;

            Console.WriteLine("Students Filtered");

            foreach (StudentSeqEq st in queryres)
            {
                Console.WriteLine(st.StudentName);
            }
        }
        public static void MultipleWhereUsingMethodSyntax()
        {
            IList<Passport> passlist = new List<Passport>() {
                new Passport() { 
                                 PassportID = 101,
                                 PassportName = "Angana",
                                 PassportType = "CB01",
                                 ValidVisa = "yes"
                } ,
                new Passport() {
                                 PassportID = 102,
                                 PassportName = "Angana",
                                 PassportType = "CB01",
                                 ValidVisa = "yes"
                } ,
                new Passport() {
                                 PassportID = 103,
                                 PassportName = "Bhartna Cigar",
                                 PassportType = "BC01",
                                 ValidVisa = "yes"
                } ,
                new Passport() {
                                 PassportID = 104,
                                 PassportName = "Angana",
                                 PassportType = "CB01",
                                 ValidVisa = "no"
                } ,
                new Passport() {
                                 PassportID = 105,
                                 PassportName = "Cigar",
                                 PassportType = "CG01",
                                 ValidVisa = "no"
                } ,
            };
            //Multiple Where Clause Method Syntax
            var passres = passlist.Where(visa => visa.ValidVisa == "yes")
                                  .Where(visa => visa.PassportName == "Bhartna Cigar");

            Console.WriteLine("Passport Filtered");

            foreach (Passport ps in passres)
            {
                Console.WriteLine(ps.PassportID);
            }
        }
    }
    public class Where
    {
        public static void GetTeenagers()
        {
            UsingWhereOperator.WhereOperator_UsingQuerySyntax();
        }
        public static void GetTeenagersUsingMethodSyntax()
        {
            UsingWhereOperator.WhereOperator_UsingMethodSyntax();
        }
        public static void GetResultUsingWhereSecondOverload()
        {
            UsingWhereOperator.SecondOverload();
        }
        public static void GetMultipleWhereUsingQuerySyntax()
        {
            UsingWhereOperator.MultipleWhereUsingQuerySyntax();
        }
        public static void GetMultipleWhereUsingMethodSyntax()
        {
            UsingWhereOperator.MultipleWhereUsingMethodSyntax();
        }
    }
}
