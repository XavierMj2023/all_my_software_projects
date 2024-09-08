package org.studyeasy;

import java.util.LinkedList;
import java.util.List;

class Name{
	private String name;

	public Name(String name) {
		this.name = name;
	}

	@Override
	public String toString() {
		return name;
	}
}
public class Main {

	public static void main(String[] args) {
		//Compareable Interface
		//Instead of Name try using 'object'
		//List<Name> elements = new LinkedList<>();
		//For this porblem we will be using Generics in next chapter
		List<Object> elements = new LinkedList<>();
		elements.add(new Name("Chaand"));
		elements.add(new Name("Ed"));
		elements.add(new Name("John"));
		elements.add(new Name("Mia"));
		elements.add("Hello");
		elements.add(25);
		elements.add(52.2251);
		
		System.out.println("Displaying List of elements");
		System.out.println("-----------------------");
		System.out.println(elements);
		
		//Sort
		//There is a error. Custom Object and No Comparable Interface
		System.out.println("-----------------------");
		System.out.println("Displaying List of elements using names.sort(null)");
		System.out.println("-----------------------");
		elements.sort(null);
		System.out.println(elements);
		System.out.println("-----------------------");
		
	}
}
