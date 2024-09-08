using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class GroupByOps
    {
        public static void GroupByQuerySyntax()
        { 
            var getStudentObj = StudentClass.studentList2;

            var getstudent = from studetails in getStudentObj
                             group studetails by studetails.Age;

            foreach (var student in getstudent)
            {
                Console.WriteLine("Age Group : "+student.Key);

                Console.WriteLine("--------------------------");

                foreach (StudentClass getstudkeysdata in student)
                {
                    Console.WriteLine("Name : " + getstudkeysdata.StudentName);
                }
                Console.WriteLine("--------------------------");
            }
        }
        public static void GroupByMethodSyntax()
        {
            var getStudentObj = StudentClass.studentList2;

            var getstudent = getStudentObj.GroupBy(studage => studage.Age);

            foreach (var student in getstudent)
            {
                Console.WriteLine("Age Group : " + student.Key);

                Console.WriteLine("--------------------------");

                foreach (StudentClass getstudkeysdata in student)
                {
                    Console.WriteLine("Name : " + getstudkeysdata.StudentName);
                }
                Console.WriteLine("--------------------------");
            }
        }
    }
    public class GroupBy
    {
        public static void GetGroupByQuerySyntax()
        {
            GroupByOps.GroupByQuerySyntax();
        }
        public static void GetGroupByMethodSyntax()
        {
            GroupByOps.GroupByMethodSyntax();
        }
    }
}
