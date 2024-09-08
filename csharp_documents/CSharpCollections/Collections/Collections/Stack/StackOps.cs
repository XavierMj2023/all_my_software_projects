using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Stack
{
	public class StackOps
	{
		Stack<int> stackint = new Stack<int>();

		Stack<string> stackstring = new Stack<string>();

		public void StackSwitch()
		{
			Console.WriteLine("Enter The Number To execute Stack ops");
			int sortnumopt = int.Parse(Console.ReadLine());
			switch (sortnumopt)
			{
				case 0: break;
				case 1:
					Console.WriteLine("--------------------------------------------------");
					Console.WriteLine("Shows The Syntax Of Stack");
					Console.WriteLine("--------------------------------------------------");
					StackSyntax();
					break;
				case 2:
					Console.WriteLine("--------------------------------------------------");
					Console.WriteLine("Adding elements to Stack using Push()");
					Console.WriteLine("--------------------------------------------------");
					StackPush();
					break;
				case 3:
					Console.WriteLine("--------------------------------------------------");
					Console.WriteLine("Removing elements to Stack using Pop()");
					Console.WriteLine("--------------------------------------------------");
					StackPop();
					break;
				case 4:
					Console.WriteLine("--------------------------------------------------");
					Console.WriteLine("Removing elements to Stack using Peek()");
					Console.WriteLine("--------------------------------------------------");
					StackPeek();
					break;
			}
		}
		public void StackPeek()
		{
			stackint.Push(1);
			stackint.Push(2);
			stackint.Push(3);

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Adding the elements to Stack Int using Push()");
			Console.WriteLine("---------------------------------------");
			foreach (var item in stackint)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");
			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Removing the elements to Stack Int using Peek()");
			Console.WriteLine("---------------------------------------");
			Console.WriteLine("The Last element is (but not removed) : " + stackint.Peek());
			Console.WriteLine("---------------------------------------");

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Element after using Peek()");
			Console.WriteLine("---------------------------------------");
			foreach (var item in stackint)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");
		}
		public void StackPop()
		{
			stackint.Push(1);
			stackint.Push(2);
			stackint.Push(3);

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Adding the elements to Stack Int using Push()");
			Console.WriteLine("---------------------------------------");
			foreach (var item in stackint)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");

			stackint.Pop();

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Removing the elements to Stack Int using Pop()");
			Console.WriteLine("---------------------------------------");
			foreach (var item in stackint)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");
		}
		public void StackPush()
		{
			//int
			stackint.Push(1);
			stackint.Push(2);
			stackint.Push(3);

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Adding the elements to Stack Int using Push()");
			Console.WriteLine("---------------------------------------");
			foreach (var item in stackint)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");

			//string
			stackstring.Push("Heel");
			stackstring.Push("Face");
			stackstring.Push("Goat");

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Adding the elements to Stack String using Push()");
			Console.WriteLine("---------------------------------------");
			foreach (var item in stackstring)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");

			//int array
			//int
			int[] intarr = new int[] { 1, 2, 3, 4 };
			Stack<int> stackintarr = new Stack<int>(intarr);

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Adding the elements to Stack Int Array using Push()");
			Console.WriteLine("---------------------------------------");
			foreach (var item in stackintarr)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");

			//string array
			string[] strarr = new string[] { "Delhi", "Madras", "Simplify" };
			Stack<string> stackstrarr = new Stack<string>(strarr);

			Console.WriteLine("---------------------------------------");
			Console.WriteLine("Adding the elements to Stack String Array using Push()");
			Console.WriteLine("---------------------------------------");
			foreach (var item in stackstrarr)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("---------------------------------------");
		}
		public void StackSyntax()
		{
			Console.WriteLine("--------------------------------------------------");
			Console.WriteLine("Stack<datatype> <var_name> = new Stack<datatype>");
			Console.WriteLine("--------------------------------------------------");
		}
		
	}
}
