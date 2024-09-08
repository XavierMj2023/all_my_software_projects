using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class ToDictonary
    {
        public static void ToDictonaryOps()
        {
            var studtodict = ToConvertSomething.toDicts;

            IDictionary<int, StudentToDict> studToDictProcess = studtodict.ToDictionary<StudentToDict, int>(s => s.StudentID);

            foreach (var dictkeys in studToDictProcess.Keys)
                Console.WriteLine("Key : {0} , Value : {1} ", dictkeys, (studToDictProcess[dictkeys] as StudentToDict).StudentName);
        }
    }
}
