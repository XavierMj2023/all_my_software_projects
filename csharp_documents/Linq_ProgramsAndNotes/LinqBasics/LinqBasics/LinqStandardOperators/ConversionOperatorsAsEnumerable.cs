using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class ConversionOperatorsAsEnumerable
    {
        public static void GiveType<T>(T obj)
        {
            Console.WriteLine("Compile Time Type : " + typeof(T).Name + "; Actual Type is : "+obj.GetType().Name);
        }
        public static void ConvertToAsEnumerable()
        {
            var studStoretomakeAsEnumerable = StudentClassOps.studentArray;
            GiveType(studStoretomakeAsEnumerable);
            GiveType(studStoretomakeAsEnumerable.AsEnumerable());
            GiveType(studStoretomakeAsEnumerable.AsQueryable());
        }
    }
}
