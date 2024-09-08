package org.studyeasy;

import org.studyeasy.demo.Outer;

public class App {

	public static void main(String[] args) {
		
		//You get error as we are making Inner Method of Inner Class as private
		
		//Outer.Inner.testingInnerMethod();
		
		//Accessing the Property/Variable of Inner Class
		
		//System.out.println(Outer.Inner.x);//0
		
		//Accessing the Property/Variable of Inner Class ; We marking it as non static
		
		//System.out.println(Outer.Inner.x);//0
		
		//Accessing the Property/Variable of Inner Class ; We marking it as private
		
		//System.out.println(Outer.Inner.x);//0
		
		//Making property as  public static
		
		//System.out.println(Outer.Inner.x);
		
		//Accessing the Outer private variable from Inner Class
		
		//Outer.Inner.testingInnerMethod2();
		
		//This is for Demonstaration Class for how we can access Inner class elements from the Outer class
		//Non static way of accessing
		
		//new Outer().testingOuterMethod();
		
		//This is for Demonstaration Class for how we can access Inner class elements from the Outer class
		//testingOuterMethod remove static
		//new Outer().testingOuterMethod(); //It works
		  
		
		//Accessing in static way.
		Outer.testingOuterMethod();//0
	}

}
