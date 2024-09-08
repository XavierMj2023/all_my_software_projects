package org.studyeasy.demo;

public class Outer {
	
	//Private int variable of Outer Class
	//private int testVar = 5;
	
	//Private Static int variable of Outer Class
	//private static int testVar = 5;
	
	//Private Static int variable of Outer Class with value = 0;
	//public static int x = 0;
	
	//Access Method of Static Type of Inner Class
	
//	private static void testingOuterMethod() {
//		System.out.println("From Outer Method");
//	}
	
	//Access Method of Static Type of Inner Class
	//This is for Demonstaration Class for how we can access Inner class elements from the Outer class
	//To access outside we need to mark it as public
	
//	public static void testingOuterMethod() {
//		System.out.println("Value of an Inner Class : "+Inner2.x);
//		Inner.testingInnerMethod2();
//	}
	
	//Access Method of Static Type of Inner Class
	//This is for Demonstaration Class for how we can access Inner class elements from the Outer class
	//To access outside we need to mark it as public
	//Remove Static
		
	public static void testingOuterMethod() {
			System.out.println("Value of an Inner Class : "+Inner2.x);
			Inner2.testingInnerMethod2();
	}
	
	public static class Inner{
		
		//Outer Class is Non Static
		//Inner Class is Static
		//Inner Method is Non Static 
		//This shows inconsistent 
		//So A True inner class is a class where everything is a static and then only we would be able to access the 
		//testing inner class method.
		
//		public void testingInnerMethod() {
//			System.out.println("Testing Inner Class Method");
//		}
		
		//This is for making Class static then only accessible.
		
//		public static void testingInnerMethod() {
//			System.out.println("Testing Inner Class Method");
//		}
		
		//Marking Inner Method of Inner Class as private
		
//		private static void testingInnerMethod() {
//			System.out.println("Testing Inner Class Method");
//		}
		
		//New Property or Variable
		
//		public static int x = 0;
		
		//New Property or Variable . We marking it as non static ; We get an error.
		
//		public int x = 0;
		
		//New Property or Variable . We marking it as non static ; We get an error.
		
		//private int x = 0;
		
		//Making property as  public static
		
//		public static int x = 0;
		
		//Accessing the outer class variable (testVar)
		//Accessing the Outer private variable from Inner Class
		//Change testVar to static (Suggestion)
		//Make use of Object of Outer Class Type
		
		//We were able to access variable in the form of Static and Non Static Variable 
		
		public static void testingInnerMethod() {
			//System.out.println("Testing Inner Class Method");
			
			//System.out.println("Test Variable value : "+testVar);
			
			//System.out.println("Test Variable value : "+new Outer().testVar);//Not a good way
			
			//Normal access to Static Variable
			
			//System.out.println("Test Variable value : "+testVar);
			
			//Access Method of Static Type of Inner Class
			
			//testingOuterMethod();
		}
	}
	
	//This is for Demonstaration Class for how we can access Inner class elements from the Outer class
	public static class Inner2{
		public static int x = 0;
		
		public static void testingInnerMethod2() {
			System.out.println("Testing Inner Class Method");
		}
		
	}
}
