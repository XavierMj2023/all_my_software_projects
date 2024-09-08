using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class SequenceEqualOps
    {
        public static void SequenceEqualComparisionWithPrimitiveDataTypeMethodSyntax()
        {
            //integer
            var intseqone = JoinPurposeClass.seequalA;
            var intseqtwo = JoinPurposeClass.seequalB;

            bool isEqual = intseqone.SequenceEqual(intseqtwo);
            Console.WriteLine("Is the 2 integer arrays equal : "+isEqual);//true

            //string
            var strseqone = JoinPurposeClass.seequalstr1;
            var strseqtwo = JoinPurposeClass.seequalstr2;

            bool isEqualstr = strseqone.SequenceEqual(strseqtwo);
            Console.WriteLine("Is the 2 string arrays equal : " + isEqualstr);//true
        }
        public static void SequenceEqualComparisionWithPrimitiveDataTypeOrderCheckMethodSyntax()
        {
            //integer
            var intseqone = JoinPurposeClass.seequalA;
            var intseqtwo = JoinPurposeClass.seequalC;

            bool isEqual = intseqone.SequenceEqual(intseqtwo);
            Console.WriteLine("Is the 2 integer arrays equal : " + isEqual);//true

            //string
            var strseqone = JoinPurposeClass.seequalstr1;
            var strseqtwo = JoinPurposeClass.seequalstr5;

            bool isEqualstr = strseqone.SequenceEqual(strseqtwo);
            Console.WriteLine("Is the 2 string arrays equal : " + isEqualstr);//true
        }
        public static void SequenceEqualComparisionWithPrimitiveDataTypeNumbersCheckMethodSyntax()
        {
            //integer
            var intseqone = JoinPurposeClass.seequalA;
            var intseqtwo = JoinPurposeClass.seequalD;

            bool isEqual = intseqone.SequenceEqual(intseqtwo);
            Console.WriteLine("Is the 2 integer arrays equal (Numbers): " + isEqual);//true

            //string
            var strseqone = JoinPurposeClass.seequalstr1;
            var strseqtwo = JoinPurposeClass.seequalstr4;

            bool isEqualstr = strseqone.SequenceEqual(strseqtwo);
            Console.WriteLine("Is the 2 string arrays equal (Strings): " + isEqualstr);//true
        }
        public static void SequenceEqualComparisionWithNonPrimitiveDataTypeMethodSyntax()
        {
            //objects equal
            var obj1 = SequenceEqualComaprision.soft1;
            var obj2 = SequenceEqualComaprision.soft2;

            bool isEqual = obj1.SequenceEqual(obj2);
            Console.WriteLine("Is the 2 objects equal (Same Reference) : " + isEqual);//true

            //objects having same values but not equal
            var obj3 = SequenceEqualComaprision.soft1;
            var obj4 = SequenceEqualComaprision.hardw;

            bool isEqual2 = obj3.SequenceEqual(obj4);
            Console.WriteLine("Is the 2 objects equal (Different Reference with same values) : " + isEqual2);//false

            //objects having different values but not equal
            var obj5 = SequenceEqualComaprision.soft1;
            var obj6 = SequenceEqualComaprision.hardw2;

            bool isEqual3 = obj5.SequenceEqual(obj6);
            Console.WriteLine("Is the 2 objects equal (Different Reference with different values) : " + isEqual3);//false
        }
        public static void SequenceEqualIEqualityComparer()
        {
            var stusequ1 = StudentClassForSequenceEqual.studentList1;
            var stusequ2 = StudentClassForSequenceEqual.studentList2;

            bool isEqualSeq = stusequ1.SequenceEqual(stusequ2,new StudentSeqEquComparer());

            Console.WriteLine("Is the 2 complex data types equal ? : " + isEqualSeq);
        }
    }
    public class SequenceEqual
    {
        public static void ExecuteSequenceEqual()
        {
            SequenceEqualOps.SequenceEqualComparisionWithPrimitiveDataTypeMethodSyntax();
        }
        public static void ExceuteSequenceEqualOrderCheck()
        {
            SequenceEqualOps.SequenceEqualComparisionWithPrimitiveDataTypeOrderCheckMethodSyntax();
        }
        public static void ExceuteSequenceEqualNumberCheck()
        {
            SequenceEqualOps.SequenceEqualComparisionWithPrimitiveDataTypeNumbersCheckMethodSyntax();
        }
        public static void ExecuteSequenceEqualNonPrimitiveDataTypeCheck()
        {
            SequenceEqualOps.SequenceEqualComparisionWithNonPrimitiveDataTypeMethodSyntax();
        }
        public static void ExecuteSequenceEqualIEqualityComparer()
        {
            SequenceEqualOps.SequenceEqualIEqualityComparer();
        }
    }
}
