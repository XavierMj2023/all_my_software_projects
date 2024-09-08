using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperators;

namespace LinqBasics.LinqStandardOperatorsClasses
{
    public class SetsPurpose
    {
        public static IList<string> strList = new List<string>() { "One", "Two", "Three", "Two", "Three" };

        public static IList<int> intList1 = new List<int>() { 1, 2, 3, 2, 4, 4, 3, 5 };

        public static IList<int> intList2 = new List<int>() { 1, 2, 3 ,4,8};

        public static IList<int> intList3 = new List<int>() { 2,4,6,8 };

        public static IList<Student101> studentList = new List<Student101>() {
        new Student101() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student101() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
        new Student101() { StudentID = 3, StudentName = "Steve",  Age = 25 } ,
        new Student101() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student101() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student101() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student101() { StudentID = 5, StudentName = "Ron" , Age = 19 },
        new Student101() { StudentID = 1, StudentName = "John", Age = 27 } ,
    };

        public static IList<Student101> studentList2 = new List<Student101>() {
        new Student101() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student101() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
        new Student101() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student101() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student101() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student101() { StudentID = 5, StudentName = "Ron" , Age = 19 },
        };

        public static IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
        
        public static IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

        public static IList<Student101> studentList8 = new List<Student101>() {
        new Student101() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student101() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
        new Student101() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student101() { StudentID = 5, StudentName = "Ron" , Age = 19 }
        };

        public static IList<Student101> studentList6 = new List<Student101>() {
        new Student101() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student101() { StudentID = 5, StudentName = "Ron" , Age = 19 }
        };
    }
}
