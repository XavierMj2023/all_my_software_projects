using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class PartitioningOps
    {
        public static void SkipOp()
        {
            //integer
            var intsplit = SetsPurpose.intList1;
            var resplit = intsplit.Skip(3);

            Console.WriteLine("Before Splitting the numbers are :");
            Console.WriteLine("-----------------------------------");
            foreach (int normsplit in intsplit)
                Console.Write(normsplit+"  ");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("After Splitting the numbers are : ");
            Console.WriteLine("-----------------------------------");
            foreach (int splitele in resplit)
                Console.Write(splitele+"  ");
            Console.WriteLine();

            //string
            var strsplit = SetsPurpose.strList;
            var resstplit = strsplit.Skip(3);
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Before Splitting the strings are : ");
            Console.WriteLine("-----------------------------------");
            foreach (string normsplit in strsplit)
                Console.Write(normsplit + "  ");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("After Splitting the strings are : ");
            Console.WriteLine("-----------------------------------");
            foreach (string splitele in resstplit)
                Console.Write(splitele + "  ");
            Console.WriteLine();
        }
        public static void SkipWhileOp()
        {
            //integer
            var intsplit = SetsPurpose.intList2;
            var resplit = intsplit.SkipWhile(partskipwhile => partskipwhile % 2 != 0);

            Console.WriteLine("Before Splitting the numbers are :");
            Console.WriteLine("-----------------------------------");
            foreach (int normsplit in intsplit)
                Console.Write(normsplit + "  ");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("After Splitting the numbers are : ");
            Console.WriteLine("-----------------------------------");
            foreach (int splitele in resplit)
                Console.Write(splitele + "  ");
            Console.WriteLine();

            //string
            //Duplicate elements are not given priority,it will skip as usual
            var strsplit = SetsPurpose.strList;
            var resstplit = strsplit.SkipWhile(strskip => strskip.Length <= 3);
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Before Splitting the strings are : ");
            Console.WriteLine("-----------------------------------");
            foreach (string normsplit in strsplit)
                Console.Write(normsplit + "  ");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("After Splitting the strings are : ");
            Console.WriteLine("-----------------------------------");
            foreach (string splitele in resstplit)
                Console.Write(splitele + "  ");
            Console.WriteLine();
        }
        public static void SkipWhileOpSecondOverload()
        {
            //integer
            var intsplit = JoinPurposeClass.numskips2;
            var resplit1 = intsplit.SkipWhile((no, ind) => no > 5 && ind <= 3);
            var resplit2 = intsplit.SkipWhile((no, ind) => ind <= 3 && no > 5 );

            Console.WriteLine("Before Splitting the numbers are :");
            Console.WriteLine("-----------------------------------");
            foreach (int normsplit in intsplit)
                Console.Write(normsplit + "  ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("After Splitting the numbers (no > 5 && ind <= 3) are : ");
            Console.WriteLine("---------------------------------------------------------");
            foreach (int splitele in resplit1)
                Console.Write(splitele + "  ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("After Splitting the numbers (ind <= 3 && no > 5) are : ");
            Console.WriteLine("---------------------------------------------------------");
            foreach (int splitele in resplit1)
                Console.Write(splitele + "  ");
            Console.WriteLine();

            //string
            //Duplicate elements are not given priority,it will skip as usual
            var strsplit = JoinPurposeClass.seequalstr6;
            var resstplit = strsplit.SkipWhile((strskip,ind) => strskip.Length > ind);
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Before Splitting the strings are : ");
            Console.WriteLine("-----------------------------------");
            foreach (string normsplit in strsplit)
                Console.Write(normsplit + "  ");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("After Splitting the strings are : ");
            Console.WriteLine("-----------------------------------");
            foreach (string splitele in resstplit)
                Console.Write(splitele + "  ");
            Console.WriteLine();
            
        }
        public static void TakeOp()
        {
            //integer
            var intsplit = SetsPurpose.intList1;
            var resplit = intsplit.Take(3);

            Console.WriteLine("Before Splitting the numbers are :");
            Console.WriteLine("-----------------------------------");
            foreach (int normsplit in intsplit)
                Console.Write(normsplit + "  ");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("After Splitting the numbers are : ");
            Console.WriteLine("-----------------------------------");
            foreach (int splitele in resplit)
                Console.Write(splitele + "  ");
            Console.WriteLine();

            //string
            var strsplit = SetsPurpose.strList;
            var resstplit = strsplit.Take(3);
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Before Splitting the strings are : ");
            Console.WriteLine("-----------------------------------");
            foreach (string normsplit in strsplit)
                Console.Write(normsplit + "  ");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("After Splitting the strings are : ");
            Console.WriteLine("-----------------------------------");
            foreach (string splitele in resstplit)
                Console.Write(splitele + "  ");
            Console.WriteLine();
        }
        public static void TakeWhileOp()
        {
            //integer
            var intsplit = SetsPurpose.intList2;
            var resplit = intsplit.TakeWhile(partskipwhile => partskipwhile % 2 != 0);

            Console.WriteLine("Before Splitting the numbers are :");
            Console.WriteLine("-----------------------------------");
            foreach (int normsplit in intsplit)
                Console.Write(normsplit + "  ");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("After Splitting the numbers are : ");
            Console.WriteLine("-----------------------------------");
            foreach (int splitele in resplit)
                Console.Write(splitele + "  ");
            Console.WriteLine();

            //string
            //Duplicate elements are not given priority,it will skip as usual
            var strsplit = SetsPurpose.strList;
            var resstplit = strsplit.TakeWhile(strskip => strskip.Length <= 3);
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Before Splitting the strings are : ");
            Console.WriteLine("-----------------------------------");
            foreach (string normsplit in strsplit)
                Console.Write(normsplit + "  ");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("After Splitting the strings are : ");
            Console.WriteLine("-----------------------------------");
            foreach (string splitele in resstplit)
                Console.Write(splitele + "  ");
            Console.WriteLine();
        }
        public static void TakeWhileOpSecondOverload()
        {
            //integer
            var intsplit = JoinPurposeClass.numskips2;
            var resplit1 = intsplit.TakeWhile((no, ind) => no > 5 && ind <= 3);
            var resplit2 = intsplit.TakeWhile((no, ind) => ind <= 3 && no > 5);

            Console.WriteLine("Before Splitting the numbers are :");
            Console.WriteLine("-----------------------------------");
            foreach (int normsplit in intsplit)
                Console.Write(normsplit + "  ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("After Splitting the numbers (no > 5 && ind <= 3) are : ");
            Console.WriteLine("---------------------------------------------------------");
            foreach (int splitele in resplit1)
                Console.Write(splitele + "  ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("After Splitting the numbers (ind <= 3 && no > 5) are : ");
            Console.WriteLine("---------------------------------------------------------");
            foreach (int splitele in resplit1)
                Console.Write(splitele + "  ");
            Console.WriteLine();

            //string
            //Duplicate elements are not given priority,it will skip as usual
            var strsplit = JoinPurposeClass.seequalstr6;
            var resstplit = strsplit.TakeWhile((strskip, ind) => strskip.Length > ind);
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Before Splitting the strings are : ");
            Console.WriteLine("-----------------------------------");
            foreach (string normsplit in strsplit)
                Console.Write(normsplit + "  ");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("After Splitting the strings are : ");
            Console.WriteLine("-----------------------------------");
            foreach (string splitele in resstplit)
                Console.Write(splitele + "  ");
            Console.WriteLine();

        }
    }
    public class Partitioning
    {
        public static void ExecuteSkip()
        {
            PartitioningOps.SkipOp();
        }
        public static void ExecuteSkipWhile()
        {
            PartitioningOps.SkipWhileOp();
        }
        public static void ExecuteSkipWhileOpSecondOverload()
        {
            PartitioningOps.SkipWhileOpSecondOverload();
        }
        public static void ExecuteTake()
        {
            PartitioningOps.TakeOp();
        }
        public static void ExecuteTakeWhile()
        {
            PartitioningOps.TakeWhileOp();
        }
        public static void ExecuteTakeWhileOpSecondOverload()
        {
            PartitioningOps.TakeWhileOpSecondOverload();
        }
    }
}
