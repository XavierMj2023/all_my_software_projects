package org.studyeasy;

import java.util.LinkedList;
import java.util.List;

class Name{
	private String name;

	public Name(String name) {
		this.name = name;
	}
}
class Name2{
	private String name2;

	public Name2(String name2) {
		this.name2 = name2;
	}
	//Instead of Getter and Setter Generate ToString()

	@Override
	public String toString() {
		return name2;
	}
}
public class Main {

	public static void main(String[] args) {
		//ComapareTo Samples
		ComapreToSamples cts = new ComapreToSamples();
		cts.CallComapreToSamples();
		
		//Compareable Interface
		List names = new LinkedList<>();
		names.add(new Name("Chaand"));
		names.add(new Name("Ed"));
		names.add(new Name("John"));
		names.add(new Name("Mia"));
		
		//Before ToString()
		//Output : - [org.studyeasy.Name@156643d4, org.studyeasy.Name@123a439b, org.studyeasy.Name@7de26db8, org.studyeasy.Name@1175e2db]
		System.out.println("----Before ToString()--------");
		System.out.println(names);
		
		List names2 = new LinkedList<>();
		names2.add(new Name2("Chaand"));
		names2.add(new Name2("Ed"));
		names2.add(new Name2("John"));
		names2.add(new Name2("Mia"));
		
		//After ToString()
		//Output : - 
		System.out.println("----After ToString()--------");
		System.out.println(names2);//[Chaand, Ed, John, Mia]
		
		//Sort
		//There is a error. Custom Object and No Comparable Interface
		//names2.sort(null);
		//System.out.println(names2);
		
		
	}
}
