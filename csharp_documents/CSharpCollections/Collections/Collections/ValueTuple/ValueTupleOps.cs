using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collections.Tuple;

namespace Collections.ValueTuple
{
	public class ValueTupleOps
	{
		public void ValueTupleSwitch()
		{
			Console.WriteLine("Enter The Number To execute ValueTuple ops");
			int valtup = int.Parse(Console.ReadLine());
			switch (valtup)
			{
				case 0: break;
				case 1:
					Console.WriteLine("ValueTuple Syntax");
					ValueTupleSyntax();
					break;
				case 2:
					Console.WriteLine("ValueTuple Access");
					ValueTupleAccess();
					break;
				case 3:
					Console.WriteLine("ValueTuple Access In Shorter Way");
					ValueTupleShorterWayAccess();
					break;
				case 4:
					Console.WriteLine("ValueTuple Access In Named Member");
					ValueTupleNamedMember();
					break;
			}
		}
		public void ValueTupleSyntax()
		{
			Console.WriteLine("-------------------------------------------------------------------------");
			Console.WriteLine("ValueTuple<d1, d2,..dn> <var_name> = (datatype d1 , datatype d2,..,datatype dn)");
			Console.WriteLine("-------------------------------------------------------------------------");
			Console.WriteLine("var <var_name> = (d1,d2,..dn)");
			Console.WriteLine("-------------------------------------------------------------------------");
		}
		public void ValueTupleAccess()
		{
			ValueTuple<int, string, string> person = (1501, "NR Colony", "Shantinagar");

			Console.WriteLine("------------------------");
			Console.WriteLine("ValueTuple Access");
			Console.WriteLine("------------------------");
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine("| Number | From Address   | To Address");
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine($"| {person.Item1}     | {person.Item2} \t| {person.Item3}");
			Console.WriteLine("------------------------------------------------------------");
		}
		public void ValueTupleShorterWayAccess()
		{
			(int, string, string) person = (1, "NR Colony", "Nagavara");

			Console.WriteLine("------------------------");
			Console.WriteLine("ValueTuple Access In Shorter Way");
			Console.WriteLine("------------------------");
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine("| Number | From Address   | To Address");
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine($"| {person.Item1}     | {person.Item2} \t| {person.Item3}");
			Console.WriteLine("------------------------------------------------------------");
		}
		public void ValueTupleMoreThan8Elements()
		{
			var nunny = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17);
		}
		public void ValueTupleNamedMember()
		{
			(int Id, string from, string to) person = (1, "NR Colony", "Nagavara");

			Console.WriteLine("------------------------");
			Console.WriteLine("ValueTuple Access In Named Member");
			Console.WriteLine("------------------------");
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine("| Number | From Address   | To Address");
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine($"| {person.Id}     | {person.from} \t| {person.to}");
			Console.WriteLine("------------------------------------------------------------");
		}
	}
}
