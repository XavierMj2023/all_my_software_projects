using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class GroupJoinOps
    {
        public static void GroupJoinMethodSyntax()
        {
            var groupstudli = StudentClass3.studentList3;
            var groupstdli = Standard.standardList;

            var leftorgroupjoin = groupstdli.GroupJoin(groupstudli,
                                                      gst => gst.StandardID,
                                                      gss => gss.StandardID,
                                                      (gst, studentGroups) => new
                                                      {
                                                          Students = studentGroups,
                                                          Standards = gst.StandardName
                                                      });
            foreach(var lgroup in leftorgroupjoin)
            {
                Console.WriteLine("Standard Group : " + lgroup.Standards);

                Console.WriteLine("--------------------------------------");
                foreach (var lstud in lgroup.Students)
                {
                    Console.WriteLine("Student Name : " + lstud.StudentName);
                }
                Console.WriteLine("--------------------------------------");
            }
        }
        public static void GroupJoinQuerySyntax()
        {
            var groupstudli = StudentClass3.studentList3;
            var groupstdli = Standard.standardList;

            var leftorgroupjoin = from g in groupstdli
                                  join inng in groupstudli
                                  on g.StandardID equals inng.StandardID
                                  into stugroup
                                  select new
                                  {
                                      Students = stugroup,
                                      Standard = g.StandardName
                                  };

            foreach (var lgroup in leftorgroupjoin)
            {
                Console.WriteLine("Standard Group : " + lgroup.Standard);

                Console.WriteLine("--------------------------------------");
                foreach (var lstud in lgroup.Students)
                {
                    Console.WriteLine("Student Name : " + lstud.StudentName);
                }
                Console.WriteLine("--------------------------------------");
            }
        }
    }
    public class Join_GroupJoin
    {
        public static void GetGroupJoinMethodSyntax()
        {
            GroupJoinOps.GroupJoinMethodSyntax();
        }
        public static void GetGroupJoinQuerySyntax()
        {
            GroupJoinOps.GroupJoinQuerySyntax();
        }
    }
}
