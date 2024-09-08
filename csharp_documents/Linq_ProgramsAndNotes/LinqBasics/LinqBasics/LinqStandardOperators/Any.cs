using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.LinqStandardOperatorsClasses;

namespace LinqBasics.LinqStandardOperators
{
    public class Any
    {
        public static void AnyOps()
        {
            var teens = Teenager.Teeages;

            bool teenreturn = teens.Any(retteen => retteen.Teeage > 12 && retteen.Teeage < 15);

            Console.WriteLine("The Status of the teenagers report whether there are any teens : "
                               + teenreturn);
        }
    }
}
