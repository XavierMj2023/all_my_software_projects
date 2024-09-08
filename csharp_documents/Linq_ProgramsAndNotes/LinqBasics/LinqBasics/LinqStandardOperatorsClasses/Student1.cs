using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics.LinqStandardOperatorsClasses
{
    public class Student1
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }

        public static IList<Student1> studentList = new List<Student1>() {
                new Student1() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
                new Student1() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
                new Student1() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
                new Student1() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
                new Student1() { StudentID = 5, StudentName = "Ron" , Age = 21}
            };
    }
}
