using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.PolyMorphism
{
	public class PolyMorphism
	{
		public void PolyMorphismPrint(string str)
		{
			Console.WriteLine(str);
		}
		public void PolyMorphismPrint(string str1,string str2)
		{
			Console.WriteLine($"{str1} , {str2}");
		}
		public void PolyMorphismPrint(string str1, string str2,string str3)
		{
			Console.WriteLine($"{str1} , {str2} , {str3}");
		}
		public void PolyMorphismPrint(int str1, int str2, int str3)
		{
			Console.WriteLine($"{str1} , {str2} , {str3}");
		}
		/*
		 * Return Type is int ;Error
		 * --------------------------
		   public int PolyMorphismPrint(string str1,string str2,string str3)
		   {
			 Console.WriteLine($"{str1} , {str2} , {str3}");
			 return 0;
		   }
		*  --------------------------
		*/
		public void PolyMorphismPrint(string str3, int a)
		{
			Console.WriteLine($"{a},{str3}");
		}
		public void PolyMorphismPrint(int a, int str3)
		{
			Console.WriteLine($"{a},{str3}");
		}
	}
}
