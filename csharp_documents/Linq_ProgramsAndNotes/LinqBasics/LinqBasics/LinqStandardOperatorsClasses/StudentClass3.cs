using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics.LinqStandardOperatorsClasses
{
    public class StudentClass3
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }

        public static IList<StudentClass3> studentList3 = new List<StudentClass3>() {
                  new StudentClass3() { StudentID = 1, StudentName = "John", StandardID =1 },
                  new StudentClass3() { StudentID = 2, StudentName = "Moin", StandardID =1 },
                  new StudentClass3() { StudentID = 3, StudentName = "Bill", StandardID =2 },
                  new StudentClass3() { StudentID = 4, StudentName = "Ram",  StandardID =2 },
                  new StudentClass3() { StudentID = 5, StudentName = "Ron" }
            };
    }
    public class StudentClassOps
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public static StudentClassOps[] studentArray = {
                new StudentClassOps() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new StudentClassOps() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new StudentClassOps() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new StudentClassOps() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new StudentClassOps() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
            };
    }
}
