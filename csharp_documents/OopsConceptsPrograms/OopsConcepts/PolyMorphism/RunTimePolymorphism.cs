using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.PolyMorphism
{
	public class ParentClass
	{
		public void ParentInAChildMethod()
		{
			Console.WriteLine("Parent Class Called");
		}
	}
	public class ChildClass:ParentClass
	{
		public void ParentInAChildMethod()
		{
			Console.WriteLine("Child Method Called");
		}
	}
	public class ParentClass2
	{
		public virtual void ParentInAChildMethod()
		{
			Console.WriteLine("Parent Class Called");
		}
	}
	public class ChildClass2 : ParentClass2
	{
		public override void ParentInAChildMethod()
		{
			Console.WriteLine("Child Method Called");
		}
	}
	public class RunTimePolymorphism
	{
		public void CallYa()
		{
			//Calling Child Method
			ChildClass child = new ChildClass();
			child.ParentInAChildMethod(); //child method called

			//Calling Parent Method
			ParentClass parent = new ParentClass();
			parent.ParentInAChildMethod();//parent class method

			//Calling Parent Method from parent Class
			child.ParentInAChildMethod();//Child Method Called

			//Calling Parent Method from parent Class using keyword - virtual and override
			ParentClass2 parent2 = new ParentClass2();
			parent2.ParentInAChildMethod();
		}
	}
}
