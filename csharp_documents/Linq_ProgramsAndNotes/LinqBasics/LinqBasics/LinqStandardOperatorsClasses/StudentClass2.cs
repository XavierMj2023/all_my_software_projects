using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics.LinqStandardOperatorsClasses
{
    public class StudentClass2
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int CollegeId { get; set; }

        public static IList<StudentClass2> studentList3 = new List<StudentClass2>() {
                    new StudentClass2() { StudentID = 1, StudentName = "Johnny", Age = 18 ,CollegeId = 1601} ,
                    new StudentClass2() { StudentID = 2, StudentName = "Steven",  Age = 17 ,CollegeId = 1602} ,
                    new StudentClass2() { StudentID = 3, StudentName = "Billu",  Age = 17 , CollegeId = 1602}
            };
    }
}
