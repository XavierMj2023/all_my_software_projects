using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Queque
{
	public class QuequeOps
	{
		Queue<int> quequeint = new Queue<int>();

		Queue<string> quequestring = new Queue<string>();
		public void QuequeSwitch()
		{
			Console.WriteLine("Enter The Number To execute Queque ops");
			int sortnumopt = int.Parse(Console.ReadLine());
			switch (sortnumopt)
			{
				case 0: break;
				case 1:
					Console.WriteLine("--------------------------------------------------");
					Console.WriteLine("Shows The Syntax Of Queue");
					Console.WriteLine("--------------------------------------------------");
					QueueSyntax();
					break;
				case 2:
					Console.WriteLine("--------------------------------------------------");
					Console.WriteLine("Adding elements to Queue using Enqueue()");
					Console.WriteLine("--------------------------------------------------");
					QueueEnquque();
					break;
				case 3:
					Console.WriteLine("--------------------------------------------------");
					Console.WriteLine("Removing elements to Queue using Dequeue()");
					Console.WriteLine("--------------------------------------------------");
					QueueDequeue();
					break;
				case 4:
					Console.WriteLine("--------------------------------------------------");
					Console.WriteLine("Removing elements to Queue using Peek()");
					Console.WriteLine("--------------------------------------------------");
					QueuePeek();
					break;
			}
		}
		public void QueueSyntax()
		{
			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Queue<datatype> <var_item> = new Queue<datatype>");
			Console.WriteLine("---------------------------------------");
		}
		public void QueueEnquque()
		{
			//int
			quequeint.Enqueue(1);
			quequeint.Enqueue(2);
			quequeint.Enqueue(3);

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Adding the elements to Queque Int using Enqueue()");
			Console.WriteLine("---------------------------------------");
			foreach (var item in quequeint)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");

			//string
			quequestring.Enqueue("Heel");
			quequestring.Enqueue("Face");
			quequestring.Enqueue("Goat");

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Adding the elements to Queque String using Enqueue()");
			Console.WriteLine("---------------------------------------");
			foreach (var item in quequestring)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");

			//int array
			//int
			int[] intarr = new int[] { 1, 2, 3, 4 };
			Queue<int> queintarr = new Queue<int>(intarr);

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Adding the elements to Stack Int Array using Enqueue()");
			Console.WriteLine("---------------------------------------");
			foreach (var item in queintarr)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");

			//string array
			string[] questrarr = new string[] { "Delhi", "Madras", "Simplify" };
			Queue<string> stackstrarr = new Queue<string>(questrarr);

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Adding the elements to Queue String Array using Enqueue()");
			Console.WriteLine("---------------------------------------");
			foreach (var item in questrarr)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");
		}
		public void QueueDequeue()
		{
			quequeint.Enqueue(1);
			quequeint.Enqueue(2);
			quequeint.Enqueue(3);

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Adding the elements to Queue Int using Enqueue()");
			Console.WriteLine("---------------------------------------");
			foreach (var item in quequeint)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");

			quequeint.Dequeue();

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Removing the elements to Queue Int using Dequeue()");
			Console.WriteLine("---------------------------------------");
			foreach (var item in quequeint)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");
		}
		public void QueuePeek()
		{
			quequeint.Enqueue(1);
			quequeint.Enqueue(2);
			quequeint.Enqueue(3);

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Adding the elements to Queue Int using Enqueue()");
			Console.WriteLine("---------------------------------------");
			foreach (var item in quequeint)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");
			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Removing the elements to Queue Int using Peek()");
			Console.WriteLine("---------------------------------------");
			Console.WriteLine("The First element is (but not removed) : " + quequeint.Peek());
			Console.WriteLine("---------------------------------------");

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Element after using Peek()");
			Console.WriteLine("---------------------------------------");
			foreach (var item in quequeint)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");
		}
	}
}
