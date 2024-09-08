using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics.LinqStandardOperatorsClasses
{
    public class Software
    {
        public int SoftwareId { get; set; }
        public string SoftwareName { get; set; }
        public int SoftwareRating { get; set; }
    }
    public class SequenceEqualComaprision
    {
        public static Software soft = new Software() { SoftwareId = 1, SoftwareName = "C#" ,
                                                       SoftwareRating = 10};

        public static Software hard = new Software()
        {
            SoftwareId = 1,
            SoftwareName = "C#",
            SoftwareRating = 10
        };

        public static Software hard2 = new Software()
        {
            SoftwareId = 2,
            SoftwareName = "Java",
            SoftwareRating = 15
        };

        public static IList<Software> soft1 = new List<Software>() { soft };

        public static IList<Software> soft2 = new List<Software>() { soft };

        public static IList<Software> hardw = new List<Software>() { hard };

        public static IList<Software> hardw2 = new List<Software>() { hard2 };
    }
    public class JoinPurposeClass
    {
        public static IList<string> areaban1 = new List<string>()
        {
            "HSR Layout","Domlur","Trinity","MG Road","Yelhanka","Majestic"
        };
        public static IList<string> areaban2 = new List<string>()
        {
            "Bannerghatta Road","Electronic City","Majestic","Chickpet","HSR Layout","Shivajinagar"
        };
        public static IList<string> areaban3 = new List<string>()
        {
            "Bannerghatta Road","Whitefield","Majestic","Hulimavu","HSR Layout","Rajajinagar"
        };
        public static IList<int> evenmums = new List<int>() { 2, 4, 6, 12, 18, 24, 30, 40, 48, 52,
                                                              60};

        public static IList<int> tnums = new List<int>() { 2, 24, 30, 45, 55, 60,
                                                              25};

        public static IList<int> maxnums = new List<int>() { 10, 21, 30, 45, 50, 87 };

        public static IList<string> purele = new List<string>() { "One", "Two", null, "Four", "Five","Manoj" };

        public static IList<int> emptytestForInt_First = new List<int>() { }; 

        public static IList<string> emptytestForString_First = new List<string>() { };

        public static IList<int> pureleinty = new List<int>() { 12,14,18,23,29,30,32};

        public static IList<string> pnull = new List<string>() { null,"Two" };

        public static IList<string> lnull = new List<string>() { "Two" , null };

        public static IList<int> single_num = new List<int>() { 9087 };

        public static IList<int> single_num2 = new List<int>() { 9,8 };

        public static IList<int> single_num3 = new List<int>() { 2,4,6,8,10,1,3,5,7,9,12,78,77,
                                                                 34,45,45};

        //Sequence Equal
        public static IList<int> seequalA = new List<int>() { 1,2,3};

        public static IList<int> seequalB = new List<int>() { 1,2,3 };

        public static IList<int> seequalC = new List<int>() { 1, 3, 2 };

        public static IList<int> seequalD = new List<int>() { 1, 2, 3 ,4};

        public static IList<string> seequalstr1 = new List<string>() {"one","ragi","smooth" };

        public static IList<string> seequalstr2 = new List<string>() { "one", "ragi", "smooth" };

        public static IList<string> seequalstr3 = new List<string>() { "two", "ragi", "smootha" };

        public static IList<string> seequalstr4 = new List<string>() { "one", "ragi", "smooth","zig"};

        public static IList<string> seequalstr5 = new List<string>() { "ragi", "one", "smooth" };

        //Concat
        public static IList<string> areaban4 = new List<string>()
        {
            "Bannerghatta Road","Whitefield"
        };
        public static IList<string> areaban5 = new List<string>()
        {
            "BTM","HSR"
        };

        //SkipWhile
        public static IList<int> numskips = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

        public static IList<int> numskips2 = new List<int>() { 15,25,13,34,95,8};

        public static IList<string> seequalstr6 = new List<string>() { "ragi", "rava", "smoothie","man","gam","cham" };

        //DefaultIfEmpty
        public static IList<string> emplist = new List<string>();

        public static IList<SequenceEqualComaprision> seuel = new List<SequenceEqualComaprision>();
    }
}