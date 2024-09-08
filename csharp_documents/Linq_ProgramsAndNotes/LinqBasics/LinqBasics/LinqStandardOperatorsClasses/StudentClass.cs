using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics.LinqStandardOperatorsClasses
{
    public class StudentClass
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int CollegeId { get; set; }

        public static IList<StudentClass> studentList2 = new List<StudentClass>() {
                    new StudentClass() { StudentID = 1, StudentName = "Johnny", Age = 18 ,CollegeId = 1601} ,
                    new StudentClass() { StudentID = 2, StudentName = "Steven",  Age = 17 , CollegeId = 1601} ,
                    new StudentClass() { StudentID = 3, StudentName = "Billu",  Age = 17 , CollegeId = 1608} ,
                    new StudentClass() { StudentID = 4, StudentName = "Raman" , Age = 22 , CollegeId = 1602} ,
                    new StudentClass() { StudentID = 5, StudentName = "Ronay" , Age = 18 , CollegeId = 1604},
                    new StudentClass() { StudentID = 6, StudentName = "Rohith" , Age = 22 , CollegeId = 1605}
            };
    }
}
