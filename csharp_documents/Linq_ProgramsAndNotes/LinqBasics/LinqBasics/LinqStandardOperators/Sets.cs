using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class Student101
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    public class StudentComparer2 : IEqualityComparer<Student101>
    {
        public bool Equals(Student101 x, Student101 y)
        {
            if (x.StudentID == y.StudentID
                    && x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student101 obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }
    public class SetsOps
    {
        public static void DistinctOps()
        {
            //integer
            var dupset = SetsPurpose.intList1;
            //Distinct
            var distinctset = dupset.Distinct();
            Console.Write("The Distinct elements of collection of integers are : ");
            foreach(var item in distinctset)
                Console.Write(item+" ");

            Console.WriteLine("\n");

            //string
            var dupsetstr = SetsPurpose.strList;
            //Distinct
            var distinctsetstr = dupsetstr.Distinct();
            Console.Write("The Distinct elements of collection of string are : ");
            foreach (var item in distinctsetstr)
                Console.Write(item + " ");

            Console.WriteLine("\n");
        }
        public static void DistinctIEqualityComparer()
        {
           // var studobjdup = SetsPurpose.studentList;

            var studobjdup2 = SetsPurpose.studentList2;

           // var studobjdistinct = studobjdup.Distinct(new StudentComparer2());

            var studobjdistinct2 = studobjdup2.Distinct(new StudentComparer2());

            Console.WriteLine("Distinct Items in object are : ");
            foreach (var item in studobjdistinct2)
                // Console.WriteLine(item.StudentID+"   "+item.StudentName + " "); //Ambiguity

                Console.Write(item.StudentName + " "+"\n");
        }
        public static void ExceptOps()
        {
            //integer
            var set1 = SetsPurpose.intList2;
            var set2 = SetsPurpose.intList3;
            //Except
            var distinctset = set1.Except(set2);
            Console.Write("The Elements of collection 1 that do not exist in collection2 of integers are : ");
            foreach (var item in distinctset)
                Console.Write(item + " ");

            Console.WriteLine("\n");

            //string
            var set3 = SetsPurpose.strList1;
            var set4 = SetsPurpose.strList2;
            //Except
            var distinctset2 = set3.Except(set4);
            Console.Write("The Elements of collection 1 that do not exist in collection2 of string are : ");
            foreach (var item in distinctset2)
                Console.Write(item + " ");

            Console.WriteLine("\n");
        }
        public static void ExceptIEqualityComparer()
        {
            var studobjdup4 = SetsPurpose.studentList8;
            var studobjdup7 = SetsPurpose.studentList6;

            var studobjdistinct2 = studobjdup4.Except(studobjdup7,new StudentComparer2());

            Console.WriteLine("The Elements of object 1 that do not exist in object2  are : ");
            foreach (var item in studobjdistinct2)
                Console.Write(item.StudentName + " " + "\n");
        }
        public static void IntersectOps()
        {
            //integer
            var set1 = SetsPurpose.intList2;
            var set2 = SetsPurpose.intList3;
            //Except
            var distinctset = set1.Intersect(set2);
            Console.Write("The Common elements of integer are : ");
            foreach (var item in distinctset)
                Console.Write(item + " ");

            Console.WriteLine("\n");

            //string
            var set3 = SetsPurpose.strList1;
            var set4 = SetsPurpose.strList2;
            //Except
            var distinctset2 = set3.Except(set4);
            Console.Write("The Common elements of strings are : ");
            foreach (var item in distinctset2)
                Console.Write(item + " ");

            Console.WriteLine("\n");
        }
        public static void IntersectIEqualityComparer()
        {
            var studobjdup4 = SetsPurpose.studentList8;
            var studobjdup7 = SetsPurpose.studentList6;

            var studobjdistinct2 = studobjdup4.Intersect(studobjdup7, new StudentComparer2());

            Console.WriteLine("The Common elements between the objects are : ");
            foreach (var item in studobjdistinct2)
                Console.Write(item.StudentName + " " + "\n");
        }
        public static void UnionOps()
        {
            //integer
            //first takes all intlist2 elements and then distinct elements in intlist3
            var set1 = SetsPurpose.intList2;
            var set2 = SetsPurpose.intList3;
            //Except
            var distinctset = set1.Union(set2);
            Console.Write("The Common elements of integer are : ");
            foreach (var item in distinctset)
                Console.Write(item + " ");

            Console.WriteLine("\n");

            //string
            var set3 = SetsPurpose.strList1;
            var set4 = SetsPurpose.strList2;
            //Except
            var distinctset2 = set3.Union(set4);
            Console.Write("The Common elements of strings are : ");
            foreach (var item in distinctset2)
                Console.Write(item + " ");

            Console.WriteLine("\n");
        }
        public static void UnionIEqualityComparer()
        {
            var studobjdup4 = SetsPurpose.studentList8;
            var studobjdup7 = SetsPurpose.studentList6;

            var studobjdistinct2 = studobjdup4.Union(studobjdup7, new StudentComparer2());

            Console.WriteLine("The Common elements between the objects are : ");
            foreach (var item in studobjdistinct2)
                Console.Write(item.StudentName + " " + "\n");
        }

    }
    public class Sets
    {
        public static void ExecuteDistinctOps()
        {
            SetsOps.DistinctOps();
        }
        public static void ExecuteDistinctIEqualityComparer()
        {
            SetsOps.DistinctIEqualityComparer();
        }
        public static void ExecuteExceptOps()
        {
            SetsOps.ExceptOps();
        }
        public static void ExecuteExceptIEqualityComparer()
        {
            SetsOps.ExceptIEqualityComparer();
        }
        public static void ExecuteIntersectOps()
        {
            SetsOps.IntersectOps();
        }
        public static void ExecuteIntersectIEqualityComparer()
        {
            SetsOps.IntersectIEqualityComparer();
        }
        public static void ExecuteUnionOps()
        {
            SetsOps.UnionOps();
        }
        public static void ExecuteUnionIEqualityComparer()
        {
            SetsOps.UnionIEqualityComparer();
        }

    }
}
