package org.studyeasy;

import java.util.ArrayList;

public class Main {

	public static void main(String[] args) {
		
		//We need not to specify the data, the Java Compiler will handle it.
		//ArrayList<String> listNames = new ArrayList<String>();
		
		ArrayList<String> listNames2 = new ArrayList<>();
		
		//Adding using add();
		listNames2.add("Chaand");
		listNames2.add("John");
		listNames2.add("Surya");
		listNames2.add("Fathima");
		System.out.println(listNames2.remove("Chand"));//false
		System.out.println(listNames2.remove("Chaand"));//true
		System.out.println(listNames2);//[John, Surya, Fathima]
		
		//Update element in ArrayList
		System.out.println(listNames2.set(0,"Steve"));
		System.out.println(listNames2);//[Steve, Surya, Fathima]
		
		//Update element in ArrayList beyond ;- you get error
		//System.out.println(listNames2.set(5,"Steve"));
		//System.out.println(listNames2);
		//Exception in thread "main" java.lang.IndexOutOfBoundsException: Index 5 out of bounds for length 3
		
		//To get the index of the element
		System.out.println("The value Surya index is : "+listNames2.indexOf("Surya"));
	
		//To get the index of the element beyond you get output as -1.
		System.out.println("The value Jake index is : "+listNames2.indexOf("Jake"));
		
		
	}	
}
