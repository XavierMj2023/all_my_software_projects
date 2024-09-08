using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics.LinqStandardOperators
{
    public class PassportRate
    {
        public int PassportID { get; set; }
        public string PassportType { get; set; }
        public float VisaRate { get; set; }
    }
    public class OfTypeExecutation
    {
        public static void OfTypeProcess()
        {
            IList mixedList = new ArrayList();    
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new PassportRate() { PassportID = 1, PassportType = "Bill" ,
                                               VisaRate = 5.26f
                                             });
            var stringres = from str in mixedList.OfType<string>()
                            select str;

            var inttype = from intstr in mixedList.OfType<int>()
                          select intstr;

            var objectPass = from objectPassport in mixedList.OfType<PassportRate>()
                             select objectPassport;

            Console.WriteLine("The filtered strings are : ");
            foreach (var stringget in stringres)
                    Console.WriteLine(stringget);

            Console.WriteLine("The filtered integer are : ");
            foreach (var intget in inttype)
                Console.WriteLine(intget);

            Console.WriteLine("The Object Passport Rate are : ");
            foreach (var obj in objectPass)
                Console.WriteLine(obj.VisaRate);
        }
        public static void OfTypeProcessUsingMethodSyntax()
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new PassportRate()
            {
                PassportID = 1,
                PassportType = "Bill",
                VisaRate = 5.26f
            });
            var sres = mixedList.OfType<string>();

            var ires = mixedList.OfType<int>();

            var objres = mixedList.OfType<PassportRate>();

            Console.WriteLine("The filtered strings are : ");
            foreach (var stringget in sres)
                Console.WriteLine(stringget);

            Console.WriteLine("The filtered integer are : ");
            foreach (var intget in ires)
                Console.WriteLine(intget);

            Console.WriteLine("The Object Passport Rate are : ");
            foreach (var obj in objres)
                Console.WriteLine(obj.VisaRate);
        }
    }
    public class OfType
    {
        public static void GetResultQuerySyntax_OfType()
        {
            OfTypeExecutation.OfTypeProcess();
        }
        public static void GetResultMethodSyntax_OfType()
        {
            OfTypeExecutation.OfTypeProcessUsingMethodSyntax();
        }
    }
}
