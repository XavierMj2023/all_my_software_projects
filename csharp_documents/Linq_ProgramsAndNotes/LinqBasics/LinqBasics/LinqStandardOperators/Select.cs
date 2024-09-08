using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class SelectOps
    {
        public static void SelectInQuerySyntax()
        {
            var resforselect = StudentClass.studentList2;
            var getlistnamesforselect = from selnames in resforselect
                                        select selnames.StudentName;
            Console.WriteLine("Names from the StudentClass are : ");
            foreach(var selname in getlistnamesforselect)
                Console.WriteLine(selname);
        }
        public static void SelectInQuerySyntax_AnonymousType()
        {
            var resforselect = StudentClass.studentList2;

            // returns collection of anonymous objects with Name and Age property
            var getlistnamesforselect = from selnames in resforselect
                                        select new
                                        {
                                            SName = "Mr."+selnames.StudentName,
                                            SAge = selnames.Age
                                        };

            Console.WriteLine("Names\t\tAge");
            Console.WriteLine("---------------------");
            foreach (var selname in getlistnamesforselect)
                Console.WriteLine(selname.SName +"\t" +selname.SAge);
        }
        public static void SelectInMethodSyntax()
        {
            var resforselect = StudentClass.studentList2;

            //returns a collection of anonymous object with the Name and Age property

            var getlistnamesforselect = resforselect.Select(
                                                        selnames => new
                                                        {
                                                            SName = "Mr." + selnames.StudentName,
                                                            SAge = selnames.Age
                                                        }
                                                    );
            Console.WriteLine("Names\t\tAge");
            Console.WriteLine("---------------------");
            foreach (var selname in getlistnamesforselect)
                Console.WriteLine(selname.SName + "\t" + selname.SAge);
        }
    }
    public class Select
    {
        public static void GetSelectInQuerySyntax()
        {
            SelectOps.SelectInQuerySyntax();
        }
        public static void GetSelectInQuerySyntax_AnonymousType()
        {
            SelectOps.SelectInQuerySyntax_AnonymousType();
        }
        public static void GetSelectInMethodSyntax()
        {
            SelectOps.SelectInMethodSyntax();
        }
    }
}
