using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tuple
{
	public class TupleOps
	{
		Tuple<int, string, string> person = new Tuple<int, string, string>(101,"Mrungajali","Sarvesh");

		public void TupleSwitch()
		{
			Console.WriteLine("Enter The Number To execute Queque ops");
			int tupleopt = int.Parse(Console.ReadLine());
			switch (tupleopt)
			{
				case 0: break;
				case 1: Console.WriteLine("Tuple Syntax");
					    TupleSyntax();
						break;
				case 2: Console.WriteLine("Tuple Access");
					    TupleAccess();
						break;
				case 3: Console.WriteLine("Tuple Accessing First 7 Elements");
						TupleAccessingExceptLastElement();
					    break;
				case 4: Console.WriteLine("Tuple Access Using Rest Property");
					    TupleUsingRestPropertyForLastElement();
						break;
				case 5: Console.WriteLine("Nested Tuple");
					    TupleNestedTuple();
						break;
				case 6: Console.WriteLine("Tuple as a Parameter");
					    TupleAsAParameter();
						break;
				case 7: Console.WriteLine("Tuple as a return type");
						TupleReturnTypeMethod();
						break;
			}
		}
		public void TupleSyntax()
		{
			Console.WriteLine("-----------------------------------------------------------------------------------------------------");
			Console.WriteLine("Tuple<datatype1,datatype2,datatype3> <varname> = new Tuple <datatype1,datatype2,datatype3>(parameters)");
			Console.WriteLine("-----------------------------------------------------------------------------------------------------");

			Console.WriteLine("-----------------------------------------------------------------------------------------------------");
			Console.WriteLine("var tuple_name = Tuple.Create(d1,d2,d3,..dn)");
			Console.WriteLine("-----------------------------------------------------------------------------------------------------");
		}
		public void TupleMoreThan8Elements()
		{
			//Error - No Overload takes over 9 Arguments

			//var tuppy = System.Tuple.Create(1, "Sanga", 2, "Basava", 3, "Hunda", 4, "Basa", 5.6);
		}
		public void TupleAccess()
		{
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("Accessing the Tuple elements");
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("Tuple Element 1 : "+person.Item1);
			Console.WriteLine("Tuple Element 2 : "+person.Item2);
			Console.WriteLine("Tuple Element 3 : "+person.Item3);
			Console.WriteLine("----------------------------------------------------");
		}
		public void TupleAccessingExceptLastElement()
		{
			var tuppcrea = System.Tuple.Create(1, "Sami Zayn", 3, 4, "Wes Lee", 58.9, true, 'A');
			Console.WriteLine("-----------------------------------------------");
			Console.WriteLine("Tuple Using Rest Property (First 7 Elements)");
			Console.WriteLine("-----------------------------------------------");
			Console.WriteLine("Tuple Element 1 : " + tuppcrea.Item1);
			Console.WriteLine("Tuple Element 2 : " + tuppcrea.Item2);
			Console.WriteLine("Tuple Element 3 : " + tuppcrea.Item3);
			Console.WriteLine("Tuple Element 4 : " + tuppcrea.Item4);
			Console.WriteLine("Tuple Element 5 : " + tuppcrea.Item5);
			Console.WriteLine("Tuple Element 6 : " + tuppcrea.Item6);
			Console.WriteLine("Tuple Element 7 : " + tuppcrea.Item7);

			//Console.WriteLine("Tuple Element 8 : " + tuppcrea.Item8);
			Console.WriteLine("-----------------------------------------------");
		}
		public void TupleUsingRestPropertyForLastElement()
		{
			var tuppcrea = System.Tuple.Create(1, "Sami Zayn", 3, 4, "Wes Lee", 58.9, true, 'A');

			Console.WriteLine("-----------------------------------------------");
			Console.WriteLine("Tuple Using Rest Property (Last Element())");
			Console.WriteLine("-----------------------------------------------");
			Console.WriteLine("Tuple Element 8 : " + tuppcrea.Rest);
			Console.WriteLine("-----------------------------------------------");

			Console.WriteLine("-----------------------------------------------");
			Console.WriteLine("Tuple Using Rest Property (Last Element())");
			Console.WriteLine("-----------------------------------------------");
			Console.WriteLine("Tuple Element 8 : " + tuppcrea.Rest.Item1);
			Console.WriteLine("-----------------------------------------------");
		}
		public void TupleNestedTuple()
		{
			var tuppcreb = System.Tuple.Create(1, "Sami Zayn", 3, 4, "Wes Lee", 58.9, true, 
											   System.Tuple.Create(2,"Judgement Day","WWE",'H',4.5,56.02,true,66));

			Console.WriteLine("-----------------------------------------------");
			Console.WriteLine("Tuple Using Rest Property (Last Element())");
			Console.WriteLine("-----------------------------------------------");
			Console.WriteLine("Tuple Element 8 : Rest : "  + tuppcreb.Rest);
			Console.WriteLine("Tuple Element 8 : Item1 : " + tuppcreb.Rest.Item1);
			Console.WriteLine("Tuple Element 8 : Item2 : " + tuppcreb.Rest.Item1.Item1);
			Console.WriteLine("Tuple Element 8 : Item3 : " + tuppcreb.Rest.Item1.Item2);
			Console.WriteLine("Tuple Element 8 : Item4 : " + tuppcreb.Rest.Item1.Item3);
			Console.WriteLine("Tuple Element 8 : Item5 : " + tuppcreb.Rest.Item1.Item4);
			Console.WriteLine("Tuple Element 8 : Item6 : " + tuppcreb.Rest.Item1.Item5);
			Console.WriteLine("Tuple Element 8 : Item7 : " + tuppcreb.Rest.Item1.Item6);
			Console.WriteLine("Tuple Element 8 : Item8 : " + tuppcreb.Rest.Item1.Item7);
			Console.WriteLine("Tuple Element 8 : Item8 (Nested) : " + tuppcreb.Rest.Item1.Rest);
			Console.WriteLine("Tuple Element 8 : Item8 (Nested) : " + tuppcreb.Rest.Item1.Rest.Item1);
			Console.WriteLine("-----------------------------------------------");
		}
		public void TupleAsAParameter()
		{
			Console.WriteLine("-----------------------------------------------");
			Console.WriteLine("Result where Tuple passed as a parameter");
			Console.WriteLine("-----------------------------------------------");
			var tupass = System.Tuple.Create(1, "KR Puram", "Nagavara");
			Passo(tupass);
		}
		public void Passo(Tuple<int,string,string> area)
		{
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine("| Number | From Address   | To Address");
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine($"| {area.Item1}     | {area.Item2} \t| {area.Item3}");
			Console.WriteLine("------------------------------------------------------------");
		}
		public Tuple<int, string, string> GetTupleReturnType()
		{
			return System.Tuple.Create(1, "KR Puram", "Nagavara");
		}
		public void TupleReturnTypeMethod()
		{
			//Assigning method to a variable
			var tgtup = GetTupleReturnType();
			Console.WriteLine("------------------------");
			Console.WriteLine("Tuple as a Return Type");
			Console.WriteLine("------------------------");
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine("| Number | From Address   | To Address");
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine($"| {tgtup.Item1}     | {tgtup.Item2} \t| {tgtup.Item3}");
			Console.WriteLine("------------------------------------------------------------");
		}
	}
}