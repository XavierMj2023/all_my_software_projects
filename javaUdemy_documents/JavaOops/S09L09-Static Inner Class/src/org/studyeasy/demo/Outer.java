package org.studyeasy.demo;

public class Outer {
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
		
		public static int x = 0;
	}
}
