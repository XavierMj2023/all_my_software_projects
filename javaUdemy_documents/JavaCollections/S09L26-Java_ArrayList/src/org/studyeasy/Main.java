package org.studyeasy;

import java.util.ArrayList;

public class Main {

	public static void main(String[] args) {
		
		//We need not to specify the data, the Java Compiler will handle it.
		//ArrayList<String> listNames = new ArrayList<String>();
		
		ArrayList<String> listNames = new ArrayList<>();
		
		//Adding using add();
		listNames.add("Chaand");
		listNames.add("John");
		listNames.add("Steve");
		listNames.add("Pooja");
		listNames.add("Rahul");
		listNames.add("Angel");
		listNames.add("Lisa");
		listNames.add("Jenifer");
		
		//Printing out the elements in ArrayList
		//Elements are stored in the indices in the sequential manner.(sequence)
		System.out.println(listNames);
		//[Chaand, John, Steve, Pooja, Rahul, Angel, Lisa, Jenifer]
		
		//You get error :- The type of the expression must be an array type but it resolved to ArrayList<String>
		//System.out.println(listNames[0]);
		
		//Solution for the above problem 
		//Iterating the loop using foreach loop
		for (String temp : listNames) {
			System.out.println(temp);
		}
		
		//Get Exact Value in ArrayList using get()
		System.out.println("The value of index 2 is : "+listNames.get(2));
		
		//Remove the Element in ArrayList by passing index value.
		listNames.remove(0);
		System.out.println(listNames);
		
		
	}	
}
