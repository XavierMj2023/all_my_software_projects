using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics.LinqStandardOperatorsClasses
{
    public class StudentToDict
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int age { get; set; }
    }
    public class ToConvertSomething
    {
        public static IList<string> strList = new List<string>() {
                                            "One",
                                            "Two",
                                            "Three",
                                            "Four",
                                            "Three"
         };

        public static IList<StudentToDict> toDicts = new List<StudentToDict>() {
                    new StudentToDict() { StudentID = 1, StudentName = "John", age = 18 } ,
                    new StudentToDict() { StudentID = 2, StudentName = "Steve",  age = 21 } ,
                    new StudentToDict() { StudentID = 3, StudentName = "Bill",  age = 18 } ,
                    new StudentToDict() { StudentID = 4, StudentName = "Ram" , age = 20 } ,
                    new StudentToDict() { StudentID = 5, StudentName = "Ron" , age = 21 }
                };

    }
}
