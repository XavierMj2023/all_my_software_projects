package org.studyeasy;

import java.util.LinkedList;
import java.util.List;

class Name implements Comparable<Name>{
	private String name;

	public Name(String name) {
		this.name = name;
	}

	@Override
	public String toString() {
		return name;
	}

	//Sort Based on the length of the string
	public int compareTo(Name obj) {
		if(name.length() == obj.name.length()) {
			return 0;
		}
		else if(name.length()>obj.name.length()) {
			return 1;
		}
		else {
			return -1;
		}
	}
	
}
public class Main {

	public static void main(String[] args) {
		//Compareable Interface
		List names = new LinkedList<>();
		names.add(new Name("Chaand"));
		names.add(new Name("Ed"));
		names.add(new Name("John"));
		names.add(new Name("Mia"));
		
		System.out.println("Displaying List of Names");
		System.out.println("-----------------------");
		System.out.println(names);
		
		//Sort
		//There is a error. Custom Object and No Comparable Interface
		System.out.println("-----------------------");
		System.out.println("Displaying List of Names using names.sort(null)");
		System.out.println("-----------------------");
		names.sort(null);
		System.out.println(names);
		System.out.println("-----------------------");
		
		
	}
}
