using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.PolyMorphism
{
	public class Person
	{
		public virtual void Greet()
		{
			Console.WriteLine("Hi Person");
		}
	}
	public class Employee : Person
	{
		public override void Greet()
		{
			Console.WriteLine("Hi Employee");
		}
	}
	public class MethodHiding
	{
		public void CallYa()
		{
			//case1 :
			Person p = new Person();
			p.Greet();//Hi Person

			//case2:
			Employee p2 = new Employee();
			p2.Greet();//Hi Employee

			//case3:
			Person p3 = new Employee();
			p3.Greet();//Hi Employee
		}
	}
}
