using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class ToLookUp
    {
        public static void ToLookUpMethodSyntax()
        {
            var getStudentObj = StudentClass.studentList2;

            var getstudent = getStudentObj.ToLookup(sage => sage.Age);

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
}
