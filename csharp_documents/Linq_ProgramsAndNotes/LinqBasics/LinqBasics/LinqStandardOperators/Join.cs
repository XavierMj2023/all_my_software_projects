using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class JoinOps
    {
        public static void JoinMethodSyntaxSimpleDemo()
        {
            var getJoinData1 = JoinPurposeClass.areaban1;
            var getJoinData2 = JoinPurposeClass.areaban2;
            var getJoinData3 = JoinPurposeClass.areaban3;

            // outer sequence --> getJoinData1
            var innerJoinres = getJoinData1.Join(
                                                getJoinData2,
                                                // inner sequence 
                                                getst1 => getst1,
                                                // outerKeySelector
                                                getst2 => getst2,
                                                // innerKeySelector
                                                (getst1,getst2)=>getst1
                                              );
            foreach (var cityvisit in innerJoinres)
                Console.WriteLine("{0}",cityvisit);
        }

        //https://www.tutorialsteacher.com/codeeditor?cid=cs-8nUDoV
        public static void JoinMethodSyntaxCopedExample()
        {
            var studentList = Student1.studentList;
            var standardList = Standard.standardList;

            var innerJoinResult = studentList.Join(//outer sequence
                                       standardList, //inner sequence
                                       student => student.StandardID, //outerKeySelector
                                       standard => standard.StandardID,  //innerKeySelector
                                       // result selector
                                       (student, standard) => new
                                       {
                                           StudentName = student.StudentName,
                                           StandardName = standard.StandardName
                                       });

            foreach (var obj in innerJoinResult)
            {
                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);

            }
        }
        public static void JoinMethodSyntax()
        {
            var studclass = StudentClass.studentList2;
            var collclass = College.collegelist;

            var joinclass = studclass.Join(//outer sequence
                                        collclass, //inner sequence
                                        studkey => studkey.CollegeId, //outerKeySelector
                                        collkey => collkey.CollegeId,  //innerKeySelector
                                       // result selector
                                        (studkey, collkey) => new
                                                {
                                                    StudentName = studkey.StudentName,
                                                    CollegeName = collkey.CollegeName
                                     });

            foreach (var joinstudcoll in joinclass)
                Console.WriteLine("Student : "+joinstudcoll.StudentName+" College : "+joinstudcoll.CollegeName);
        }
        public static void JoinQuerySyntax()
        {
            var studclass = StudentClass.studentList2;
            var collclass = College.collegelist;

            var joinclass = from st in studclass
                            join co in collclass
                            on st.CollegeId equals co.CollegeId
                            select new
                            {
                                StudentName = st.StudentName,
                                CollegeName = co.CollegeName
                            };

            foreach (var joinstudcoll in joinclass)
                Console.WriteLine("Student : " + joinstudcoll.StudentName + " College : " + joinstudcoll.CollegeName);
        }
    }
    public class Join
    {
        public static void GetJoinMethodSyntaxSimpleDemo()
        {
            JoinOps.JoinMethodSyntaxSimpleDemo();
        }
        public static void GetJoinMethodSyntaxCopy()
        {
            JoinOps.JoinMethodSyntaxCopedExample();
        }
        public static void GetJoinMethodSyntax()
        {
            JoinOps.JoinMethodSyntax();
        }
        public static void GetJoinQuerySyntax()
        {
            JoinOps.JoinQuerySyntax();
        }
    }
}
