package org.studyeasy;

import java.util.HashSet;
import java.util.LinkedHashSet;
import java.util.Set;
import java.util.TreeSet;

public class Main {

	public static void main(String[] args) {
		Set set = new HashSet();
		for (int i =  30;i >= 0; i--) {
			//set.add(i);
			set.add("A"+i);
		}
		System.out.println("---This is the output of HashSet---");
		System.out.println("------------------------------------");
		System.out.println(set);
		System.out.println("------------------------------------");
		
		//LinkedHashSet
		Set set2 = new LinkedHashSet();
		System.out.println("---This is the output of LinkedHashSet---");
		System.out.println("------------------------------------");
		for (int i =  30;i >= 0; i--) {
			//set.add(i);
			set2.add("A"+i);
		}
		System.out.println(set2);
		System.out.println("------------------------------------");
		
		Set<String> set3 = new TreeSet<>();
		System.out.println("---This is the output of TreeSet---");
		for (int i =  30;i >= 0; i--) {
			//set.add(i);
			set3.add("A"+i);
		}
		for (String x : set3) {
			System.out.println(x);
		}
		System.out.println("------------------------------------");
	}

}
