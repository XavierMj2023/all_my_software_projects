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
		
		System.out.println(Outer.Inner.x);
	}

}
