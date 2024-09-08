using OopsConcepts.PolyMorphism;

public class Program
{
	public static void Main(string[] args)
	{
		//1--------Polymorphism
		PolyMorphism poly = new PolyMorphism();
		//Case 1:
		poly.PolyMorphismPrint("Manoj");
		//Case 2:
		poly.PolyMorphismPrint("Manoj","Guddu");
		//case 3:
		poly.PolyMorphismPrint("Dolph", "Nemeth", "Ziggler");
		//case 4:
		poly.PolyMorphismPrint(101, 32, 46);
		//case 5:
		poly.PolyMorphismPrint("Timala",1201);

		//case 6:Error
		//poly.PolyMorphismPrint(1201,"Timmy");

		//2-----RunTimePolymorphism
		RunTimePolymorphism runTime = new RunTimePolymorphism();
		runTime.CallYa();

		//3-----Method Hiding
		Console.WriteLine("\n--------------Method Hiding---------------");
		MethodHiding mh = new MethodHiding();
		mh.CallYa();
		Console.WriteLine("-----------------------------");
	}
}