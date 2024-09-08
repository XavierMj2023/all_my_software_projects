package org.studyclassgroup;

import java.util.ArrayList;
import java.util.Collections;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

public class Set_BinarySearch_ConvertToList {
	
	public static void ConvertToList() {
		
		Set<String> set = new HashSet<>();
		set.add("Chaand");
		set.add("John");
		set.add("Aafiya");
		set.add("Mike");
		set.add("Rachel");
		set.add("Chaand");
		
		List<String> list = new ArrayList<>();
		list.addAll(set);
		System.out.println(list);
	}
	public static void ConvertToListAndSort() {
		
		Set<String> set = new HashSet<>();
		set.add("Chaand");
		set.add("John");
		set.add("Aafiya");
		set.add("Mike");
		set.add("Rachel");
		set.add("Chaand");
		
		List<String> list = new ArrayList<>();
		list.addAll(set);
		Collections.sort(list);
		System.out.println(list);
	}
	public static void BinarySearch() {
		
		Set<String> set = new HashSet<>();
		set.add("Chaand");
		set.add("John");
		set.add("Aafiya");
		set.add("Mike");
		set.add("Rachel");
		set.add("Chaand");
		
		List<String> list = new ArrayList<>();
		list.addAll(set);
		Collections.sort(list);
		System.out.println(list);
		
		//Binary Search
		System.out.println("The value to be searched is John : " +Collections.binarySearch(list,"John"));
		System.out.println("The value to be searched is john : " +Collections.binarySearch(list,"john"));
	}
}
