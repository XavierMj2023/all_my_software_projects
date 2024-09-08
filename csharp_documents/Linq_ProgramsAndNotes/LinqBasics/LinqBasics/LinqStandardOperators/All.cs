using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class All
    {
        public static void ResultTeenagers()
        {
            var teens = Teenager.Teeages;

            bool teenreturn = teens.All(retteen => retteen.Teeage > 12 && retteen.Teeage < 15);

            Console.WriteLine("The Status of the teenagers report whether there are all teens : "
                               +teenreturn);
        }
    }
}
