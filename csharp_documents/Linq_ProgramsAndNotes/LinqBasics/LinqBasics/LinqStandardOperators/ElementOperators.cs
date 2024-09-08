using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class ElementAt
    {
        public static void ElementAtOps()
        {
            //Collection 1 --> int type
            var nums = JoinPurposeClass.maxnums;
            Console.WriteLine("Returns the element at a 0 index in a collection 1 : " 
                               + nums.ElementAt(0));
            Console.WriteLine("Returns the element at a 1 index in a collection 1 : "
                              + nums.ElementAt(1));
            Console.WriteLine("Returns the element at a 4 index in a collection 1 : "
                             + nums.ElementAt(4));

            Console.WriteLine("***********************************\n");

            //Collection 2 --> string type
            var strs = JoinPurposeClass.purele;
            Console.WriteLine("Returns the element at a 0 index in a collection 2 : "
                              + strs.ElementAt(0));
            Console.WriteLine("Returns the element at a 1 index in a collection 2 : "
                             + strs.ElementAt(1));
            Console.WriteLine("Returns the element at a 2 index in a collection 2 : "
                             + strs.ElementAt(2));
            Console.WriteLine("My Name is : "+ strs.ElementAt(5));
        }
        public static void ElementAtOrDefaultOps()
        {
            //Collection 1 --> int type
            var nums = JoinPurposeClass.maxnums;
            Console.WriteLine("Returns the element at a 0 index in a collection 1 : "
                               + nums.ElementAtOrDefault(0));
            Console.WriteLine("Returns the element at a 1 index in a collection 1 : "
                              + nums.ElementAtOrDefault(1));
            Console.WriteLine("Returns the element at a 4 index in a collection 1 : "
                             + nums.ElementAtOrDefault(4));

            Console.WriteLine("***********************************\n");

            //Collection 2 --> string type
            var strs = JoinPurposeClass.purele;
            Console.WriteLine("Returns the element at a 0 index in a collection 2 : "
                              + strs.ElementAtOrDefault(0));
            Console.WriteLine("Returns the element at a 1 index in a collection 2 : "
                             + strs.ElementAtOrDefault(1));
            Console.WriteLine("Returns the element at a 2 index in a collection 2 : "
                             + strs.ElementAtOrDefault(2));
            Console.WriteLine("My Name is : " + strs.ElementAtOrDefault(5));
            //Console.WriteLine("Any Error? : " + strs.ElementAtOrDefault(9));
        }
        public static void ElementAtError()
        {
            //Collection 1
            var nums = JoinPurposeClass.maxnums;
            try
            {
                Console.WriteLine("Returns the element at a 9 index in a collection 1 : "
                               + nums.ElementAt(9));
            }
            catch(Exception e)
            {
                Console.WriteLine("Error is : "+e.Message);
            }
            finally
            {
                Console.WriteLine("Please Enter The Correct Index from Collection 1" + "\n");
            }
            //Collection 2
            var strs = JoinPurposeClass.purele;
            try
            {
                Console.WriteLine("Returns the element at a 9 index in a collection 2 : "
                              + strs.ElementAt(9));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
            finally
            {
                Console.WriteLine("Please Enter The Correct Index from Collection 2");
            }
        }
        public static void ElementAtOrDefaultError()
        {
            //Collection 1
            var nums = JoinPurposeClass.maxnums;
            try
            {
                Console.WriteLine("Returns the element at a 9 index in a collection 1 : "
                               + nums.ElementAtOrDefault(9));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
            //Collection 2
            var strs = JoinPurposeClass.purele;
            try
            {
                Console.WriteLine("Returns the element at a 9 index in a collection 2 : "
                              + strs.ElementAtOrDefault(9)); //returns null
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
        }
        public static void First()
        {
            //Collection 1
            var eveFirst = JoinPurposeClass.evenmums;
            Console.WriteLine("Returns the first element of a collection 1 : " +eveFirst.First());

            //Collection 2
            var purFirst = JoinPurposeClass.purele;
            Console.WriteLine("Returns the first element of a collection 2 : " + purFirst.First());
        }
        public static void FirstOrDefault()
        {
            //Collection 1
            var eveFirst = JoinPurposeClass.evenmums;
            Console.WriteLine("Returns the first element of a collection 1 : " 
                              + eveFirst.FirstOrDefault());

            //Collection 2
            var purFirst = JoinPurposeClass.purele;
            Console.WriteLine("Returns the first element of a collection 2 : " 
                              + purFirst.FirstOrDefault());
        }
        public static void FirstWithCondition()
        {
            //Collection 1
            var eveFirst = JoinPurposeClass.evenmums;
            Console.WriteLine("Returns the first element of specified condition in a collection 1 : " 
                               + eveFirst.First(modfive => modfive % 5 == 0)); //30

            //Collection 3
            var purFirst = JoinPurposeClass.maxnums;
            Console.WriteLine("Returns the first element of specified condition in a collection 3 : "
                               + purFirst.First(greatthan => greatthan > 45)); //50
        }
        public static void FirstOrDefaultWithCondition()
        {
            //Collection 1
            var eveFirst = JoinPurposeClass.evenmums;
            Console.WriteLine("Returns the first element of specified condition in a collection 1 : "
                               + eveFirst.FirstOrDefault(modfive => modfive % 5 == 0)); //30

            //Collection 3
            var purFirst = JoinPurposeClass.maxnums;
            Console.WriteLine("Returns the first element of specified condition in a collection 3 : "
                               + purFirst.FirstOrDefault(greatthan => greatthan > 45)); //50
        }
        public static void FirstWithError()
        {
            //Collection 1
            var emptyint = JoinPurposeClass.emptytestForInt_First;
            try
            {
                Console.WriteLine("Returns the first element in a collection 1 : "
                               + emptyint.First());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
            finally
            {
                Console.WriteLine("Please Enter The Data in Collection 1" + "\n");
            }
            //Collection 2
            var emptystring = JoinPurposeClass.emptytestForString_First;
            try
            {
                Console.WriteLine("Returns the first element in a collection 2 : "
                              + emptystring.First());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
            finally
            {
                Console.WriteLine("Please Enter The Data in Collection 2");
            }
        }
        public static void FirstOrDefaultWithError()
        {
            //Collection 1
            var emptyint = JoinPurposeClass.emptytestForInt_First;
            try
            {
                Console.WriteLine("Returns the first element in a collection 1 : "
                               + emptyint.FirstOrDefault());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
            //Collection 2
            var emptystring = JoinPurposeClass.emptytestForString_First;
            try
            {
                Console.WriteLine("Returns the first element in a collection 2 : "
                              + emptystring.FirstOrDefault());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
        }
        public static void FirstErrorWithUnsatisfiedCondition()
        {
            var checkfirstnull = JoinPurposeClass.pureleinty;
            try
            {
                Console.WriteLine(checkfirstnull.First(mory => mory >32));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
        }
        public static void FirstOrDefaultErrorWithUnsatisfiedCondition()
        {
            var checkfirstnull = JoinPurposeClass.pureleinty;
            try
            {
                Console.WriteLine(checkfirstnull.FirstOrDefault(mory => mory > 32));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
        }
        public static void FirstOrDefaultErrorNull()
        {
            var pstrnull = JoinPurposeClass.pnull;
            try
            {
                Console.WriteLine("Returns the first element in a collection 1 : "
                               + pstrnull.FirstOrDefault(cont => cont.Contains("T")));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
            finally
            {
                Console.WriteLine("The first element is null" + "\n");
            }
        }
        public static void Last()
        {
            //Collection 1
            var eveFirst = JoinPurposeClass.evenmums;
            Console.WriteLine("Returns the last element of a collection 1 : " + eveFirst.Last());

            //Collection 2
            var purFirst = JoinPurposeClass.purele;
            Console.WriteLine("Returns the last element of a collection 2 : " + purFirst.Last());
        }
        public static void LastOrDefault()
        {
            //Collection 1
            var eveFirst = JoinPurposeClass.evenmums;
            Console.WriteLine("Returns the last element of a collection 1 : "
                              + eveFirst.LastOrDefault());

            //Collection 2
            var purFirst = JoinPurposeClass.purele;
            Console.WriteLine("Returns the last element of a collection 2 : "
                              + purFirst.LastOrDefault());
        }
        public static void LastWithCondition()
        {
            //Collection 1
            var eveFirst = JoinPurposeClass.evenmums;
            Console.WriteLine("Returns the last element of specified condition in a collection 1 : "
                               + eveFirst.Last(modfive => modfive % 5 == 0)); //30

            //Collection 3
            var purFirst = JoinPurposeClass.maxnums;
            Console.WriteLine("Returns the last element of specified condition in a collection 3 : "
                               + purFirst.Last(greatthan => greatthan > 45)); //50
        }
        public static void LastOrDefaultWithCondition()
        {
            //Collection 1
            var eveFirst = JoinPurposeClass.evenmums;
            Console.WriteLine("Returns the last element of specified condition in a collection 1 : "
                               + eveFirst.LastOrDefault(modfive => modfive % 5 == 0));

            //Collection 3
            var purFirst = JoinPurposeClass.maxnums;
            Console.WriteLine("Returns the last element of specified condition in a collection 3 : "
                               + purFirst.LastOrDefault(greatthan => greatthan > 45));
        }
        public static void LastWithError()
        {
            //Collection 1
            var emptyint = JoinPurposeClass.emptytestForInt_First;
            try
            {
                Console.WriteLine("Returns the last element in a collection 1 : "
                               + emptyint.Last());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
            finally
            {
                Console.WriteLine("Please Enter The Data in Collection 1" + "\n");
            }
            //Collection 2
            var emptystring = JoinPurposeClass.emptytestForString_First;
            try
            {
                Console.WriteLine("Returns the last element in a collection 2 : "
                              + emptystring.Last());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
            finally
            {
                Console.WriteLine("Please Enter The Data in Collection 2");
            }
        }
        public static void LastOrDefaultWithError()
        {
            //Collection 1
            var emptyint = JoinPurposeClass.emptytestForInt_First;
            try
            {
                Console.WriteLine("Returns the last element in a collection 1 : "
                               + emptyint.LastOrDefault());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
            //Collection 2
            var emptystring = JoinPurposeClass.emptytestForString_First;
            try
            {
                Console.WriteLine("Returns the last element in a collection 2 : "
                              + emptystring.LastOrDefault());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
        }
        public static void LastErrorWithUnsatisfiedCondition()
        {
            var checkfirstnull = JoinPurposeClass.pureleinty;
            try
            {
                Console.WriteLine(checkfirstnull.Last(mory => mory > 32));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
        }
        public static void LastOrDefaultErrorWithUnsatisfiedCondition()
        {
            var checkfirstnull = JoinPurposeClass.pureleinty;
            try
            {
                Console.WriteLine(checkfirstnull.LastOrDefault(mory => mory > 32));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
        }
        public static void LastOrDefaultErrorNull()
        {
            var pstrnull = JoinPurposeClass.lnull;
            try
            {
                Console.WriteLine("Returns the last element in a collection 1 : "
                               + pstrnull.LastOrDefault(cont => cont.Contains("T")));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is : " + e.Message);
            }
            finally
            {
                Console.WriteLine("The last element is null" + "\n");
            }
        }
        public static void Single()
        {
            var sinmingle = JoinPurposeClass.single_num;
            Console.WriteLine("Returns the single element in a collection 1 : "
                              + sinmingle.Single());
        }
        public static void SingleOrDefault()
        {
            var sinmingle = JoinPurposeClass.single_num;
            Console.WriteLine("Returns the single element in a collection 1 : "
                              + sinmingle.SingleOrDefault());
        }
        public static void SingleCondition()
        {
            var sinmingle = JoinPurposeClass.single_num2;
            Console.WriteLine("Returns the single element in a collection 1 : "
                              + sinmingle.Single(si => si % 2 == 0 ));
        }
        public static void SingleOrDefaultCondition()
        {
            var sinmingle = JoinPurposeClass.single_num2;
            Console.WriteLine("Returns the single element in a collection 1 : "
                              + sinmingle.SingleOrDefault(si => si % 2 == 0));
        }
        public static void SingleError()
        {
            //Case 1 -> Check output when there is no element for specified condition
            try
            {
                var sinmingle = JoinPurposeClass.single_num3;
                Console.WriteLine("Returns output when there is no element for specified condition : "
                                  + sinmingle.Single(mas => mas > 99));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
            finally
            {
                Console.WriteLine("Check if there is more than one element in collection"+"\n");
            }
            //Case 2 -> Check output when there is multiple element for specified condition
            try
            {
                var sinmingle = JoinPurposeClass.single_num3;
                Console.WriteLine("Returns output when there is multiple element for specified condition : "
                                  + sinmingle.Single(mas => mas % 2 == 0));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
            finally
            {
                Console.WriteLine("Check if there is more than one element in collection");
            }
        }
        public static void SingleOrDefaultError()
        {
            //Case 1 -> Check output when there is no element for specified condition
            try
            {
                var sinmingle = JoinPurposeClass.single_num3;
                Console.WriteLine("Returns output when there is no element for specified condition : "
                                  + sinmingle.SingleOrDefault(mas => mas > 99));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
            //Case 2 -> Check output when there is multiple element for specified condition
            try
            {
                var sinmingle = JoinPurposeClass.single_num3;
                Console.WriteLine("Returns output when there is multiple element for specified condition : "
                                  + sinmingle.SingleOrDefault(mas => mas % 2 == 0));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
        }
    }
    public class ElementOperators
    {
        public static void ExecuteElementAtOps()
        {
            ElementAt.ElementAtOps();
        }
        public static void ExecuteElementAtOrDefaultOps()
        {
            ElementAt.ElementAtOrDefaultOps();
        }
        public static void ExecuteElementAtError()
        {
            ElementAt.ElementAtError();
        }
        public static void ExecuteElementAtOrDefaultError()
        {
            ElementAt.ElementAtOrDefaultError();
        }
        public static void ExecuteFirst()
        {
            ElementAt.First();
        }
        public static void ExecuteFirstOrDefault()
        {
            ElementAt.FirstOrDefault();
        }
        public static void ExecuteFirstWithCondition()
        {
            ElementAt.FirstWithCondition();
        }
        public static void ExecuteFirstOrDefaultWithCondition()
        {
            ElementAt.FirstOrDefaultWithCondition();
        }
        public static void ExecuteFirstWithError()
        {
            ElementAt.FirstWithError();
        }
        public static void ExecuteFirstOrDefaultWithError()
        {
            ElementAt.FirstOrDefaultWithError();
        }
        public static void ExecuteFirstErrorWithUnsatisfiedCondition()
        {
            ElementAt.FirstErrorWithUnsatisfiedCondition();
        }
        public static void ExecuteFirstOrDefaultErrorWithUnsatisfiedCondition()
        {
            ElementAt.FirstOrDefaultErrorWithUnsatisfiedCondition();
        }
        public static void ExecuteFirstOrDefaultErrorNull()
        {
            ElementAt.FirstOrDefaultErrorNull();
        }
        public static void ExecuteLast()
        {
            ElementAt.Last();
        }
        public static void ExecuteLastOrDefault()
        {
            ElementAt.LastOrDefault();
        }
        public static void ExecuteLastWithCondition()
        {
            ElementAt.LastWithCondition();
        }
        public static void ExecuteLastOrDefaultWithCondition()
        {
            ElementAt.LastOrDefaultWithCondition();
        }
        public static void ExecuteLastWithError()
        {
            ElementAt.LastWithError();
        }
        public static void ExecuteLastOrDefaultWithError()
        {
            ElementAt.LastOrDefaultWithError();
        }
        public static void ExecuteLastErrorWithUnsatisfiedCondition()
        {
            ElementAt.LastErrorWithUnsatisfiedCondition();
        }
        public static void ExecuteLastOrDefaultErrorWithUnsatisfiedCondition()
        {
            ElementAt.LastOrDefaultErrorWithUnsatisfiedCondition();
        }
        public static void ExecuteLastOrDefaultErrorNull()
        {
            ElementAt.LastOrDefaultErrorNull();
        }
        public static void ExecuteSingle()
        {
            ElementAt.Single();
        }
        public static void ExecuteSingleOrDefault()
        {
            ElementAt.SingleOrDefault();
        }
        public static void ExecuteSingleCondition()
        {
            ElementAt.SingleCondition();
        }
        public static void ExecuteSingleOrDefaultCondition()
        {
            ElementAt.SingleOrDefaultCondition();
        }
        public static void ExecuteSingleError()
        {
            ElementAt.SingleError();
        }
        public static void ExecuteSingleOrDefaultError()
        {
            ElementAt.SingleOrDefaultError();
        }
    }
}
