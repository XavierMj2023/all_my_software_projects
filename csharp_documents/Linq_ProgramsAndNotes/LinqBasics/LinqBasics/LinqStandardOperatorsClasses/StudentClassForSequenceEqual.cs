using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics.LinqStandardOperatorsClasses
{
    public class StudentSeqEq
    {
        public int StudentID { get; set; }
        public string StudentName{get; set;}
    }
    public class StudentClassForSequenceEqual
    {
        public static IList<StudentSeqEq> studentList1 = new List<StudentSeqEq>() {
            new StudentSeqEq() { StudentID = 1, StudentName = "John" },
            new StudentSeqEq() { StudentID = 2, StudentName = "Steve" },
            new StudentSeqEq() { StudentID = 3, StudentName = "Bill" },
            new StudentSeqEq() { StudentID = 4, StudentName = "Ram"  },
            new StudentSeqEq() { StudentID = 5, StudentName = "Ron" }
        };

        public static IList<StudentSeqEq> studentList2 = new List<StudentSeqEq>() {
            new StudentSeqEq() { StudentID = 1, StudentName = "John" },
            new StudentSeqEq() { StudentID = 2, StudentName = "Steve" },
            new StudentSeqEq() { StudentID = 3, StudentName = "Bill" },
            new StudentSeqEq() { StudentID = 4, StudentName = "Ram" },
            new StudentSeqEq() { StudentID = 5, StudentName = "Ron" }
        };
    }
    public class StudentSeqEquComparer : IEqualityComparer<StudentSeqEq>
    {
        public bool Equals(StudentSeqEq x, StudentSeqEq y)
        {
            if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(StudentSeqEq obj)
        {
            return obj.GetHashCode();
        }
    }
}
